namespace Atlantik
{
    partial class formAjouterTarif
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
            this.lbxSecteurs = new System.Windows.Forms.ListBox();
            this.lblSecteurs = new System.Windows.Forms.Label();
            this.lblLiaison = new System.Windows.Forms.Label();
            this.cbxLiaison = new System.Windows.Forms.ComboBox();
            this.lblPeriode = new System.Windows.Forms.Label();
            this.cbxPeriode = new System.Windows.Forms.ComboBox();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbxSecteurs
            // 
            this.lbxSecteurs.FormattingEnabled = true;
            this.lbxSecteurs.Location = new System.Drawing.Point(25, 46);
            this.lbxSecteurs.Name = "lbxSecteurs";
            this.lbxSecteurs.Size = new System.Drawing.Size(120, 225);
            this.lbxSecteurs.TabIndex = 0;
            this.lbxSecteurs.SelectedIndexChanged += new System.EventHandler(this.lbxSecteurs_SelectedIndexChanged);
            // 
            // lblSecteurs
            // 
            this.lblSecteurs.AutoSize = true;
            this.lblSecteurs.Location = new System.Drawing.Point(22, 30);
            this.lblSecteurs.Name = "lblSecteurs";
            this.lblSecteurs.Size = new System.Drawing.Size(55, 13);
            this.lblSecteurs.TabIndex = 1;
            this.lblSecteurs.Text = "Secteurs :";
            // 
            // lblLiaison
            // 
            this.lblLiaison.AutoSize = true;
            this.lblLiaison.Location = new System.Drawing.Point(25, 283);
            this.lblLiaison.Name = "lblLiaison";
            this.lblLiaison.Size = new System.Drawing.Size(46, 13);
            this.lblLiaison.TabIndex = 2;
            this.lblLiaison.Text = "Liaison :";
            // 
            // cbxLiaison
            // 
            this.cbxLiaison.FormattingEnabled = true;
            this.cbxLiaison.Location = new System.Drawing.Point(25, 299);
            this.cbxLiaison.Name = "cbxLiaison";
            this.cbxLiaison.Size = new System.Drawing.Size(121, 21);
            this.cbxLiaison.TabIndex = 3;
            // 
            // lblPeriode
            // 
            this.lblPeriode.AutoSize = true;
            this.lblPeriode.Location = new System.Drawing.Point(22, 349);
            this.lblPeriode.Name = "lblPeriode";
            this.lblPeriode.Size = new System.Drawing.Size(49, 13);
            this.lblPeriode.TabIndex = 4;
            this.lblPeriode.Text = "Période :";
            // 
            // cbxPeriode
            // 
            this.cbxPeriode.FormattingEnabled = true;
            this.cbxPeriode.Location = new System.Drawing.Point(92, 349);
            this.cbxPeriode.Name = "cbxPeriode";
            this.cbxPeriode.Size = new System.Drawing.Size(240, 21);
            this.cbxPeriode.TabIndex = 5;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(351, 349);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(75, 23);
            this.btnAjouter.TabIndex = 6;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // formAjouterTarif
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 396);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.cbxPeriode);
            this.Controls.Add(this.lblPeriode);
            this.Controls.Add(this.cbxLiaison);
            this.Controls.Add(this.lblLiaison);
            this.Controls.Add(this.lblSecteurs);
            this.Controls.Add(this.lbxSecteurs);
            this.Name = "formAjouterTarif";
            this.Text = "Ajouter les tarifs";
            this.Load += new System.EventHandler(this.formAjouterTarif_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxSecteurs;
        private System.Windows.Forms.Label lblSecteurs;
        private System.Windows.Forms.Label lblLiaison;
        private System.Windows.Forms.ComboBox cbxLiaison;
        private System.Windows.Forms.Label lblPeriode;
        private System.Windows.Forms.ComboBox cbxPeriode;
        private System.Windows.Forms.Button btnAjouter;
    }
}