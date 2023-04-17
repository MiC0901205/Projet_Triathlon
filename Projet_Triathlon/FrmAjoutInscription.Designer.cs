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
            this.btAnnuler = new System.Windows.Forms.Button();
            this.btValider = new System.Windows.Forms.Button();
            this.lblTempsNat = new System.Windows.Forms.Label();
            this.lblTriathlon = new System.Windows.Forms.Label();
            this.lblTitre = new System.Windows.Forms.Label();
            this.txtTempsNat = new System.Windows.Forms.TextBox();
            this.txtTempsCyclisme = new System.Windows.Forms.TextBox();
            this.lblTempsCyclisme = new System.Windows.Forms.Label();
            this.txtTempsCourse = new System.Windows.Forms.TextBox();
            this.lblTempsCourse = new System.Windows.Forms.Label();
            this.comboBxLesTriathlons = new System.Windows.Forms.ComboBox();
            this.comboBxLesTriathlètes = new System.Windows.Forms.ComboBox();
            this.lblTriathlete = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btAnnuler
            // 
            this.btAnnuler.BackColor = System.Drawing.Color.OrangeRed;
            this.btAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAnnuler.Location = new System.Drawing.Point(268, 241);
            this.btAnnuler.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btAnnuler.Name = "btAnnuler";
            this.btAnnuler.Size = new System.Drawing.Size(80, 34);
            this.btAnnuler.TabIndex = 24;
            this.btAnnuler.Text = "Annuler";
            this.btAnnuler.UseVisualStyleBackColor = false;
            // 
            // btValider
            // 
            this.btValider.BackColor = System.Drawing.Color.LimeGreen;
            this.btValider.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btValider.Location = new System.Drawing.Point(103, 241);
            this.btValider.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btValider.Name = "btValider";
            this.btValider.Size = new System.Drawing.Size(80, 34);
            this.btValider.TabIndex = 23;
            this.btValider.Text = "Valider";
            this.btValider.UseVisualStyleBackColor = false;
            // 
            // lblTempsNat
            // 
            this.lblTempsNat.AutoSize = true;
            this.lblTempsNat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempsNat.Location = new System.Drawing.Point(120, 103);
            this.lblTempsNat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTempsNat.Name = "lblTempsNat";
            this.lblTempsNat.Size = new System.Drawing.Size(88, 13);
            this.lblTempsNat.TabIndex = 21;
            this.lblTempsNat.Text = "Temps Natation :";
            // 
            // lblTriathlon
            // 
            this.lblTriathlon.AutoSize = true;
            this.lblTriathlon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTriathlon.Location = new System.Drawing.Point(120, 62);
            this.lblTriathlon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTriathlon.Name = "lblTriathlon";
            this.lblTriathlon.Size = new System.Drawing.Size(54, 13);
            this.lblTriathlon.TabIndex = 20;
            this.lblTriathlon.Text = "Triathlon :";
            // 
            // lblTitre
            // 
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.Location = new System.Drawing.Point(23, 9);
            this.lblTitre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(325, 32);
            this.lblTitre.TabIndex = 19;
            this.lblTitre.Text = "Saisir les informations de la nouvelle inscription :";
            this.lblTitre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTempsNat
            // 
            this.txtTempsNat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTempsNat.Location = new System.Drawing.Point(216, 100);
            this.txtTempsNat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTempsNat.Name = "txtTempsNat";
            this.txtTempsNat.Size = new System.Drawing.Size(61, 20);
            this.txtTempsNat.TabIndex = 25;
            // 
            // txtTempsCyclisme
            // 
            this.txtTempsCyclisme.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTempsCyclisme.Location = new System.Drawing.Point(216, 170);
            this.txtTempsCyclisme.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTempsCyclisme.Name = "txtTempsCyclisme";
            this.txtTempsCyclisme.Size = new System.Drawing.Size(61, 20);
            this.txtTempsCyclisme.TabIndex = 27;
            // 
            // lblTempsCyclisme
            // 
            this.lblTempsCyclisme.AutoSize = true;
            this.lblTempsCyclisme.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempsCyclisme.Location = new System.Drawing.Point(120, 173);
            this.lblTempsCyclisme.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTempsCyclisme.Name = "lblTempsCyclisme";
            this.lblTempsCyclisme.Size = new System.Drawing.Size(89, 13);
            this.lblTempsCyclisme.TabIndex = 26;
            this.lblTempsCyclisme.Text = "Temps Cyclisme :";
            // 
            // txtTempsCourse
            // 
            this.txtTempsCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTempsCourse.Location = new System.Drawing.Point(216, 135);
            this.txtTempsCourse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTempsCourse.Name = "txtTempsCourse";
            this.txtTempsCourse.Size = new System.Drawing.Size(61, 20);
            this.txtTempsCourse.TabIndex = 29;
            // 
            // lblTempsCourse
            // 
            this.lblTempsCourse.AutoSize = true;
            this.lblTempsCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempsCourse.Location = new System.Drawing.Point(120, 138);
            this.lblTempsCourse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTempsCourse.Name = "lblTempsCourse";
            this.lblTempsCourse.Size = new System.Drawing.Size(81, 13);
            this.lblTempsCourse.TabIndex = 28;
            this.lblTempsCourse.Text = "Temps Course :";
            // 
            // comboBxLesTriathlons
            // 
            this.comboBxLesTriathlons.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBxLesTriathlons.FormattingEnabled = true;
            this.comboBxLesTriathlons.Location = new System.Drawing.Point(180, 59);
            this.comboBxLesTriathlons.Margin = new System.Windows.Forms.Padding(2);
            this.comboBxLesTriathlons.Name = "comboBxLesTriathlons";
            this.comboBxLesTriathlons.Size = new System.Drawing.Size(178, 21);
            this.comboBxLesTriathlons.TabIndex = 49;
            // 
            // comboBxLesTriathlètes
            // 
            this.comboBxLesTriathlètes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBxLesTriathlètes.FormattingEnabled = true;
            this.comboBxLesTriathlètes.Location = new System.Drawing.Point(189, 205);
            this.comboBxLesTriathlètes.Margin = new System.Windows.Forms.Padding(2);
            this.comboBxLesTriathlètes.Name = "comboBxLesTriathlètes";
            this.comboBxLesTriathlètes.Size = new System.Drawing.Size(178, 21);
            this.comboBxLesTriathlètes.TabIndex = 51;
            // 
            // lblTriathlete
            // 
            this.lblTriathlete.AutoSize = true;
            this.lblTriathlete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTriathlete.Location = new System.Drawing.Point(120, 208);
            this.lblTriathlete.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTriathlete.Name = "lblTriathlete";
            this.lblTriathlete.Size = new System.Drawing.Size(62, 13);
            this.lblTriathlete.TabIndex = 50;
            this.lblTriathlete.Text = "Triathlètes :";
            // 
            // FrmAjoutInscription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 293);
            this.Controls.Add(this.comboBxLesTriathlètes);
            this.Controls.Add(this.lblTriathlete);
            this.Controls.Add(this.comboBxLesTriathlons);
            this.Controls.Add(this.txtTempsCourse);
            this.Controls.Add(this.lblTempsCourse);
            this.Controls.Add(this.txtTempsCyclisme);
            this.Controls.Add(this.lblTempsCyclisme);
            this.Controls.Add(this.txtTempsNat);
            this.Controls.Add(this.btAnnuler);
            this.Controls.Add(this.btValider);
            this.Controls.Add(this.lblTempsNat);
            this.Controls.Add(this.lblTriathlon);
            this.Controls.Add(this.lblTitre);
            this.Name = "FrmAjoutInscription";
            this.Text = "Ajout d\'une nouvelle inscription";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btAnnuler;
        private System.Windows.Forms.Button btValider;
        private System.Windows.Forms.Label lblTempsNat;
        private System.Windows.Forms.Label lblTriathlon;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.TextBox txtTempsNat;
        private System.Windows.Forms.TextBox txtTempsCyclisme;
        private System.Windows.Forms.Label lblTempsCyclisme;
        private System.Windows.Forms.TextBox txtTempsCourse;
        private System.Windows.Forms.Label lblTempsCourse;
        private System.Windows.Forms.ComboBox comboBxLesTriathlons;
        private System.Windows.Forms.ComboBox comboBxLesTriathlètes;
        private System.Windows.Forms.Label lblTriathlete;
    }
}