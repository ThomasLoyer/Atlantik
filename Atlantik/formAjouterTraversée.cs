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
    public partial class Ajouter_une_traversée : Form
    {
        MySqlConnection Connection = new MySqlConnection("server=localhost;port=3306;user id=root;password='';database=Atlantik");
        List<Secteur> secteurs = new List<Secteur>();
        List<LiaisonPortArriveeDepart> liaisons = new List<LiaisonPortArriveeDepart>();
        List<Bateau> bateaux = new List<Bateau>();
        public Ajouter_une_traversée()
        {
            InitializeComponent();
        }

        private void Ajouter_une_traversée_Load(object sender, EventArgs e)
        {
            try
            {
                Connection.Open();
                Secteur_Load();
                Bateau_Load();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { Connection.Close(); }
        }
        private void Secteur_Load()
        {
            MySqlDataReader dataReader;
            string requete = "select * from Secteur";
            MySqlCommand cmd = new MySqlCommand(requete, Connection);
            dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                secteurs.Add(new Secteur(int.Parse(dataReader.GetValue(0).ToString()), dataReader.GetValue(1).ToString()));
            }
            foreach (Secteur secteur in secteurs)
            {
                lbxSecteur.Items.Add(secteur);
            }
            dataReader.Close();
        }
        private void Bateau_Load()
        {
            MySqlDataReader dataReader;
            string requete = "select * from Bateau";
            MySqlCommand cmd = new MySqlCommand(requete, Connection);
            dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                bateaux.Add(new Bateau(int.Parse(dataReader.GetValue(0).ToString()),dataReader.GetValue(1).ToString()));
            }
            foreach (Bateau b in bateaux)
            {
                cbxNomBateau.Items.Add(b);
            }
            dataReader.Close();
        }
        private void lbxSecteur_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Connection.Open();
                cbxLiaison.Items.Clear();
                liaisons.Clear();
                Secteur secteurSelectionnee = (Secteur)lbxSecteur.SelectedItem;
                int noSecteur = secteurSelectionnee.getNoSecteur();
                MySqlDataReader dataReader;
                string requete = "SELECT \r\n    L.NOLIAISON,\r\n    P1.NOM AS NOM_PORT_DEPART,\r\n    P2.NOM AS NOM_PORT_ARRIVEE\r\nFROM \r\n    liaison AS L\r\nINNER JOIN \r\n    port AS P1 ON L.NOPORT_DEPART = P1.NOPORT\r\nINNER JOIN \r\n    port AS P2 ON L.NOPORT_ARRIVEE = P2.NOPORT\r\nWHERE \r\n    L.NOSECTEUR = @nosecteur;";
                MySqlCommand cmd = new MySqlCommand(requete, Connection);
                cmd.Parameters.AddWithValue("@nosecteur", noSecteur);
                dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    liaisons.Add(new LiaisonPortArriveeDepart(int.Parse(dataReader.GetValue(0).ToString()), dataReader.GetValue(1).ToString(), dataReader.GetValue(2).ToString()));
                }
                foreach (LiaisonPortArriveeDepart liaison in liaisons)
                {
                    cbxLiaison.Items.Add(liaison);
                }
                dataReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { Connection.Close(); }
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            LiaisonPortArriveeDepart liaisonSelectionnee = (LiaisonPortArriveeDepart)cbxLiaison.SelectedItem;
            Secteur secteurSelectionnee = (Secteur)lbxSecteur.SelectedItem;
            Bateau bateauSelectionnee = (Bateau)cbxNomBateau.SelectedItem;
            int liaison = liaisonSelectionnee.GetLiaison();
            int secteur = secteurSelectionnee.getNoSecteur();
            int bateau = bateauSelectionnee.getNoBateau();

            try
            {
                Connection.Open();
                string requete = "insert into Traversee(NOLIAISON, NOBATEAU, DATEHEUREDEPART, DATEHEUREARRIVEE) values(@liaison, @bateau, @dateDepart, @dateArrivee)";
                MySqlCommand cmd = new MySqlCommand(requete, Connection);
                cmd.Parameters.AddWithValue("@liaison", liaison);
                cmd.Parameters.AddWithValue("@bateau", bateau);
                cmd.Parameters.AddWithValue("@dateDepart", dtpDepart.Value);
                cmd.Parameters.AddWithValue("@dateArrivee", dtpArrivee.Value);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally 
            { 
                Connection.Close();
                MessageBox.Show("Traversée ajouté");
            }
        }
    }
}
