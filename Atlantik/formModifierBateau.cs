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
    public partial class formModifierBateau : Form
    {
        MySqlConnection Connection = new MySqlConnection("server=localhost;port=3306;user id=root;password='';database=Atlantik");
        List<Bateau> bateauList = new List<Bateau>();
        int bateauSelectionner;
        public formModifierBateau()
        {
            InitializeComponent();
        }
        private void formModifierBateau_Load(object sender, EventArgs e)
        {
            try
            {
                Connection.Open();
                CbxNomBateau_Load();
                Capacite_Load();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { Connection.Close(); }
        }
        private void CbxNomBateau_Load()
        {
            MySqlDataReader dataReader;
            string requete = "select * from Bateau";
            MySqlCommand cmd = new MySqlCommand(requete, Connection);
            dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                bateauList.Add(new Bateau(int.Parse(dataReader.GetValue(0).ToString()), dataReader.GetValue(1).ToString()));
            }
            foreach (Bateau b in bateauList)
            {
                cbxNomBateau.Items.Add(b);
            }
            dataReader.Close();
        }
        private void Capacite_Load()
        {
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
        }
        private void btnModifier_Click(object sender, EventArgs e)
        {
            try
            {
                Connection.Open();
                Bateau bateau = (Bateau)cbxNomBateau.SelectedItem;
                int noBateau = bateau.getNoBateau();
                foreach (Control c in gbxCapacite.Controls)
                {
                    if (c is TextBox)
                    {
                        string requete = "update Contenir \r\nset CAPACITEMAX = @capacite\r\nwhere NOBATEAU = @noBateau and LETTRECATEGORIE = @lettre;";
                        MySqlCommand cmd = new MySqlCommand(requete, Connection);
                        cmd.Parameters.AddWithValue("@lettre", c.Tag.ToString());
                        cmd.Parameters.AddWithValue("@capacite", c.Text.ToString());
                        cmd.Parameters.AddWithValue("@noBateau", noBateau);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally 
            {
                Connection.Close();
                MessageBox.Show("Bateau Modifié");
            }
        }
    }
}
