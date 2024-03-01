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
    public partial class formAjouterTarif : Form
    {
        MySqlConnection Connection = new MySqlConnection("server=localhost;port=3306;user id=root;password='';database=Atlantik");
        public formAjouterTarif()
        {
            InitializeComponent();
        }
        private void InitTarifCategorie()
        {
            GroupBox groupBox = new GroupBox();
            groupBox.Text = "Tarifs par Catégorie-Type";
            groupBox.Location = new Point(175,25);
            groupBox.Size = new Size(300, 275);

            string[] textLabel = { "A1 - Adulte:", "A2 - Junior 8 à 18 ans:", "A3 - Enfant 0 à 7 ans:", "B1 - Voiture long.inf.4m:", "B2 - Voiture long.inf.5m:", "C1 - Fourgon:", "C2 - Camping Car:", "C3 - Camion:" };
            string[] nomLabel = { "lblA1", "lblA2", "lblA3", "lblB1", "lblB2", "lblC1", "lblC2", "lblC3" };
            string[] nomTextBox = { "tbxA1", "tbxA2", "tbxA3", "tbxB1", "tbxB2", "tbxC1", "tbxC2", "tbxC3" };

            for (int i = 0; i < textLabel.Length; i++)
            {
                Label label = GenerationElementDynamique.GenererLabel(nomLabel[i], textLabel[i], 200, 50 + (i * 30));
                this.Controls.Add(label);
                TextBox textBox = GenerationElementDynamique.GenererTextBox(nomTextBox[i], 350, 50 + (i*30));
                this.Controls.Add(textBox);
            }

            this.Controls.Add(groupBox);
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
                lbxSecteurs.Items.Add(secteur);
            }
            dataReader.Close();
        }
        private void InitPeriode()
        {
            MySqlDataReader dataReader;
            List<Periode> periodesListe = new List<Periode>();
            dataReader = SetupReader("select * from Periode");

            while (dataReader.Read())
            {
                periodesListe.Add(new Periode(int.Parse(dataReader.GetValue(0).ToString()), dataReader.GetValue(1).ToString(), dataReader.GetValue(2).ToString()));
            }
            foreach(Periode periode in periodesListe)
            {
                cbxPeriode.Items.Add(periode);
            }
            dataReader.Close();
        }
        private void formAjouterTarif_Load(object sender, EventArgs e)
        {
            Connection.Open();
            InitTarifCategorie();
            InitSecteur();
            InitPeriode();
            Connection.Close();
        }

        private void lbxSecteurs_SelectedIndexChanged(object sender, EventArgs e)
        {
            Connection.Open();
            Secteur secteurSelectionne = (Secteur)lbxSecteurs.SelectedItem;
            int noSecteur = secteurSelectionne.getNoSecteur();
            MySqlDataReader dataReader;
            List<LiaisonPortArriveeDepart> liaisonListe = new List<LiaisonPortArriveeDepart>();

            string requete = "SELECT \r\n    L.NOSECTEUR,\r\n    P1.NOM AS NOM_PORT_DEPART,\r\n    P2.NOM AS NOM_PORT_ARRIVEE\r\nFROM \r\n    liaison AS L\r\nINNER JOIN \r\n    port AS P1 ON L.NOPORT_DEPART = P1.NOPORT\r\nINNER JOIN \r\n    port AS P2 ON L.NOPORT_ARRIVEE = P2.NOPORT\r\nWHERE \r\n    L.NOSECTEUR = @nosecteur;";
            MySqlCommand cmd = new MySqlCommand(requete, Connection);
            cmd.Parameters.AddWithValue("@nosecteur",noSecteur);
            dataReader = cmd.ExecuteReader();

            liaisonListe.Clear();
            cbxLiaison.Items.Clear();

            while (dataReader.Read())
            {
                liaisonListe.Add(new LiaisonPortArriveeDepart(int.Parse(dataReader.GetValue(0).ToString()), dataReader.GetValue(1).ToString(), dataReader.GetValue(2).ToString()));
            }
            foreach (LiaisonPortArriveeDepart portDepartArrivee in liaisonListe)
            {
                cbxLiaison.Items.Add(portDepartArrivee);
            }
            dataReader.Close();
            Connection.Close();
        }
    }
}
