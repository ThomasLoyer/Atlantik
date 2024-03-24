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
    public partial class formAccueil : Form
    {
        public formAccueil()
        {
            InitializeComponent();
        }

        private void miSecteur_Click(object sender, EventArgs e)
        {
            formAjouterSecteur ajouterSecteur = new formAjouterSecteur();
            ajouterSecteur.ShowDialog();
        }

        private void miPort_Click(object sender, EventArgs e)
        {
            formAjouterPort ajouterPort = new formAjouterPort();
            ajouterPort.ShowDialog();
        }

        private void miLiaison_Click(object sender, EventArgs e)
        {
            formAjoutLiaison ajoutLiaison = new formAjoutLiaison();
            ajoutLiaison.ShowDialog();
        }

        private void miTarifs_Click(object sender, EventArgs e)
        {
            formAjouterTarif ajouterTarif = new formAjouterTarif();
            ajouterTarif.ShowDialog();
        }

        private void miBateau_Click(object sender, EventArgs e)
        {
            formAjouterBateau ajouterBateau = new formAjouterBateau();
            ajouterBateau.ShowDialog();
        }

        private void miAjouterTraversee_Click(object sender, EventArgs e)
        {
            Ajouter_une_traversée ajouterTraversee = new Ajouter_une_traversée();
            ajouterTraversee.ShowDialog();
        }

        private void miModifierBateau_Click(object sender, EventArgs e)
        {
            formModifierBateau modifierBateau = new formModifierBateau();
            modifierBateau.ShowDialog();
        }

        private void miParamSite_Click(object sender, EventArgs e)
        {
            formModifierParamètresSite modifierParamètresSite = new formModifierParamètresSite();
            modifierParamètresSite.ShowDialog();
        }

        private void miDetail_Click(object sender, EventArgs e)
        {
            formDetailsReservation detailsReservation = new formDetailsReservation();
            detailsReservation.ShowDialog();
        }

        private void miTraversee_Click(object sender, EventArgs e)
        {
            formAfficherTraversee afficherTraversee = new formAfficherTraversee();
            afficherTraversee.ShowDialog();
        }
    }
}
