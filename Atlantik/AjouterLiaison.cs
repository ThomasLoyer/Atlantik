using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Atlantik
{
    public partial class formAjoutLiaison : Form
    {
        MySqlConnection Connection = new MySqlConnection("server=localhost;port=3306;user id=root;password='';database=Atlantik");
        public formAjoutLiaison()
        {
            InitializeComponent();
        }
        private void écranAjoutLiaison_Load(object sender, EventArgs e)
        {
            try
            {
                Connection.Open();
                InitSecteur();
                InitDepartArrivee();
            }
            catch
            {
                MessageBox.Show("Erreur connexion");
            }
            finally
            {
                if(Connection is object & Connection.State == ConnectionState.Open)
                {
                    Connection.Close();
                }
            }
        }
        private MySqlDataReader SetupReader(string requete)
        {
            MySqlCommand cmd = new MySqlCommand(requete, Connection);
            return cmd.ExecuteReader();
        }
        private void InitSecteur()
        {
            MySqlDataReader dataReader;
            List<Secteur> secteurList = new List<Secteur>();
            dataReader = SetupReader("select * from Secteur");
            while (dataReader.Read())
            {
                secteurList.Add(new Secteur(int.Parse(dataReader.GetValue(0).ToString()), dataReader.GetValue(1).ToString()));
            }
            dataReader.Close();
            foreach (Secteur secteur in secteurList)
            {
                lbxSecteur.Items.Add(secteur);
            }
        }
        private void InitDepartArrivee()
        {           
            MySqlDataReader dataReader;
            List<Port> portList = new List<Port>();
            dataReader = SetupReader("select * from Port");
            while (dataReader.Read())
            {
                portList.Add(new Port(int.Parse(dataReader.GetValue(0).ToString()), dataReader.GetValue(1).ToString()));
            }
            dataReader.Close();
            foreach (Port port in portList)
            {
                cbxArrivee.Items.Add(port);
                cbxDepart.Items.Add(port);
            }
        }
        private void btnAjouter_Click(object sender, EventArgs e)
        {

            Secteur secteurSelectionne = (Secteur)lbxSecteur.SelectedItem;
            int noSecteur = secteurSelectionne.getNoSecteur();
            Port portDepart = (Port)cbxDepart.SelectedItem;
            int noPortDepart = portDepart.GetNoPort();
            Port PortArrivee = (Port)cbxArrivee.SelectedItem;
            int noPortArrivee = PortArrivee.GetNoPort();
            double distance = double.Parse(tbxDistance.Text);

            Connection.Open();
            string requete = "insert into liaison(noport_depart, nosecteur, noport_arrivee, distance) values(@depart, @secteur, @arrivee, @distance)";
            var cmd = new MySqlCommand(requete, Connection);
            cmd.Parameters.AddWithValue("@depart", noPortDepart);
            cmd.Parameters.AddWithValue("@secteur", noSecteur);
            cmd.Parameters.AddWithValue("@arrivee", noPortArrivee);
            cmd.Parameters.AddWithValue("@distance", distance);
            cmd.ExecuteNonQuery();
        }
    }
}
