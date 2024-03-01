namespace Atlantik
{
    partial class formAjouterPort
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
            this.btnAjouterPort = new System.Windows.Forms.Button();
            this.lblAjouterPort = new System.Windows.Forms.Label();
            this.tbxAjouterPort = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAjouterPort
            // 
            this.btnAjouterPort.Location = new System.Drawing.Point(173, 138);
            this.btnAjouterPort.Name = "btnAjouterPort";
            this.btnAjouterPort.Size = new System.Drawing.Size(75, 23);
            this.btnAjouterPort.TabIndex = 0;
            this.btnAjouterPort.Text = "Ajouter";
            this.btnAjouterPort.UseVisualStyleBackColor = true;
            this.btnAjouterPort.Click += new System.EventHandler(this.btnAjouterPort_Click);
            // 
            // lblAjouterPort
            // 
            this.lblAjouterPort.AutoSize = true;
            this.lblAjouterPort.Location = new System.Drawing.Point(35, 74);
            this.lblAjouterPort.Name = "lblAjouterPort";
            this.lblAjouterPort.Size = new System.Drawing.Size(82, 13);
            this.lblAjouterPort.TabIndex = 1;
            this.lblAjouterPort.Text = "Ajouter un port :";
            // 
            // tbxAjouterPort
            // 
            this.tbxAjouterPort.Location = new System.Drawing.Point(142, 74);
            this.tbxAjouterPort.Name = "tbxAjouterPort";
            this.tbxAjouterPort.Size = new System.Drawing.Size(150, 20);
            this.tbxAjouterPort.TabIndex = 2;
            // 
            // formAjouterPort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 252);
            this.Controls.Add(this.tbxAjouterPort);
            this.Controls.Add(this.lblAjouterPort);
            this.Controls.Add(this.btnAjouterPort);
            this.Name = "formAjouterPort";
            this.Text = "Ajouter un port";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAjouterPort;
        private System.Windows.Forms.Label lblAjouterPort;
        private System.Windows.Forms.TextBox tbxAjouterPort;
    }
}