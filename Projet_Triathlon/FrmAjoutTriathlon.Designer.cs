namespace Projet_Triathlon
{
    partial class FrmAjoutTriathlon
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
            this.lblDateCompet = new System.Windows.Forms.Label();
            this.dateTimeCompet = new System.Windows.Forms.DateTimePicker();
            this.txtLieu = new System.Windows.Forms.TextBox();
            this.btAnnuler = new System.Windows.Forms.Button();
            this.btValider = new System.Windows.Forms.Button();
            this.lblLieu = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblTitre = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.comboBxLesTypesTriath = new System.Windows.Forms.ComboBox();
            this.lblTypeTriath = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDateCompet
            // 
            this.lblDateCompet.AutoSize = true;
            this.lblDateCompet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateCompet.Location = new System.Drawing.Point(147, 190);
            this.lblDateCompet.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDateCompet.Name = "lblDateCompet";
            this.lblDateCompet.Size = new System.Drawing.Size(122, 17);
            this.lblDateCompet.TabIndex = 47;
            this.lblDateCompet.Text = "Date compétition :";
            // 
            // dateTimeCompet
            // 
            this.dateTimeCompet.Location = new System.Drawing.Point(280, 190);
            this.dateTimeCompet.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimeCompet.Name = "dateTimeCompet";
            this.dateTimeCompet.Size = new System.Drawing.Size(265, 22);
            this.dateTimeCompet.TabIndex = 46;
            // 
            // txtLieu
            // 
            this.txtLieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLieu.Location = new System.Drawing.Point(221, 133);
            this.txtLieu.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtLieu.Name = "txtLieu";
            this.txtLieu.Size = new System.Drawing.Size(131, 23);
            this.txtLieu.TabIndex = 40;
            // 
            // btAnnuler
            // 
            this.btAnnuler.BackColor = System.Drawing.Color.OrangeRed;
            this.btAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAnnuler.Location = new System.Drawing.Point(383, 325);
            this.btAnnuler.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btAnnuler.Name = "btAnnuler";
            this.btAnnuler.Size = new System.Drawing.Size(107, 42);
            this.btAnnuler.TabIndex = 39;
            this.btAnnuler.Text = "Annuler";
            this.btAnnuler.UseVisualStyleBackColor = false;
            this.btAnnuler.Click += new System.EventHandler(this.btAnnuler_Click);
            // 
            // btValider
            // 
            this.btValider.BackColor = System.Drawing.Color.LimeGreen;
            this.btValider.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btValider.Location = new System.Drawing.Point(173, 325);
            this.btValider.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btValider.Name = "btValider";
            this.btValider.Size = new System.Drawing.Size(107, 42);
            this.btValider.TabIndex = 38;
            this.btValider.Text = "Valider";
            this.btValider.UseVisualStyleBackColor = false;
            this.btValider.Click += new System.EventHandler(this.btValider_Click);
            // 
            // lblLieu
            // 
            this.lblLieu.AutoSize = true;
            this.lblLieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLieu.Location = new System.Drawing.Point(147, 137);
            this.lblLieu.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblLieu.Name = "lblLieu";
            this.lblLieu.Size = new System.Drawing.Size(43, 17);
            this.lblLieu.TabIndex = 36;
            this.lblLieu.Text = "Lieu :";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.Location = new System.Drawing.Point(147, 89);
            this.lblNom.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(45, 17);
            this.lblNom.TabIndex = 35;
            this.lblNom.Text = "Nom :";
            // 
            // lblTitre
            // 
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.Location = new System.Drawing.Point(17, 23);
            this.lblTitre.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(433, 39);
            this.lblTitre.TabIndex = 34;
            this.lblTitre.Text = "Saisir les informations du nouveau triathlon :";
            this.lblTitre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNom
            // 
            this.txtNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNom.Location = new System.Drawing.Point(221, 85);
            this.txtNom.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(169, 23);
            this.txtNom.TabIndex = 33;
            // 
            // comboBxLesTypesTriath
            // 
            this.comboBxLesTypesTriath.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBxLesTypesTriath.FormattingEnabled = true;
            this.comboBxLesTypesTriath.Location = new System.Drawing.Point(263, 250);
            this.comboBxLesTypesTriath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBxLesTypesTriath.Name = "comboBxLesTypesTriath";
            this.comboBxLesTypesTriath.Size = new System.Drawing.Size(267, 24);
            this.comboBxLesTypesTriath.TabIndex = 48;
            // 
            // lblTypeTriath
            // 
            this.lblTypeTriath.AutoSize = true;
            this.lblTypeTriath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypeTriath.Location = new System.Drawing.Point(149, 254);
            this.lblTypeTriath.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTypeTriath.Name = "lblTypeTriath";
            this.lblTypeTriath.Size = new System.Drawing.Size(103, 17);
            this.lblTypeTriath.TabIndex = 49;
            this.lblTypeTriath.Text = "Type triathlon :";
            // 
            // FrmAjoutTriathlon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.lblTypeTriath);
            this.Controls.Add(this.comboBxLesTypesTriath);
            this.Controls.Add(this.lblDateCompet);
            this.Controls.Add(this.dateTimeCompet);
            this.Controls.Add(this.txtLieu);
            this.Controls.Add(this.btAnnuler);
            this.Controls.Add(this.btValider);
            this.Controls.Add(this.lblLieu);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.txtNom);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmAjoutTriathlon";
            this.Text = "Ajout d\'un nouveau triathlon";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDateCompet;
        private System.Windows.Forms.DateTimePicker dateTimeCompet;
        private System.Windows.Forms.TextBox txtLieu;
        private System.Windows.Forms.Button btAnnuler;
        private System.Windows.Forms.Button btValider;
        private System.Windows.Forms.Label lblLieu;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.ComboBox comboBxLesTypesTriath;
        private System.Windows.Forms.Label lblTypeTriath;
    }
}