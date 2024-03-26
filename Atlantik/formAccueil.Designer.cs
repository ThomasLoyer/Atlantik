namespace Atlantik
{
    partial class formAccueil
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsAjouter = new System.Windows.Forms.ToolStripMenuItem();
            this.miSecteur = new System.Windows.Forms.ToolStripMenuItem();
            this.miPort = new System.Windows.Forms.ToolStripMenuItem();
            this.miLiaison = new System.Windows.Forms.ToolStripMenuItem();
            this.miTarifs = new System.Windows.Forms.ToolStripMenuItem();
            this.miBateau = new System.Windows.Forms.ToolStripMenuItem();
            this.miAjouterTraversee = new System.Windows.Forms.ToolStripMenuItem();
            this.tsModifier = new System.Windows.Forms.ToolStripMenuItem();
            this.miModifierBateau = new System.Windows.Forms.ToolStripMenuItem();
            this.miParamSite = new System.Windows.Forms.ToolStripMenuItem();
            this.tsAfficher = new System.Windows.Forms.ToolStripMenuItem();
            this.miTraversee = new System.Windows.Forms.ToolStripMenuItem();
            this.miDetail = new System.Windows.Forms.ToolStripMenuItem();
            this.aProposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suchDesignToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.muchSoftwareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsAjouter,
            this.tsModifier,
            this.tsAfficher,
            this.aProposToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(889, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsAjouter
            // 
            this.tsAjouter.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miSecteur,
            this.miPort,
            this.miLiaison,
            this.miTarifs,
            this.miBateau,
            this.miAjouterTraversee});
            this.tsAjouter.Name = "tsAjouter";
            this.tsAjouter.Size = new System.Drawing.Size(72, 24);
            this.tsAjouter.Text = "Ajouter";
            // 
            // miSecteur
            // 
            this.miSecteur.Name = "miSecteur";
            this.miSecteur.Size = new System.Drawing.Size(261, 26);
            this.miSecteur.Text = "Un secteur";
            this.miSecteur.Click += new System.EventHandler(this.miSecteur_Click);
            // 
            // miPort
            // 
            this.miPort.Name = "miPort";
            this.miPort.Size = new System.Drawing.Size(261, 26);
            this.miPort.Text = "Un port";
            this.miPort.Click += new System.EventHandler(this.miPort_Click);
            // 
            // miLiaison
            // 
            this.miLiaison.Name = "miLiaison";
            this.miLiaison.Size = new System.Drawing.Size(261, 26);
            this.miLiaison.Text = "Une liaison";
            this.miLiaison.Click += new System.EventHandler(this.miLiaison_Click);
            // 
            // miTarifs
            // 
            this.miTarifs.Name = "miTarifs";
            this.miTarifs.Size = new System.Drawing.Size(261, 26);
            this.miTarifs.Text = "Les Tarifs pour une liaison";
            this.miTarifs.Click += new System.EventHandler(this.miTarifs_Click);
            // 
            // miBateau
            // 
            this.miBateau.Name = "miBateau";
            this.miBateau.Size = new System.Drawing.Size(261, 26);
            this.miBateau.Text = "Un bateau";
            this.miBateau.Click += new System.EventHandler(this.miBateau_Click);
            // 
            // miAjouterTraversee
            // 
            this.miAjouterTraversee.Name = "miAjouterTraversee";
            this.miAjouterTraversee.Size = new System.Drawing.Size(261, 26);
            this.miAjouterTraversee.Text = "Une traversée";
            this.miAjouterTraversee.Click += new System.EventHandler(this.miAjouterTraversee_Click);
            // 
            // tsModifier
            // 
            this.tsModifier.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miModifierBateau,
            this.miParamSite});
            this.tsModifier.Name = "tsModifier";
            this.tsModifier.Size = new System.Drawing.Size(80, 24);
            this.tsModifier.Text = "Modifier";
            // 
            // miModifierBateau
            // 
            this.miModifierBateau.Name = "miModifierBateau";
            this.miModifierBateau.Size = new System.Drawing.Size(240, 26);
            this.miModifierBateau.Text = "Un bateau";
            this.miModifierBateau.Click += new System.EventHandler(this.miModifierBateau_Click);
            // 
            // miParamSite
            // 
            this.miParamSite.Name = "miParamSite";
            this.miParamSite.Size = new System.Drawing.Size(240, 26);
            this.miParamSite.Text = "Les paramètres du site";
            this.miParamSite.Click += new System.EventHandler(this.miParamSite_Click);
            // 
            // tsAfficher
            // 
            this.tsAfficher.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miTraversee,
            this.miDetail});
            this.tsAfficher.Name = "tsAfficher";
            this.tsAfficher.Size = new System.Drawing.Size(75, 24);
            this.tsAfficher.Text = "Afficher";
            // 
            // miTraversee
            // 
            this.miTraversee.Name = "miTraversee";
            this.miTraversee.Size = new System.Drawing.Size(662, 26);
            this.miTraversee.Text = "Les traversées pour une liaison et une date donnée avec places restantes par caté" +
    "gorie";
            this.miTraversee.Click += new System.EventHandler(this.miTraversee_Click);
            // 
            // miDetail
            // 
            this.miDetail.Name = "miDetail";
            this.miDetail.Size = new System.Drawing.Size(662, 26);
            this.miDetail.Text = "Les détails d\'une reservation pour un client";
            this.miDetail.Click += new System.EventHandler(this.miDetail_Click);
            // 
            // aProposToolStripMenuItem
            // 
            this.aProposToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.suchDesignToolStripMenuItem,
            this.muchSoftwareToolStripMenuItem,
            this.wowToolStripMenuItem});
            this.aProposToolStripMenuItem.Name = "aProposToolStripMenuItem";
            this.aProposToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.aProposToolStripMenuItem.Text = "A propos";
            // 
            // suchDesignToolStripMenuItem
            // 
            this.suchDesignToolStripMenuItem.Name = "suchDesignToolStripMenuItem";
            this.suchDesignToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.suchDesignToolStripMenuItem.Text = "Such design";
            // 
            // muchSoftwareToolStripMenuItem
            // 
            this.muchSoftwareToolStripMenuItem.Name = "muchSoftwareToolStripMenuItem";
            this.muchSoftwareToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.muchSoftwareToolStripMenuItem.Text = "Much software";
            // 
            // wowToolStripMenuItem
            // 
            this.wowToolStripMenuItem.Name = "wowToolStripMenuItem";
            this.wowToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.wowToolStripMenuItem.Text = "Wow";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Atlantik.Properties.Resources._6870619_20200211234736001_1_XLARGE;
            this.pictureBox1.Location = new System.Drawing.Point(12, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(863, 572);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // formAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 614);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "formAccueil";
            this.Text = "Accueil";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsAjouter;
        private System.Windows.Forms.ToolStripMenuItem miSecteur;
        private System.Windows.Forms.ToolStripMenuItem miPort;
        private System.Windows.Forms.ToolStripMenuItem miLiaison;
        private System.Windows.Forms.ToolStripMenuItem miTarifs;
        private System.Windows.Forms.ToolStripMenuItem miBateau;
        private System.Windows.Forms.ToolStripMenuItem miAjouterTraversee;
        private System.Windows.Forms.ToolStripMenuItem tsModifier;
        private System.Windows.Forms.ToolStripMenuItem miModifierBateau;
        private System.Windows.Forms.ToolStripMenuItem miParamSite;
        private System.Windows.Forms.ToolStripMenuItem tsAfficher;
        private System.Windows.Forms.ToolStripMenuItem miTraversee;
        private System.Windows.Forms.ToolStripMenuItem miDetail;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem aProposToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suchDesignToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem muchSoftwareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wowToolStripMenuItem;
    }
}