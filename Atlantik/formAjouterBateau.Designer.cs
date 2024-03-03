namespace Atlantik
{
    partial class formAjouterBateau
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
            this.tbxNomBateau = new System.Windows.Forms.TextBox();
            this.btnAjouterBateau = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNomBateau
            // 
            this.lblNomBateau.AutoSize = true;
            this.lblNomBateau.Location = new System.Drawing.Point(23, 48);
            this.lblNomBateau.Name = "lblNomBateau";
            this.lblNomBateau.Size = new System.Drawing.Size(87, 16);
            this.lblNomBateau.TabIndex = 0;
            this.lblNomBateau.Text = "Nom bateau :";
            // 
            // tbxNomBateau
            // 
            this.tbxNomBateau.Location = new System.Drawing.Point(116, 48);
            this.tbxNomBateau.Name = "tbxNomBateau";
            this.tbxNomBateau.Size = new System.Drawing.Size(100, 22);
            this.tbxNomBateau.TabIndex = 1;
            // 
            // btnAjouterBateau
            // 
            this.btnAjouterBateau.Location = new System.Drawing.Point(141, 154);
            this.btnAjouterBateau.Name = "btnAjouterBateau";
            this.btnAjouterBateau.Size = new System.Drawing.Size(75, 23);
            this.btnAjouterBateau.TabIndex = 2;
            this.btnAjouterBateau.Text = "Ajouter";
            this.btnAjouterBateau.UseVisualStyleBackColor = true;
            this.btnAjouterBateau.Click += new System.EventHandler(this.btnAjouterBateau_Click);
            // 
            // formAjouterBateau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 223);
            this.Controls.Add(this.btnAjouterBateau);
            this.Controls.Add(this.tbxNomBateau);
            this.Controls.Add(this.lblNomBateau);
            this.Name = "formAjouterBateau";
            this.Text = "formAjouterBateau";
            this.Load += new System.EventHandler(this.formAjouterBateau_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomBateau;
        private System.Windows.Forms.TextBox tbxNomBateau;
        private System.Windows.Forms.Button btnAjouterBateau;
    }
}