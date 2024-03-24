using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atlantik
{
    public partial class formDetailsReservation : Form
    {
        MySqlConnection Connection = new MySqlConnection("server=localhost;port=3306;user id=root;password='';database=Atlantik");
        List<Client> clients = new List<Client>();
        public formDetailsReservation()
        {
            InitializeComponent();
        }

        private void formDetailsReservation_Load(object sender, EventArgs e)
        {
            lvDetail.Columns.Add("n° Réservation",90);
            lvDetail.Columns.Add("Laision", 120);
            lvDetail.Columns.Add("n° Traversée", 75);
            lvDetail.Columns.Add("Date départ", 120);

            try
            {
                Connection.Open();
                MySqlDataReader dataReader;
                string requete = "select * from Client";
                MySqlCommand cmd = new MySqlCommand(requete, Connection);
                dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    clients.Add(new Client(int.Parse(dataReader.GetValue(0).ToString()), dataReader.GetValue(1).ToString(), dataReader.GetValue(2).ToString()));
                }
                foreach (Client client in clients)
                {
                    cbxNomPrenom.Items.Add(client);
                }
                dataReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { Connection.Close(); }
        }

        private void cbxNomPrenom_SelectedIndexChanged(object sender, EventArgs e)
        {
            Client client = (Client)cbxNomPrenom.SelectedItem;
            lvDetail.Items.Clear();

            try
            {
                Connection.Open();
                MySqlDataReader reader;
                string requete = "SELECT r.NORESERVATION, t.NOTRAVERSEE, t.DATEHEUREDEPART, p_depart.NOM AS PortDepart, p_arrivee.NOM AS PortArrivee FROM reservation r JOIN traversee t ON r.NOTRAVERSEE = t.NOTRAVERSEE JOIN liaison l ON t.NOLIAISON = l.NOLIAISON JOIN port p_depart ON l.NOPORT_DEPART = p_depart.NOPORT JOIN port p_arrivee ON l.NOPORT_ARRIVEE = p_arrivee.NOPORT WHERE r.NOCLIENT = @noClient; ";
                MySqlCommand cmd = new MySqlCommand(requete, Connection);
                cmd.Parameters.AddWithValue("@noClient", client.GetNoClient());
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string[] details = { reader.GetValue(0).ToString(), reader.GetValue(3).ToString() + " - " + reader.GetValue(4).ToString(), reader.GetValue(1).ToString(), reader.GetValue(2).ToString() };
                    lvDetail.Items.Add(new ListViewItem(details));
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { Connection.Close(); }
        }

        private void lvDetail_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            Client client = (Client)cbxNomPrenom.SelectedItem;
            int i = 0;
            List<string> list = new List<string>();
            int noTraversee = 0;
            gbxReservation.Controls.Clear();

            if (lvDetail.SelectedItems.Count > 0)
            {
                noTraversee = int.Parse(lvDetail.SelectedItems[0].SubItems[0].Text.ToString());
            }

            try
            {
                Connection.Open();
                MySqlDataReader reader;
                string requete = "SELECT t.LIBELLE, SUM(e.QUANTITERESERVEE) FROM reservation r JOIN enregistrer e ON r.NORESERVATION = e.NORESERVATION JOIN type t ON e.LETTRECATEGORIE = t.LETTRECATEGORIE AND e.NOTYPE = t.NOTYPE JOIN client c ON r.NOCLIENT = c.NOCLIENT WHERE r.NORESERVATION = @noCommande GROUP BY t.LIBELLE; ";
                MySqlCommand cmd = new MySqlCommand(requete, Connection);
                cmd.Parameters.AddWithValue("@noCommande", noTraversee);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(reader.GetValue(0).ToString() + " : " + reader.GetValue(1).ToString());
                }
                foreach (string categorie in list)
                {
                    Label label = new Label();
                    label.Text = categorie;
                    label.Location = new System.Drawing.Point(20, 20 + (i * 30));
                    label.Size = new System.Drawing.Size(150, 20);
                    i++;

                    gbxReservation.Controls.Add(label);
                }
                reader.Close();

                string montantTotal = "";
                requete = "SELECT MONTANTTOTAL FROM `reservation` WHERE NORESERVATION = @noReservation;";
                cmd = new MySqlCommand(requete, Connection);
                cmd.Parameters.AddWithValue("@noReservation", noTraversee);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    montantTotal = "Montant total : " + reader.GetValue(0).ToString();

                    Label labelMontant = new Label();
                    labelMontant.Text = montantTotal;
                    labelMontant.Location = new System.Drawing.Point(20, 20 + (i * 30));
                    labelMontant.Size = new System.Drawing.Size(150, 20);
                    i++;

                    gbxReservation.Controls.Add(labelMontant);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { Connection.Close(); }
        }
    }
}
