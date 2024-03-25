using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Ocsp;
using static System.Net.Mime.MediaTypeNames;

namespace Atlantik
{
    public partial class formAjouterTarif : Form
    {
        MySqlConnection Connection = new MySqlConnection("server=localhost;port=3306;user id=root;password='';database=Atlantik");
        public formAjouterTarif()
        {
            InitializeComponent();
        }
        private void formAjouterTarif_Load(object sender, EventArgs e)
        {
            try
            {
                Connection.Open();
                InitTarif();
                InitSecteur();
                InitPeriode();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { Connection.Close(); }
        }
        private void InitTarif()
        {
            int i = 0;
            MySqlDataReader dataReader;
            string requete = "Select * from type";
            MySqlCommand cmd = new MySqlCommand(requete, Connection);
            dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                Label label = new Label();
                label.Name = "lbl" + dataReader.GetValue(0).ToString() + dataReader.GetValue(1).ToString();
                label.Text = dataReader.GetValue(0).ToString() + dataReader.GetValue(1).ToString() + " - " + dataReader.GetValue(2).ToString();
                label.Location = new System.Drawing.Point(20, 20 + (i * 30));
                label.Size = new System.Drawing.Size(150, 20);

                TextBox textBox = new TextBox();
                textBox.Name = "tbx" + dataReader.GetValue(0).ToString() + dataReader.GetValue(1).ToString();
                textBox.Location = new System.Drawing.Point(170, 20 + (i*30));
                textBox.Tag = dataReader.GetValue(0).ToString() + ";" + dataReader.GetValue(1).ToString();

                i++;

                gbxCatégorie.Controls.Add(label);
                gbxCatégorie.Controls.Add(textBox);
            }
            dataReader.Close();
        }
        private void InitSecteur()
        {
            MySqlDataReader dataReader;
            List<Secteur> secteurList = new List<Secteur>();
            string requete = "select * from Secteur";
            MySqlCommand cmd = new MySqlCommand(requete, Connection);
            dataReader = cmd.ExecuteReader();
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
        private void InitPeriode()
        {
            MySqlDataReader dataReader;
            List<Periode> periodesListe = new List<Periode>();
            string requete = "select * from Periode";
            MySqlCommand cmd = new MySqlCommand(requete,Connection);
            dataReader = cmd.ExecuteReader();

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

        private void lbxSecteurs_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Connection.Open();
                Secteur secteurSelectionne = (Secteur)lbxSecteurs.SelectedItem;
                int noSecteur = secteurSelectionne.getNoSecteur();
                MySqlDataReader dataReader;
                List<LiaisonPortArriveeDepart> liaisonListe = new List<LiaisonPortArriveeDepart>();

                string requete = "SELECT \r\n    L.NOLIAISON,\r\n    P1.NOM AS NOM_PORT_DEPART,\r\n    P2.NOM AS NOM_PORT_ARRIVEE\r\nFROM \r\n    liaison AS L\r\nINNER JOIN \r\n    port AS P1 ON L.NOPORT_DEPART = P1.NOPORT\r\nINNER JOIN \r\n    port AS P2 ON L.NOPORT_ARRIVEE = P2.NOPORT\r\nWHERE \r\n    L.NOSECTEUR = @nosecteur;";
                MySqlCommand cmd = new MySqlCommand(requete, Connection);
                cmd.Parameters.AddWithValue("@nosecteur", noSecteur);
                dataReader = cmd.ExecuteReader();

                liaisonListe.Clear();
                cbxLiaison.Items.Clear();

                while (dataReader.Read())
                {
                    liaisonListe.Add(new LiaisonPortArriveeDepart(int.Parse(dataReader.GetValue(0).ToString()), dataReader.GetValue(1).ToString(), dataReader.GetValue(2).ToString()));
                }
                foreach (LiaisonPortArriveeDepart liaison in liaisonListe)
                {
                    cbxLiaison.Items.Add(liaison);
                }
                dataReader.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { Connection.Close(); }
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            bool test = true;
            Periode perdiode = (Periode)cbxPeriode.SelectedItem;
            LiaisonPortArriveeDepart liaison = (LiaisonPortArriveeDepart)cbxLiaison.SelectedItem;

            foreach (Control textBox in gbxCatégorie.Controls)
            {
                if (textBox is TextBox)
                {
                    var regex = new Regex("^[0-9]*$");
                    var resultatRegex = regex.Match(textBox.Text);
                    if (!resultatRegex.Success)
                    {
                        textBox.BackColor = Color.Red;
                        test = false;
                    }
                }
            }
            if (test == true)
            {
                try
                {
                    Connection.Open();
                    foreach (Control controls in gbxCatégorie.Controls)
                    {
                        if (controls is TextBox)
                        {
                            TextBox textBox = (TextBox)controls;
                            string[] categorie = textBox.Tag.ToString().Split(';');
                            string requete = "insert into tarifer(Noperiode, Lettrecategorie, Notype, Noliaison, Tarif) values(@noperiode, @lettrecategorie, @notype, @noliaison, @tarif);";
                            MySqlCommand cmd = new MySqlCommand(requete, Connection);
                            cmd.Parameters.AddWithValue("@noperiode", perdiode.getNoPerdiode());
                            cmd.Parameters.AddWithValue("@noliaison", liaison.GetLiaison());
                            cmd.Parameters.AddWithValue("@lettrecategorie", categorie[0]);
                            cmd.Parameters.AddWithValue("@notype", categorie[1]);
                            cmd.Parameters.AddWithValue("@tarif", textBox.Text.ToString());
                            cmd.ExecuteNonQuery();
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
                    MessageBox.Show("Tarif(s) ajouter");
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Erreur de saisie");
            }
        }
    }
}
