namespace Atlantik
{
    partial class formAfficherTraversee
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
            this.lbxSecteur = new System.Windows.Forms.ListBox();
            this.lblSecteur = new System.Windows.Forms.Label();
            this.lblLiaison = new System.Windows.Forms.Label();
            this.cbxLiaison = new System.Windows.Forms.ComboBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.btnAfficher = new System.Windows.Forms.Button();
            this.lsvTraversee = new System.Windows.Forms.ListView();
            this.lblTraversee = new System.Windows.Forms.Label();
            this.lblPlaces = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbxSecteur
            // 
            this.lbxSecteur.FormattingEnabled = true;
            this.lbxSecteur.ItemHeight = 16;
            this.lbxSecteur.Location = new System.Drawing.Point(12, 32);
            this.lbxSecteur.Name = "lbxSecteur";
            this.lbxSecteur.Size = new System.Drawing.Size(120, 292);
            this.lbxSecteur.TabIndex = 0;
            this.lbxSecteur.SelectedIndexChanged += new System.EventHandler(this.lbxSecteur_SelectedIndexChanged);
            // 
            // lblSecteur
            // 
            this.lblSecteur.AutoSize = true;
            this.lblSecteur.Location = new System.Drawing.Point(13, 13);
            this.lblSecteur.Name = "lblSecteur";
            this.lblSecteur.Size = new System.Drawing.Size(66, 16);
            this.lblSecteur.TabIndex = 1;
            this.lblSecteur.Text = "Secteurs :";
            // 
            // lblLiaison
            // 
            this.lblLiaison.AutoSize = true;
            this.lblLiaison.Location = new System.Drawing.Point(12, 342);
            this.lblLiaison.Name = "lblLiaison";
            this.lblLiaison.Size = new System.Drawing.Size(56, 16);
            this.lblLiaison.TabIndex = 2;
            this.lblLiaison.Text = "Liaison :";
            // 
            // cbxLiaison
            // 
            this.cbxLiaison.FormattingEnabled = true;
            this.cbxLiaison.Location = new System.Drawing.Point(12, 362);
            this.cbxLiaison.Name = "cbxLiaison";
            this.cbxLiaison.Size = new System.Drawing.Size(135, 24);
            this.cbxLiaison.TabIndex = 3;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(170, 32);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(199, 16);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "Date ( par défaut date du jours ) :";
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "yyyy/MM/dd";
            this.dtpDate.Location = new System.Drawing.Point(394, 32);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(235, 22);
            this.dtpDate.TabIndex = 5;
            // 
            // btnAfficher
            // 
            this.btnAfficher.Location = new System.Drawing.Point(284, 74);
            this.btnAfficher.Name = "btnAfficher";
            this.btnAfficher.Size = new System.Drawing.Size(188, 23);
            this.btnAfficher.TabIndex = 6;
            this.btnAfficher.Text = "Afficher les traversées";
            this.btnAfficher.UseVisualStyleBackColor = true;
            this.btnAfficher.Click += new System.EventHandler(this.btnAfficher_Click);
            // 
            // lsvTraversee
            // 
            this.lsvTraversee.HideSelection = false;
            this.lsvTraversee.Location = new System.Drawing.Point(153, 135);
            this.lsvTraversee.Name = "lsvTraversee";
            this.lsvTraversee.Size = new System.Drawing.Size(476, 251);
            this.lsvTraversee.TabIndex = 7;
            this.lsvTraversee.UseCompatibleStateImageBehavior = false;
            this.lsvTraversee.View = System.Windows.Forms.View.Details;
            // 
            // lblTraversee
            // 
            this.lblTraversee.AutoSize = true;
            this.lblTraversee.Location = new System.Drawing.Point(153, 113);
            this.lblTraversee.Name = "lblTraversee";
            this.lblTraversee.Size = new System.Drawing.Size(70, 16);
            this.lblTraversee.TabIndex = 8;
            this.lblTraversee.Text = "Traversée";
            // 
            // lblPlaces
            // 
            this.lblPlaces.AutoSize = true;
            this.lblPlaces.Location = new System.Drawing.Point(337, 113);
            this.lblPlaces.Name = "lblPlaces";
            this.lblPlaces.Size = new System.Drawing.Size(205, 16);
            this.lblPlaces.TabIndex = 9;
            this.lblPlaces.Text = "Places disponibles par catégorie";
            // 
            // formAfficherTraversee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 410);
            this.Controls.Add(this.lblPlaces);
            this.Controls.Add(this.lblTraversee);
            this.Controls.Add(this.lsvTraversee);
            this.Controls.Add(this.btnAfficher);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.cbxLiaison);
            this.Controls.Add(this.lblLiaison);
            this.Controls.Add(this.lblSecteur);
            this.Controls.Add(this.lbxSecteur);
            this.Name = "formAfficherTraversee";
            this.Text = "Afficher les traversées pour une liaison et une date donnée avec places par catég" +
    "orie";
            this.Load += new System.EventHandler(this.formAfficherTraversee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxSecteur;
        private System.Windows.Forms.Label lblSecteur;
        private System.Windows.Forms.Label lblLiaison;
        private System.Windows.Forms.ComboBox cbxLiaison;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Button btnAfficher;
        private System.Windows.Forms.ListView lsvTraversee;
        private System.Windows.Forms.Label lblTraversee;
        private System.Windows.Forms.Label lblPlaces;
    }
}