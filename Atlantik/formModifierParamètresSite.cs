﻿using MySql.Data.MySqlClient;
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
    public partial class formModifierParamètresSite : Form
    {
        MySqlConnection Connection = new MySqlConnection("server=localhost;port=3306;user id=root;password='';database=Atlantik");
        public formModifierParamètresSite()
        {
            InitializeComponent();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            int valeurCheckBox = 0;
            if (cbProduction.Checked == true) { valeurCheckBox = 1; }

            try
            {
                Connection.Open();
                string requete = "update parametres set SITE_PB = @site, RANG_PB = @rang, IDENTIFIANT_PB = @identifiant, CLEHMAC_PB = @CleHMAC, ENPRODUCTION = @enProd, MELSITE = @melSite;";
                MySqlCommand cmd = new MySqlCommand(requete, Connection);
                cmd.Parameters.AddWithValue("@site", tbxSite.Text);
                cmd.Parameters.AddWithValue("@rang", tbxRang.Text);
                cmd.Parameters.AddWithValue("@identifiant", tbxIdentifiant.Text);
                cmd.Parameters.AddWithValue("@cleHMAC", tbxCleHMAC.Text);
                cmd.Parameters.AddWithValue("@enProd", valeurCheckBox);
                cmd.Parameters.AddWithValue("@melSite", tbxMelSite.Text);
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally 
            { 
                Connection.Close();
                MessageBox.Show("Parmètres du site modifiés");
            }
        }
    }
}
