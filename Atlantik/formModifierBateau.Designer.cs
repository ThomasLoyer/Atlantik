namespace Atlantik
{
    partial class formModifierBateau
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
            this.lblNomBateau = new System.Windows.Forms.Label();
            this.cbxNomBateau = new System.Windows.Forms.ComboBox();
            this.btnModifier = new System.Windows.Forms.Button();
            this.gbxCapacite = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // lblNomBateau
            // 
            this.lblNomBateau.AutoSize = true;
            this.lblNomBateau.Location = new System.Drawing.Point(24, 37);
            this.lblNomBateau.Name = "lblNomBateau";
            this.lblNomBateau.Size = new System.Drawing.Size(88, 16);
            this.lblNomBateau.TabIndex = 0;
            this.lblNomBateau.Text = "Nom Bateau :";
            // 
            // cbxNomBateau
            // 
            this.cbxNomBateau.FormattingEnabled = true;
            this.cbxNomBateau.Location = new System.Drawing.Point(118, 37);
            this.cbxNomBateau.Name = "cbxNomBateau";
            this.cbxNomBateau.Size = new System.Drawing.Size(121, 24);
            this.cbxNomBateau.TabIndex = 1;
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(141, 161);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(75, 23);
            this.btnModifier.TabIndex = 2;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // gbxCapacite
            // 
            this.gbxCapacite.Location = new System.Drawing.Point(264, 26);
            this.gbxCapacite.Name = "gbxCapacite";
            this.gbxCapacite.Size = new System.Drawing.Size(335, 158);
            this.gbxCapacite.TabIndex = 3;
            this.gbxCapacite.TabStop = false;
            this.gbxCapacite.Text = "Capacité Maximales";
            // 
            // formModifierBateau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 221);
            this.Controls.Add(this.gbxCapacite);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.cbxNomBateau);
            this.Controls.Add(this.lblNomBateau);
            this.Name = "formModifierBateau";
            this.Text = "Modifier un bateau";
            this.Load += new System.EventHandler(this.formModifierBateau_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomBateau;
        private System.Windows.Forms.ComboBox cbxNomBateau;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.GroupBox gbxCapacite;
    }
}