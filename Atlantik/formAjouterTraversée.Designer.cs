namespace Atlantik
{
    partial class Ajouter_une_traversée
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
            this.lblSecteur = new System.Windows.Forms.Label();
            this.lbxSecteur = new System.Windows.Forms.ListBox();
            this.lblLiaison = new System.Windows.Forms.Label();
            this.cbxLiaison = new System.Windows.Forms.ComboBox();
            this.lblNomBateau = new System.Windows.Forms.Label();
            this.cbxNomBateau = new System.Windows.Forms.ComboBox();
            this.lblDateDepart = new System.Windows.Forms.Label();
            this.lblDateArrivee = new System.Windows.Forms.Label();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.dtpDepart = new System.Windows.Forms.DateTimePicker();
            this.dtpArrivee = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lblSecteur
            // 
            this.lblSecteur.AutoSize = true;
            this.lblSecteur.Location = new System.Drawing.Point(13, 13);
            this.lblSecteur.Name = "lblSecteur";
            this.lblSecteur.Size = new System.Drawing.Size(59, 16);
            this.lblSecteur.TabIndex = 0;
            this.lblSecteur.Text = "Secteur :";
            // 
            // lbxSecteur
            // 
            this.lbxSecteur.FormattingEnabled = true;
            this.lbxSecteur.ItemHeight = 16;
            this.lbxSecteur.Location = new System.Drawing.Point(16, 32);
            this.lbxSecteur.Name = "lbxSecteur";
            this.lbxSecteur.Size = new System.Drawing.Size(120, 196);
            this.lbxSecteur.TabIndex = 1;
            this.lbxSecteur.SelectedIndexChanged += new System.EventHandler(this.lbxSecteur_SelectedIndexChanged);
            // 
            // lblLiaison
            // 
            this.lblLiaison.AutoSize = true;
            this.lblLiaison.Location = new System.Drawing.Point(16, 246);
            this.lblLiaison.Name = "lblLiaison";
            this.lblLiaison.Size = new System.Drawing.Size(63, 16);
            this.lblLiaison.TabIndex = 2;
            this.lblLiaison.Text = "Lisaison :";
            // 
            // cbxLiaison
            // 
            this.cbxLiaison.FormattingEnabled = true;
            this.cbxLiaison.Location = new System.Drawing.Point(19, 266);
            this.cbxLiaison.Name = "cbxLiaison";
            this.cbxLiaison.Size = new System.Drawing.Size(169, 24);
            this.cbxLiaison.TabIndex = 3;
            // 
            // lblNomBateau
            // 
            this.lblNomBateau.AutoSize = true;
            this.lblNomBateau.Location = new System.Drawing.Point(153, 13);
            this.lblNomBateau.Name = "lblNomBateau";
            this.lblNomBateau.Size = new System.Drawing.Size(87, 16);
            this.lblNomBateau.TabIndex = 4;
            this.lblNomBateau.Text = "Nom bateau :";
            // 
            // cbxNomBateau
            // 
            this.cbxNomBateau.FormattingEnabled = true;
            this.cbxNomBateau.Location = new System.Drawing.Point(294, 13);
            this.cbxNomBateau.Name = "cbxNomBateau";
            this.cbxNomBateau.Size = new System.Drawing.Size(257, 24);
            this.cbxNomBateau.TabIndex = 5;
            // 
            // lblDateDepart
            // 
            this.lblDateDepart.AutoSize = true;
            this.lblDateDepart.Location = new System.Drawing.Point(153, 170);
            this.lblDateDepart.Name = "lblDateDepart";
            this.lblDateDepart.Size = new System.Drawing.Size(135, 16);
            this.lblDateDepart.TabIndex = 6;
            this.lblDateDepart.Text = "Date et heure départ :";
            // 
            // lblDateArrivee
            // 
            this.lblDateArrivee.AutoSize = true;
            this.lblDateArrivee.Location = new System.Drawing.Point(153, 208);
            this.lblDateArrivee.Name = "lblDateArrivee";
            this.lblDateArrivee.Size = new System.Drawing.Size(138, 16);
            this.lblDateArrivee.TabIndex = 7;
            this.lblDateArrivee.Text = "Date et heure arrivée :";
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(476, 267);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(75, 23);
            this.btnAjouter.TabIndex = 10;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // dtpDepart
            // 
            this.dtpDepart.Location = new System.Drawing.Point(295, 170);
            this.dtpDepart.Name = "dtpDepart";
            this.dtpDepart.Size = new System.Drawing.Size(256, 22);
            this.dtpDepart.TabIndex = 11;
            // 
            // dtpArrivee
            // 
            this.dtpArrivee.Location = new System.Drawing.Point(295, 208);
            this.dtpArrivee.Name = "dtpArrivee";
            this.dtpArrivee.Size = new System.Drawing.Size(256, 22);
            this.dtpArrivee.TabIndex = 12;
            // 
            // Ajouter_une_traversée
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 309);
            this.Controls.Add(this.dtpArrivee);
            this.Controls.Add(this.dtpDepart);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.lblDateArrivee);
            this.Controls.Add(this.lblDateDepart);
            this.Controls.Add(this.cbxNomBateau);
            this.Controls.Add(this.lblNomBateau);
            this.Controls.Add(this.cbxLiaison);
            this.Controls.Add(this.lblLiaison);
            this.Controls.Add(this.lbxSecteur);
            this.Controls.Add(this.lblSecteur);
            this.Name = "Ajouter_une_traversée";
            this.Text = "Ajouter une traversée";
            this.Load += new System.EventHandler(this.Ajouter_une_traversée_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSecteur;
        private System.Windows.Forms.ListBox lbxSecteur;
        private System.Windows.Forms.Label lblLiaison;
        private System.Windows.Forms.ComboBox cbxLiaison;
        private System.Windows.Forms.Label lblNomBateau;
        private System.Windows.Forms.ComboBox cbxNomBateau;
        private System.Windows.Forms.Label lblDateDepart;
        private System.Windows.Forms.Label lblDateArrivee;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.DateTimePicker dtpDepart;
        private System.Windows.Forms.DateTimePicker dtpArrivee;
    }
}