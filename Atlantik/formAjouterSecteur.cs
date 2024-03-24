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
    public partial class formAjouterSecteur : Form
    {
        MySqlConnection Connection = new MySqlConnection("server=localhost;port=3306;user id=root;password='';database=Atlantik");
        public formAjouterSecteur()
        {
            InitializeComponent();
        }

        private void btnAjouterSecteur_Click(object sender, EventArgs e)
        {
            try
            {
                Connection.Open();
                string requete = "insert into Secteur(nom) values(@nom);";
                MySqlCommand cmd = new MySqlCommand(requete, Connection);
                cmd.Parameters.AddWithValue("@nom", tbxAjoutSecteur.Text);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Connection.Close();
                MessageBox.Show("Secteur Ajouté");
            }
        }
    }
}
