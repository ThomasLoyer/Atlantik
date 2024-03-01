namespace Atlantik
{
    partial class formAjouterSecteur
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
            this.tbxAjoutSecteur = new System.Windows.Forms.TextBox();
            this.lblAjouterSecteur = new System.Windows.Forms.Label();
            this.btnAjouterSecteur = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxAjoutSecteur
            // 
            this.tbxAjoutSecteur.Location = new System.Drawing.Point(131, 64);
            this.tbxAjoutSecteur.Name = "tbxAjoutSecteur";
            this.tbxAjoutSecteur.Size = new System.Drawing.Size(154, 20);
            this.tbxAjoutSecteur.TabIndex = 0;
            // 
            // lblAjouterSecteur
            // 
            this.lblAjouterSecteur.AutoSize = true;
            this.lblAjouterSecteur.Location = new System.Drawing.Point(35, 64);
            this.lblAjouterSecteur.Name = "lblAjouterSecteur";
            this.lblAjouterSecteur.Size = new System.Drawing.Size(73, 13);
            this.lblAjouterSecteur.TabIndex = 1;
            this.lblAjouterSecteur.Text = "Nom secteur :";
            // 
            // btnAjouterSecteur
            // 
            this.btnAjouterSecteur.Location = new System.Drawing.Point(164, 150);
            this.btnAjouterSecteur.Name = "btnAjouterSecteur";
            this.btnAjouterSecteur.Size = new System.Drawing.Size(75, 23);
            this.btnAjouterSecteur.TabIndex = 2;
            this.btnAjouterSecteur.Text = "Ajouter";
            this.btnAjouterSecteur.UseVisualStyleBackColor = true;
            this.btnAjouterSecteur.Click += new System.EventHandler(this.btnAjouterSecteur_Click);
            // 
            // formAjouterSecteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 251);
            this.Controls.Add(this.btnAjouterSecteur);
            this.Controls.Add(this.lblAjouterSecteur);
            this.Controls.Add(this.tbxAjoutSecteur);
            this.Name = "formAjouterSecteur";
            this.Text = "Ajouter un secteur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxAjoutSecteur;
        private System.Windows.Forms.Label lblAjouterSecteur;
        private System.Windows.Forms.Button btnAjouterSecteur;
    }
}