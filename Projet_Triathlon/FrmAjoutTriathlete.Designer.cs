namespace Projet_Triathlon
{
    partial class FrmAjoutTriathlete
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
            this.btAnnuler = new System.Windows.Forms.Button();
            this.btValider = new System.Windows.Forms.Button();
            this.txtCodePostal = new System.Windows.Forms.MaskedTextBox();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblTitre = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.lblCP = new System.Windows.Forms.Label();
            this.txtVille = new System.Windows.Forms.TextBox();
            this.lblVille = new System.Windows.Forms.Label();
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.lblAdresse = new System.Windows.Forms.Label();
            this.dateTimeNaissance = new System.Windows.Forms.DateTimePicker();
            this.lblDateNaissance = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btAnnuler
            // 
            this.btAnnuler.BackColor = System.Drawing.Color.OrangeRed;
            this.btAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAnnuler.Location = new System.Drawing.Point(399, 350);
            this.btAnnuler.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btAnnuler.Name = "btAnnuler";
            this.btAnnuler.Size = new System.Drawing.Size(107, 42);
            this.btAnnuler.TabIndex = 24;
            this.btAnnuler.Text = "Annuler";
            this.btAnnuler.UseVisualStyleBackColor = false;
            // 
            // btValider
            // 
            this.btValider.BackColor = System.Drawing.Color.LimeGreen;
            this.btValider.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btValider.Location = new System.Drawing.Point(189, 350);
            this.btValider.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btValider.Name = "btValider";
            this.btValider.Size = new System.Drawing.Size(107, 42);
            this.btValider.TabIndex = 23;
            this.btValider.Text = "Valider";
            this.btValider.UseVisualStyleBackColor = false;
            this.btValider.Click += new System.EventHandler(this.btValider_Click);
            // 
            // txtCodePostal
            // 
            this.txtCodePostal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodePostal.Location = new System.Drawing.Point(273, 174);
            this.txtCodePostal.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtCodePostal.Name = "txtCodePostal";
            this.txtCodePostal.Size = new System.Drawing.Size(66, 23);
            this.txtCodePostal.TabIndex = 22;
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrenom.Location = new System.Drawing.Point(163, 128);
            this.lblPrenom.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(65, 17);
            this.lblPrenom.TabIndex = 21;
            this.lblPrenom.Text = "Prénom :";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.Location = new System.Drawing.Point(163, 80);
            this.lblNom.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(45, 17);
            this.lblNom.TabIndex = 20;
            this.lblNom.Text = "Nom :";
            // 
            // lblTitre
            // 
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.Location = new System.Drawing.Point(33, 15);
            this.lblTitre.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(433, 39);
            this.lblTitre.TabIndex = 19;
            this.lblTitre.Text = "Saisir les informations du nouveau triathlète :";
            this.lblTitre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNom
            // 
            this.txtNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNom.Location = new System.Drawing.Point(237, 76);
            this.txtNom.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(184, 23);
            this.txtNom.TabIndex = 18;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrenom.Location = new System.Drawing.Point(237, 124);
            this.txtPrenom.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(184, 23);
            this.txtPrenom.TabIndex = 25;
            // 
            // lblCP
            // 
            this.lblCP.AutoSize = true;
            this.lblCP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCP.Location = new System.Drawing.Point(163, 177);
            this.lblCP.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCP.Name = "lblCP";
            this.lblCP.Size = new System.Drawing.Size(99, 17);
            this.lblCP.TabIndex = 26;
            this.lblCP.Text = "Code postale :";
            // 
            // txtVille
            // 
            this.txtVille.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVille.Location = new System.Drawing.Point(237, 214);
            this.txtVille.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtVille.Name = "txtVille";
            this.txtVille.Size = new System.Drawing.Size(151, 23);
            this.txtVille.TabIndex = 28;
            // 
            // lblVille
            // 
            this.lblVille.AutoSize = true;
            this.lblVille.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVille.Location = new System.Drawing.Point(163, 218);
            this.lblVille.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblVille.Name = "lblVille";
            this.lblVille.Size = new System.Drawing.Size(42, 17);
            this.lblVille.TabIndex = 27;
            this.lblVille.Text = "Ville :";
            // 
            // txtAdresse
            // 
            this.txtAdresse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdresse.Location = new System.Drawing.Point(237, 251);
            this.txtAdresse.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(215, 23);
            this.txtAdresse.TabIndex = 30;
            // 
            // lblAdresse
            // 
            this.lblAdresse.AutoSize = true;
            this.lblAdresse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdresse.Location = new System.Drawing.Point(163, 255);
            this.lblAdresse.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblAdresse.Name = "lblAdresse";
            this.lblAdresse.Size = new System.Drawing.Size(68, 17);
            this.lblAdresse.TabIndex = 29;
            this.lblAdresse.Text = "Adresse :";
            // 
            // dateTimeNaissance
            // 
            this.dateTimeNaissance.Location = new System.Drawing.Point(288, 304);
            this.dateTimeNaissance.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimeNaissance.Name = "dateTimeNaissance";
            this.dateTimeNaissance.Size = new System.Drawing.Size(265, 22);
            this.dateTimeNaissance.TabIndex = 31;
            // 
            // lblDateNaissance
            // 
            this.lblDateNaissance.AutoSize = true;
            this.lblDateNaissance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateNaissance.Location = new System.Drawing.Point(163, 304);
            this.lblDateNaissance.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDateNaissance.Name = "lblDateNaissance";
            this.lblDateNaissance.Size = new System.Drawing.Size(114, 17);
            this.lblDateNaissance.TabIndex = 32;
            this.lblDateNaissance.Text = "Date naissance :";
            // 
            // FrmAjoutTriathlete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 425);
            this.Controls.Add(this.lblDateNaissance);
            this.Controls.Add(this.dateTimeNaissance);
            this.Controls.Add(this.txtAdresse);
            this.Controls.Add(this.lblAdresse);
            this.Controls.Add(this.txtVille);
            this.Controls.Add(this.lblVille);
            this.Controls.Add(this.lblCP);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.btAnnuler);
            this.Controls.Add(this.btValider);
            this.Controls.Add(this.txtCodePostal);
            this.Controls.Add(this.lblPrenom);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.txtNom);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmAjoutTriathlete";
            this.Text = "Ajout d\'un nouveau triathlète";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btAnnuler;
        private System.Windows.Forms.Button btValider;
        private System.Windows.Forms.MaskedTextBox txtCodePostal;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.Label lblCP;
        private System.Windows.Forms.TextBox txtVille;
        private System.Windows.Forms.Label lblVille;
        private System.Windows.Forms.TextBox txtAdresse;
        private System.Windows.Forms.Label lblAdresse;
        private System.Windows.Forms.DateTimePicker dateTimeNaissance;
        private System.Windows.Forms.Label lblDateNaissance;
    }
}