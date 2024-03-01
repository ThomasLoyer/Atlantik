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
using MySql.Data.MySqlClient;

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
            Connection.Open();
            string requete = "insert into Port(nom) values(@nom);";
            MySqlCommand cmd = new MySqlCommand(requete, Connection);
            cmd.Parameters.AddWithValue("@nom", tbxAjouterPort.Text);
            cmd.ExecuteNonQuery();
            Connection.Close();
            MessageBox.Show("Port Ajouter");
        }
    }
}