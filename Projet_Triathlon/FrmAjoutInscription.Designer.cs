namespace Projet_Triathlon
{
    partial class FrmAjoutInscription
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
            System.Windows.Forms.Label lblNumLicence;
            System.Windows.Forms.Label lblNumTriath;
            this.btAnnuler = new System.Windows.Forms.Button();
            this.lblTitre = new System.Windows.Forms.Label();
            this.btValider = new System.Windows.Forms.Button();
            this.comboBxLesNumLicence = new System.Windows.Forms.ComboBox();
            this.comboBxLesNumTriath = new System.Windows.Forms.ComboBox();
            lblNumLicence = new System.Windows.Forms.Label();
            lblNumTriath = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNumLicence
            // 
            lblNumLicence.AutoSize = true;
            lblNumLicence.Location = new System.Drawing.Point(142, 194);
            lblNumLicence.Name = "lblNumLicence";
            lblNumLicence.Size = new System.Drawing.Size(88, 16);
            lblNumLicence.TabIndex = 30;
            lblNumLicence.Text = "Num Licence:";
            // 
            // lblNumTriath
            // 
            lblNumTriath.AutoSize = true;
            lblNumTriath.Location = new System.Drawing.Point(142, 114);
            lblNumTriath.Name = "lblNumTriath";
            lblNumTriath.Size = new System.Drawing.Size(75, 16);
            lblNumTriath.TabIndex = 32;
            lblNumTriath.Text = "Num Triath:";
            // 
            // btAnnuler
            // 
            this.btAnnuler.BackColor = System.Drawing.Color.OrangeRed;
            this.btAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAnnuler.Location = new System.Drawing.Point(357, 297);
            this.btAnnuler.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btAnnuler.Name = "btAnnuler";
            this.btAnnuler.Size = new System.Drawing.Size(107, 42);
            this.btAnnuler.TabIndex = 24;
            this.btAnnuler.Text = "Annuler";
            this.btAnnuler.UseVisualStyleBackColor = false;
            this.btAnnuler.Click += new System.EventHandler(this.btAnnuler_Click);
            // 
            // lblTitre
            // 
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.Location = new System.Drawing.Point(31, 11);
            this.lblTitre.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(433, 39);
            this.lblTitre.TabIndex = 19;
            this.lblTitre.Text = "Saisir les informations de la nouvelle inscription :";
            this.lblTitre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btValider
            // 
            this.btValider.BackColor = System.Drawing.Color.LimeGreen;
            this.btValider.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btValider.Location = new System.Drawing.Point(137, 297);
            this.btValider.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btValider.Name = "btValider";
            this.btValider.Size = new System.Drawing.Size(107, 42);
            this.btValider.TabIndex = 23;
            this.btValider.Text = "Valider";
            this.btValider.UseVisualStyleBackColor = false;
            this.btValider.Click += new System.EventHandler(this.btValider_Click);
            // 
            // comboBxLesNumLicence
            // 
            this.comboBxLesNumLicence.FormattingEnabled = true;
            this.comboBxLesNumLicence.Location = new System.Drawing.Point(259, 191);
            this.comboBxLesNumLicence.Name = "comboBxLesNumLicence";
            this.comboBxLesNumLicence.Size = new System.Drawing.Size(200, 24);
            this.comboBxLesNumLicence.TabIndex = 31;
            // 
            // comboBxLesNumTriath
            // 
            this.comboBxLesNumTriath.FormattingEnabled = true;
            this.comboBxLesNumTriath.Location = new System.Drawing.Point(259, 111);
            this.comboBxLesNumTriath.Name = "comboBxLesNumTriath";
            this.comboBxLesNumTriath.Size = new System.Drawing.Size(200, 24);
            this.comboBxLesNumTriath.TabIndex = 33;
            // 
            // FrmAjoutInscription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 397);
            this.Controls.Add(lblNumLicence);
            this.Controls.Add(this.comboBxLesNumLicence);
            this.Controls.Add(lblNumTriath);
            this.Controls.Add(this.comboBxLesNumTriath);
            this.Controls.Add(this.btAnnuler);
            this.Controls.Add(this.btValider);
            this.Controls.Add(this.lblTitre);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmAjoutInscription";
            this.Text = "Ajout d\'une nouvelle inscription";
            this.Load += new System.EventHandler(this.FrmAjoutInscription_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btAnnuler;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Button btValider;
        private System.Windows.Forms.ComboBox comboBxLesNumLicence;
        private System.Windows.Forms.ComboBox comboBxLesNumTriath;
    }
}