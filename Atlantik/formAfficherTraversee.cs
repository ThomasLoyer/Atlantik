using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Atlantik
{
    public partial class formAfficherTraversee : Form
    {
        MySqlConnection Connection = new MySqlConnection("server=localhost;port=3306;user id=root;password='';database=Atlantik");
        public formAfficherTraversee()
        {
            InitializeComponent();
        }

        private void formAfficherTraversee_Load(object sender, EventArgs e)
        {
            try
            {
                lsvTraversee.Columns.Add("N°",30 );
                lsvTraversee.Columns.Add("Heure",42 );
                lsvTraversee.Columns.Add("Bateau",60 );
                lsvTraversee.Columns.Add("A Passager",70 );
                lsvTraversee.Columns.Add("B Véh.inf.2m ",75 );
                lsvTraversee.Columns.Add("C Véh.sup.2m",78);

                Connection.Open();
                Secteur_Load();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { Connection.Close(); }
        }
        private void Secteur_Load()
        {
            List<Secteur> secteurs = new List<Secteur>();
            MySqlDataReader reader;
            string requete = "select * from Secteur";
            MySqlCommand cmd = new MySqlCommand(requete, Connection);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                secteurs.Add(new Secteur(int.Parse(reader.GetValue(0).ToString()),reader.GetValue(1).ToString()));
            }
            foreach(Secteur s in secteurs)
            {
                lbxSecteur.Items.Add(s);
            }
            reader.Close();
        }
        private void lbxSecteur_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxLiaison.Items.Clear();
            Secteur secteur = (Secteur)lbxSecteur.SelectedItem;
            List<LiaisonPortArriveeDepart> liaisons = new List<LiaisonPortArriveeDepart>();

            try
            {
                Connection.Open();
                MySqlDataReader reader;
                string requete = "SELECT \r\n    L.NOLIAISON,\r\n    P1.NOM AS NOM_PORT_DEPART,\r\n    P2.NOM AS NOM_PORT_ARRIVEE\r\nFROM \r\n    liaison AS L\r\nINNER JOIN \r\n    port AS P1 ON L.NOPORT_DEPART = P1.NOPORT\r\nINNER JOIN \r\n    port AS P2 ON L.NOPORT_ARRIVEE = P2.NOPORT\r\nWHERE \r\n    L.NOSECTEUR = @nosecteur;";
                MySqlCommand cmd = new MySqlCommand(requete, Connection);
                cmd.Parameters.AddWithValue("@noSecteur", secteur.getNoSecteur());
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    liaisons.Add(new LiaisonPortArriveeDepart(int.Parse(reader.GetValue(0).ToString()), reader.GetValue(1).ToString(), reader.GetValue(2).ToString()));
                }
                foreach (LiaisonPortArriveeDepart liaison in liaisons)
                {
                    cbxLiaison.Items.Add(liaison);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { Connection.Close(); }
        }

        private void btnAfficher_Click(object sender, EventArgs e)
        {
            LiaisonPortArriveeDepart liaison = (LiaisonPortArriveeDepart)cbxLiaison.SelectedItem;
            string[] date = dtpDate.Value.ToString("yyyy-MM-dd;HH:mm").Split(';');
            lsvTraversee.Items.Clear();

            try
            {
                Connection.Open();
                MySqlDataReader reader;
                string requete = "SELECT b.NOM AS NomBateau,t.DATEHEUREDEPART, t.NOTRAVERSEE AS NumeroTraversee, MAX(CASE WHEN c.LETTRECATEGORIE = 'A' THEN c.CAPACITEMAX - e.QUANTITERESERVEE END) AS CapaciteRestante_A, MAX(CASE WHEN c.LETTRECATEGORIE = 'B' THEN c.CAPACITEMAX - e.QUANTITERESERVEE END) AS CapaciteRestante_B, MAX(CASE WHEN c.LETTRECATEGORIE = 'C' THEN c.CAPACITEMAX - e.QUANTITERESERVEE END) AS CapaciteRestante_C FROM traversee t JOIN bateau b ON b.NOBATEAU = t.NOBATEAU JOIN contenir c ON c.NOBATEAU = b.NOBATEAU JOIN categorie ca ON ca.LETTRECATEGORIE = c.LETTRECATEGORIE JOIN type ty ON ty.LETTRECATEGORIE = ca.LETTRECATEGORIE JOIN enregistrer e ON e.NOTYPE = ty.NOTYPE WHERE t.NOLIAISON = @noliaison AND LEFT(t.DATEHEUREDEPART, 10) = @date GROUP BY b.NOM, t.NOTRAVERSEE, t.DATEHEUREDEPART; ";
                MySqlCommand cmd = new MySqlCommand(requete, Connection);
                cmd.Parameters.AddWithValue("@noliaison", liaison.GetLiaison());
                cmd.Parameters.AddWithValue("@date", date[0]);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string[] heure = reader.GetValue(1).ToString().Split(' ');
                    string[] detailTraversee = { reader.GetValue(2).ToString(), heure[1] , reader.GetValue(0).ToString(), reader.GetValue(3).ToString(), reader.GetValue(4).ToString(), reader.GetValue(5).ToString() };
                    lsvTraversee.Items.Add(new ListViewItem(detailTraversee));
                }
                reader.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally 
            { 
                Connection.Close();
            }
        }
    }
}
