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
        }
        private void formAjouterTarif_Load(object sender, EventArgs e)
        {
            Connection.Open();
            InitTarifCategorie();
            InitSecteur();
        }
    }
}
