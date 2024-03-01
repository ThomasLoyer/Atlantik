namespace Atlantik
{
    partial class formAjoutLiaison
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbxSecteur = new System.Windows.Forms.ListBox();
            this.secteurBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lbSecteurs = new System.Windows.Forms.Label();
            this.cbxDepart = new System.Windows.Forms.ComboBox();
            this.lbDepart = new System.Windows.Forms.Label();
            this.cbxArrivee = new System.Windows.Forms.ComboBox();
            this.lbArrivee = new System.Windows.Forms.Label();
            this.tbxDistance = new System.Windows.Forms.TextBox();
            this.lbDistance = new System.Windows.Forms.Label();
            this.btnAjouter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.secteurBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbxSecteur
            // 
            this.lbxSecteur.FormattingEnabled = true;
            this.lbxSecteur.Location = new System.Drawing.Point(26, 40);
            this.lbxSecteur.Margin = new System.Windows.Forms.Padding(2);
            this.lbxSecteur.Name = "lbxSecteur";
            this.lbxSecteur.Size = new System.Drawing.Size(91, 186);
            this.lbxSecteur.TabIndex = 0;
            // 
            // secteurBindingSource
            // 
            this.secteurBindingSource.DataSource = typeof(Atlantik.Secteur);
            // 
            // lbSecteurs
            // 
            this.lbSecteurs.AutoSize = true;
            this.lbSecteurs.Location = new System.Drawing.Point(26, 22);
            this.lbSecteurs.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSecteurs.Name = "lbSecteurs";
            this.lbSecteurs.Size = new System.Drawing.Size(55, 13);
            this.lbSecteurs.TabIndex = 1;
            this.lbSecteurs.Text = "Secteurs :";
            // 
            // cbxDepart
            // 
            this.cbxDepart.FormattingEnabled = true;
            this.cbxDepart.Location = new System.Drawing.Point(165, 37);
            this.cbxDepart.Margin = new System.Windows.Forms.Padding(2);
            this.cbxDepart.Name = "cbxDepart";
            this.cbxDepart.Size = new System.Drawing.Size(92, 21);
            this.cbxDepart.TabIndex = 2;
            this.cbxDepart.Text = "Port";
            // 
            // lbDepart
            // 
            this.lbDepart.AutoSize = true;
            this.lbDepart.Location = new System.Drawing.Point(120, 40);
            this.lbDepart.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDepart.Name = "lbDepart";
            this.lbDepart.Size = new System.Drawing.Size(45, 13);
            this.lbDepart.TabIndex = 3;
            this.lbDepart.Text = "Départ :";
            // 
            // cbxArrivee
            // 
            this.cbxArrivee.FormattingEnabled = true;
            this.cbxArrivee.Location = new System.Drawing.Point(307, 37);
            this.cbxArrivee.Margin = new System.Windows.Forms.Padding(2);
            this.cbxArrivee.Name = "cbxArrivee";
            this.cbxArrivee.Size = new System.Drawing.Size(92, 21);
            this.cbxArrivee.TabIndex = 4;
            this.cbxArrivee.Text = "Port";
            // 
            // lbArrivee
            // 
            this.lbArrivee.AutoSize = true;
            this.lbArrivee.Location = new System.Drawing.Point(260, 40);
            this.lbArrivee.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbArrivee.Name = "lbArrivee";
            this.lbArrivee.Size = new System.Drawing.Size(46, 13);
            this.lbArrivee.TabIndex = 5;
            this.lbArrivee.Text = "Arrivée :";
            // 
            // tbxDistance
            // 
            this.tbxDistance.Location = new System.Drawing.Point(322, 199);
            this.tbxDistance.Margin = new System.Windows.Forms.Padding(2);
            this.tbxDistance.Name = "tbxDistance";
            this.tbxDistance.Size = new System.Drawing.Size(76, 20);
            this.tbxDistance.TabIndex = 6;
            // 
            // lbDistance
            // 
            this.lbDistance.AutoSize = true;
            this.lbDistance.Location = new System.Drawing.Point(260, 199);
            this.lbDistance.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDistance.Name = "lbDistance";
            this.lbDistance.Size = new System.Drawing.Size(55, 13);
            this.lbDistance.TabIndex = 7;
            this.lbDistance.Text = "Distance :";
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(332, 229);
            this.btnAjouter.Margin = new System.Windows.Forms.Padding(2);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(56, 19);
            this.btnAjouter.TabIndex = 8;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // formAjoutLiaison
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 258);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.lbDistance);
            this.Controls.Add(this.tbxDistance);
            this.Controls.Add(this.lbArrivee);
            this.Controls.Add(this.cbxArrivee);
            this.Controls.Add(this.lbDepart);
            this.Controls.Add(this.cbxDepart);
            this.Controls.Add(this.lbSecteurs);
            this.Controls.Add(this.lbxSecteur);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "formAjoutLiaison";
            this.Text = "Ajouter une liaison";
            this.Load += new System.EventHandler(this.écranAjoutLiaison_Load);
            ((System.ComponentModel.ISupportInitialize)(this.secteurBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxSecteur;
        private System.Windows.Forms.Label lbSecteurs;
        private System.Windows.Forms.ComboBox cbxDepart;
        private System.Windows.Forms.Label lbDepart;
        private System.Windows.Forms.ComboBox cbxArrivee;
        private System.Windows.Forms.Label lbArrivee;
        private System.Windows.Forms.TextBox tbxDistance;
        private System.Windows.Forms.Label lbDistance;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.BindingSource secteurBindingSource;
    }
}

