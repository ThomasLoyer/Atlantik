namespace Atlantik
{
    partial class formModifierParamètresSite
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
            this.gbxIdentitfiants = new System.Windows.Forms.GroupBox();
            this.cbProduction = new System.Windows.Forms.CheckBox();
            this.tbxMelSite = new System.Windows.Forms.TextBox();
            this.lblMelSite = new System.Windows.Forms.Label();
            this.btnModifier = new System.Windows.Forms.Button();
            this.lblSite = new System.Windows.Forms.Label();
            this.lblRang = new System.Windows.Forms.Label();
            this.lblIdentifiant = new System.Windows.Forms.Label();
            this.lblCleHMAC = new System.Windows.Forms.Label();
            this.tbxCleHMAC = new System.Windows.Forms.TextBox();
            this.tbxIdentifiant = new System.Windows.Forms.TextBox();
            this.tbxRang = new System.Windows.Forms.TextBox();
            this.tbxSite = new System.Windows.Forms.TextBox();
            this.gbxIdentitfiants.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxIdentitfiants
            // 
            this.gbxIdentitfiants.Controls.Add(this.tbxSite);
            this.gbxIdentitfiants.Controls.Add(this.tbxRang);
            this.gbxIdentitfiants.Controls.Add(this.tbxIdentifiant);
            this.gbxIdentitfiants.Controls.Add(this.tbxCleHMAC);
            this.gbxIdentitfiants.Controls.Add(this.lblCleHMAC);
            this.gbxIdentitfiants.Controls.Add(this.lblIdentifiant);
            this.gbxIdentitfiants.Controls.Add(this.lblRang);
            this.gbxIdentitfiants.Controls.Add(this.lblSite);
            this.gbxIdentitfiants.Location = new System.Drawing.Point(12, 12);
            this.gbxIdentitfiants.Name = "gbxIdentitfiants";
            this.gbxIdentitfiants.Size = new System.Drawing.Size(302, 299);
            this.gbxIdentitfiants.TabIndex = 0;
            this.gbxIdentitfiants.TabStop = false;
            this.gbxIdentitfiants.Text = "Identifiants PayBox";
            // 
            // cbProduction
            // 
            this.cbProduction.AutoSize = true;
            this.cbProduction.Location = new System.Drawing.Point(187, 333);
            this.cbProduction.Name = "cbProduction";
            this.cbProduction.Size = new System.Drawing.Size(111, 20);
            this.cbProduction.TabIndex = 1;
            this.cbProduction.Text = "En production";
            this.cbProduction.UseVisualStyleBackColor = true;
            // 
            // tbxMelSite
            // 
            this.tbxMelSite.Location = new System.Drawing.Point(146, 359);
            this.tbxMelSite.Name = "tbxMelSite";
            this.tbxMelSite.Size = new System.Drawing.Size(152, 22);
            this.tbxMelSite.TabIndex = 2;
            // 
            // lblMelSite
            // 
            this.lblMelSite.AutoSize = true;
            this.lblMelSite.Location = new System.Drawing.Point(79, 359);
            this.lblMelSite.Name = "lblMelSite";
            this.lblMelSite.Size = new System.Drawing.Size(59, 16);
            this.lblMelSite.TabIndex = 3;
            this.lblMelSite.Text = "Mèl site :";
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(146, 387);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(152, 23);
            this.btnModifier.TabIndex = 4;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // lblSite
            // 
            this.lblSite.AutoSize = true;
            this.lblSite.Location = new System.Drawing.Point(6, 36);
            this.lblSite.Name = "lblSite";
            this.lblSite.Size = new System.Drawing.Size(36, 16);
            this.lblSite.TabIndex = 0;
            this.lblSite.Text = "Site :";
            // 
            // lblRang
            // 
            this.lblRang.AutoSize = true;
            this.lblRang.Location = new System.Drawing.Point(6, 64);
            this.lblRang.Name = "lblRang";
            this.lblRang.Size = new System.Drawing.Size(46, 16);
            this.lblRang.TabIndex = 1;
            this.lblRang.Text = "Rang :";
            // 
            // lblIdentifiant
            // 
            this.lblIdentifiant.AutoSize = true;
            this.lblIdentifiant.Location = new System.Drawing.Point(6, 92);
            this.lblIdentifiant.Name = "lblIdentifiant";
            this.lblIdentifiant.Size = new System.Drawing.Size(69, 16);
            this.lblIdentifiant.TabIndex = 2;
            this.lblIdentifiant.Text = "Identifiant :";
            // 
            // lblCleHMAC
            // 
            this.lblCleHMAC.AutoSize = true;
            this.lblCleHMAC.Location = new System.Drawing.Point(6, 120);
            this.lblCleHMAC.Name = "lblCleHMAC";
            this.lblCleHMAC.Size = new System.Drawing.Size(75, 16);
            this.lblCleHMAC.TabIndex = 3;
            this.lblCleHMAC.Text = "Clé HMAC :";
            // 
            // tbxCleHMAC
            // 
            this.tbxCleHMAC.Location = new System.Drawing.Point(102, 120);
            this.tbxCleHMAC.Multiline = true;
            this.tbxCleHMAC.Name = "tbxCleHMAC";
            this.tbxCleHMAC.Size = new System.Drawing.Size(178, 144);
            this.tbxCleHMAC.TabIndex = 4;
            // 
            // tbxIdentifiant
            // 
            this.tbxIdentifiant.Location = new System.Drawing.Point(102, 92);
            this.tbxIdentifiant.Name = "tbxIdentifiant";
            this.tbxIdentifiant.Size = new System.Drawing.Size(178, 22);
            this.tbxIdentifiant.TabIndex = 5;
            // 
            // tbxRang
            // 
            this.tbxRang.Location = new System.Drawing.Point(102, 64);
            this.tbxRang.Name = "tbxRang";
            this.tbxRang.Size = new System.Drawing.Size(178, 22);
            this.tbxRang.TabIndex = 6;
            // 
            // tbxSite
            // 
            this.tbxSite.Location = new System.Drawing.Point(102, 36);
            this.tbxSite.Name = "tbxSite";
            this.tbxSite.Size = new System.Drawing.Size(178, 22);
            this.tbxSite.TabIndex = 7;
            // 
            // formModifierParamètresSite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 422);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.lblMelSite);
            this.Controls.Add(this.tbxMelSite);
            this.Controls.Add(this.cbProduction);
            this.Controls.Add(this.gbxIdentitfiants);
            this.Name = "formModifierParamètresSite";
            this.Text = "Modifier les paramètres du site";
            this.gbxIdentitfiants.ResumeLayout(false);
            this.gbxIdentitfiants.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxIdentitfiants;
        private System.Windows.Forms.CheckBox cbProduction;
        private System.Windows.Forms.TextBox tbxMelSite;
        private System.Windows.Forms.Label lblMelSite;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.TextBox tbxSite;
        private System.Windows.Forms.TextBox tbxRang;
        private System.Windows.Forms.TextBox tbxIdentifiant;
        private System.Windows.Forms.TextBox tbxCleHMAC;
        private System.Windows.Forms.Label lblCleHMAC;
        private System.Windows.Forms.Label lblIdentifiant;
        private System.Windows.Forms.Label lblRang;
        private System.Windows.Forms.Label lblSite;
    }
}