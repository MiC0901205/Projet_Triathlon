namespace Projet_Triathlon
{
    partial class FrmAjoutControle
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
            this.txtMesureEtablie = new System.Windows.Forms.TextBox();
            this.lblMesureEtablie = new System.Windows.Forms.Label();
            this.btAnnuler = new System.Windows.Forms.Button();
            this.btValider = new System.Windows.Forms.Button();
            this.lblInscription = new System.Windows.Forms.Label();
            this.lblCodeProdDopant = new System.Windows.Forms.Label();
            this.lblTitre = new System.Windows.Forms.Label();
            this.comboBxLesProdsDop = new System.Windows.Forms.ComboBox();
            this.comboBxLesInscriptions = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtMesureEtablie
            // 
            this.txtMesureEtablie.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMesureEtablie.Location = new System.Drawing.Point(206, 135);
            this.txtMesureEtablie.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMesureEtablie.Name = "txtMesureEtablie";
            this.txtMesureEtablie.Size = new System.Drawing.Size(61, 20);
            this.txtMesureEtablie.TabIndex = 40;
            // 
            // lblMesureEtablie
            // 
            this.lblMesureEtablie.AutoSize = true;
            this.lblMesureEtablie.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMesureEtablie.Location = new System.Drawing.Point(110, 138);
            this.lblMesureEtablie.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMesureEtablie.Name = "lblMesureEtablie";
            this.lblMesureEtablie.Size = new System.Drawing.Size(82, 13);
            this.lblMesureEtablie.TabIndex = 39;
            this.lblMesureEtablie.Text = "Mesure établie :";
            // 
            // btAnnuler
            // 
            this.btAnnuler.BackColor = System.Drawing.Color.OrangeRed;
            this.btAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAnnuler.Location = new System.Drawing.Point(258, 187);
            this.btAnnuler.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btAnnuler.Name = "btAnnuler";
            this.btAnnuler.Size = new System.Drawing.Size(80, 34);
            this.btAnnuler.TabIndex = 35;
            this.btAnnuler.Text = "Annuler";
            this.btAnnuler.UseVisualStyleBackColor = false;
            // 
            // btValider
            // 
            this.btValider.BackColor = System.Drawing.Color.LimeGreen;
            this.btValider.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btValider.Location = new System.Drawing.Point(93, 187);
            this.btValider.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btValider.Name = "btValider";
            this.btValider.Size = new System.Drawing.Size(80, 34);
            this.btValider.TabIndex = 34;
            this.btValider.Text = "Valider";
            this.btValider.UseVisualStyleBackColor = false;
            // 
            // lblInscription
            // 
            this.lblInscription.AutoSize = true;
            this.lblInscription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInscription.Location = new System.Drawing.Point(110, 103);
            this.lblInscription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInscription.Name = "lblInscription";
            this.lblInscription.Size = new System.Drawing.Size(61, 13);
            this.lblInscription.TabIndex = 33;
            this.lblInscription.Text = "Inscription :";
            // 
            // lblCodeProdDopant
            // 
            this.lblCodeProdDopant.AutoSize = true;
            this.lblCodeProdDopant.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodeProdDopant.Location = new System.Drawing.Point(110, 62);
            this.lblCodeProdDopant.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodeProdDopant.Name = "lblCodeProdDopant";
            this.lblCodeProdDopant.Size = new System.Drawing.Size(82, 13);
            this.lblCodeProdDopant.TabIndex = 32;
            this.lblCodeProdDopant.Text = "Produit dopant :";
            // 
            // lblTitre
            // 
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.Location = new System.Drawing.Point(13, 9);
            this.lblTitre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(325, 32);
            this.lblTitre.TabIndex = 31;
            this.lblTitre.Text = "Saisir les informations du nouveau contrôle :";
            this.lblTitre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBxLesProdsDop
            // 
            this.comboBxLesProdsDop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBxLesProdsDop.FormattingEnabled = true;
            this.comboBxLesProdsDop.Location = new System.Drawing.Point(198, 59);
            this.comboBxLesProdsDop.Margin = new System.Windows.Forms.Padding(2);
            this.comboBxLesProdsDop.Name = "comboBxLesProdsDop";
            this.comboBxLesProdsDop.Size = new System.Drawing.Size(108, 21);
            this.comboBxLesProdsDop.TabIndex = 49;
            // 
            // comboBxLesInscriptions
            // 
            this.comboBxLesInscriptions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBxLesInscriptions.FormattingEnabled = true;
            this.comboBxLesInscriptions.Location = new System.Drawing.Point(177, 100);
            this.comboBxLesInscriptions.Margin = new System.Windows.Forms.Padding(2);
            this.comboBxLesInscriptions.Name = "comboBxLesInscriptions";
            this.comboBxLesInscriptions.Size = new System.Drawing.Size(101, 21);
            this.comboBxLesInscriptions.TabIndex = 50;
            // 
            // FrmAjoutControle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBxLesInscriptions);
            this.Controls.Add(this.comboBxLesProdsDop);
            this.Controls.Add(this.txtMesureEtablie);
            this.Controls.Add(this.lblMesureEtablie);
            this.Controls.Add(this.btAnnuler);
            this.Controls.Add(this.btValider);
            this.Controls.Add(this.lblInscription);
            this.Controls.Add(this.lblCodeProdDopant);
            this.Controls.Add(this.lblTitre);
            this.Name = "FrmAjoutControle";
            this.Text = "Ajout d\'un nouveau contrôle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMesureEtablie;
        private System.Windows.Forms.Label lblMesureEtablie;
        private System.Windows.Forms.Button btAnnuler;
        private System.Windows.Forms.Button btValider;
        private System.Windows.Forms.Label lblInscription;
        private System.Windows.Forms.Label lblCodeProdDopant;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.ComboBox comboBxLesProdsDop;
        private System.Windows.Forms.ComboBox comboBxLesInscriptions;
    }
}