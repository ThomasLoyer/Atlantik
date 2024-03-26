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
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;

namespace Atlantik
{
    public partial class formAjouterPort : Form
    {
        MySqlConnection Connection = new MySqlConnection("server=localhost;port=3306;user id=root;password='';database=Atlantik");
        public formAjouterPort()
        {
            InitializeComponent();
        }
        private void btnAjouterPort_Click(object sender, EventArgs e)
        {
            var regex = new Regex("^[a-zA-Zéèêëçàâôù ûïî]*$");
            var resultatRegex = regex.Match(tbxAjouterPort.Text);
            if (!resultatRegex.Success || tbxAjouterPort.Text.Length == 0)
            {
                tbxAjouterPort.BackColor = Color.Red;
                MessageBox.Show("Erreur de saisie");
            }
            else
            {
                try
                {
                    Connection.Open();
                    string requete = "insert into Port(nom) values(@nom);";
                    MySqlCommand cmd = new MySqlCommand(requete, Connection);
                    cmd.Parameters.AddWithValue("@nom", tbxAjouterPort.Text);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    Connection.Close();
                    MessageBox.Show("Port Ajouter");
                    this.Close();
                }
            }
        }
    }
}
