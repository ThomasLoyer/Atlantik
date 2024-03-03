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
    public partial class formAjouterBateau : Form
    {
        MySqlConnection Connection = new MySqlConnection("server=localhost;port=3306;user id=root;password='';database=Atlantik");
        public formAjouterBateau()
        {
            InitializeComponent();
        }

        private void formAjouterBateau_Load(object sender, EventArgs e)
        {
            string[] nomLabel = { "lblA", "lblB", "lblC" };
            string[] textLabel = { "A (passager) :", "B (véhi.inf.2M) :", "C (véhi.sup.2M) :" };
            string[] nomTextBox = { "tbxA", "tbxB", "tbxC" };
            for (int i = 0; i < nomLabel.Length; i++)
            {
                Label label = GenerationElementDynamique.GenererLabel(nomLabel[i], textLabel[i],200,50+(i*30),100,20);
                this.Controls.Add(label);
                TextBox textBox = GenerationElementDynamique.GenererTextBox(nomTextBox[i], 300, 50 + (i * 30));
                this.Controls.Add(textBox);
            }
            GroupBox groupBox = GenerationElementDynamique.GenererGroupBox("Capacités maximales", 175, 25, 250, 120);
            this.Controls.Add(groupBox);
        }

        private void btnAjouterBateau_Click(object sender, EventArgs e)
        {
            try
            {
                Connection.Open();
                string requete = "insert into Bateau(Nom) Values(@nom);";
                MySqlCommand cmd = new MySqlCommand(requete, Connection);
                cmd.Parameters.AddWithValue("@nom",tbxNomBateau.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Bateau ajouter");
            }
            catch 
            {
                MessageBox.Show("Erreur");
            }
            finally 
            {
                Connection.Close(); 
            }
        }
    }
}
