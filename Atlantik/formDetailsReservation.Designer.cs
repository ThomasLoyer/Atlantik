namespace Atlantik
{
    partial class formDetailsReservation
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
            this.lblNomPrenom = new System.Windows.Forms.Label();
            this.cbxNomPrenom = new System.Windows.Forms.ComboBox();
            this.lvDetail = new System.Windows.Forms.ListView();
            this.gbxReservation = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // lblNomPrenom
            // 
            this.lblNomPrenom.AutoSize = true;
            this.lblNomPrenom.Location = new System.Drawing.Point(21, 33);
            this.lblNomPrenom.Name = "lblNomPrenom";
            this.lblNomPrenom.Size = new System.Drawing.Size(95, 16);
            this.lblNomPrenom.TabIndex = 0;
            this.lblNomPrenom.Text = "Nom, Prénom :";
            // 
            // cbxNomPrenom
            // 
            this.cbxNomPrenom.FormattingEnabled = true;
            this.cbxNomPrenom.Location = new System.Drawing.Point(123, 30);
            this.cbxNomPrenom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxNomPrenom.Name = "cbxNomPrenom";
            this.cbxNomPrenom.Size = new System.Drawing.Size(160, 24);
            this.cbxNomPrenom.TabIndex = 1;
            this.cbxNomPrenom.SelectedIndexChanged += new System.EventHandler(this.cbxNomPrenom_SelectedIndexChanged);
            // 
            // lvDetail
            // 
            this.lvDetail.FullRowSelect = true;
            this.lvDetail.HideSelection = false;
            this.lvDetail.Location = new System.Drawing.Point(308, 30);
            this.lvDetail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvDetail.Name = "lvDetail";
            this.lvDetail.Size = new System.Drawing.Size(544, 98);
            this.lvDetail.TabIndex = 2;
            this.lvDetail.UseCompatibleStateImageBehavior = false;
            this.lvDetail.View = System.Windows.Forms.View.Details;
            this.lvDetail.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvDetail_ItemSelectionChanged);
            // 
            // gbxReservation
            // 
            this.gbxReservation.Location = new System.Drawing.Point(444, 144);
            this.gbxReservation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxReservation.Name = "gbxReservation";
            this.gbxReservation.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxReservation.Size = new System.Drawing.Size(255, 246);
            this.gbxReservation.TabIndex = 3;
            this.gbxReservation.TabStop = false;
            this.gbxReservation.Text = "Réservation";
            // 
            // formDetailsReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 418);
            this.Controls.Add(this.gbxReservation);
            this.Controls.Add(this.lvDetail);
            this.Controls.Add(this.cbxNomPrenom);
            this.Controls.Add(this.lblNomPrenom);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "formDetailsReservation";
            this.Text = "Détail pour une réservation";
            this.Load += new System.EventHandler(this.formDetailsReservation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomPrenom;
        private System.Windows.Forms.ComboBox cbxNomPrenom;
        private System.Windows.Forms.ListView lvDetail;
        private System.Windows.Forms.GroupBox gbxReservation;
    }
}