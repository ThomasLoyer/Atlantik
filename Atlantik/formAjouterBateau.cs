using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atlantik
{
    public partial class formAjouterBateau : Form
    {
        MySqlConnection Connection = new MySqlConnection("server=localhost;port=3306;user id=root;password='';database=Atlantik");
        List<Bateau> BateauList;
        public formAjouterBateau()
        {
            InitializeComponent();
        }
        private void formAjouterBateau_Load(object sender, EventArgs e)
        {
            try
            {
                Connection.Open();
                int i = 0;
                string requete = "select * from categorie";
                MySqlDataReader dataReader;
                MySqlCommand cmd = new MySqlCommand(requete, Connection);
                dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    Label label = new Label();
                    label.Name = "lbl" + dataReader.GetValue(0).ToString() + dataReader.GetValue(1).ToString();
                    label.Text = dataReader.GetValue(0).ToString() + " - " + dataReader.GetValue(1).ToString();
                    label.Location = new System.Drawing.Point(20, 20 + (i * 30));
                    label.Size = new System.Drawing.Size(100, 20);

                    TextBox textBox = new TextBox();
                    textBox.Tag = dataReader.GetValue(0).ToString();
                    textBox.Location = new System.Drawing.Point(120, 20 + (i * 30));

                    i++;

                    gbxCapacite.Controls.Add(label);
                    gbxCapacite.Controls.Add(textBox);
                }
                dataReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Connection.Close();
            }
        }
        private void btnAjouterBateau_Click(object sender, EventArgs e)
        {
            try
            {
                Connection.Open();
                string requeteBateau = "insert into Bateau(nom) values(@nom);";
                MySqlCommand cmd = new MySqlCommand(requeteBateau, Connection);
                cmd.Parameters.AddWithValue("@nom", tbxNomBateau.Text);
                cmd.ExecuteNonQuery();
                long noBateau = cmd.LastInsertedId;

                foreach (Control control in gbxCapacite.Controls)
                {
                    if (control is TextBox)
                    {
                        string requeteCapacite = "insert into Contenir(LETTRECATEGORIE, NOBATEAU, CAPACITEMAX) values(@lettre, @noBateau, @max);";
                        MySqlCommand cmdCapacite = new MySqlCommand(requeteCapacite, Connection);
                        cmdCapacite.Parameters.AddWithValue("@lettre", control.Tag.ToString());
                        cmdCapacite.Parameters.AddWithValue("@max", control.Text.ToString());
                        cmdCapacite.Parameters.AddWithValue("@noBateau", noBateau);
                        cmdCapacite.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Connection.Close();
                MessageBox.Show("Bateau ajouté");
            }
        }
    }
}
