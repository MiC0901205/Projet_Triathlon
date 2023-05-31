namespace Projet_Triathlon
{
    partial class FrmAjoutProdDopant
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
            System.Windows.Forms.Label lblLibelle;
            System.Windows.Forms.Label lblTauxMax;
            this.btAnnuler = new System.Windows.Forms.Button();
            this.btValider = new System.Windows.Forms.Button();
            this.lblTitre = new System.Windows.Forms.Label();
            this.txtLibelle = new System.Windows.Forms.TextBox();
            this.txtTauxMax = new System.Windows.Forms.TextBox();
            lblLibelle = new System.Windows.Forms.Label();
            lblTauxMax = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblLibelle
            // 
            lblLibelle.AutoSize = true;
            lblLibelle.Location = new System.Drawing.Point(192, 104);
            lblLibelle.Name = "lblLibelle";
            lblLibelle.Size = new System.Drawing.Size(50, 16);
            lblLibelle.TabIndex = 20;
            lblLibelle.Text = "Libelle:";
            // 
            // lblTauxMax
            // 
            lblTauxMax.AutoSize = true;
            lblTauxMax.Location = new System.Drawing.Point(192, 169);
            lblTauxMax.Name = "lblTauxMax";
            lblTauxMax.Size = new System.Drawing.Size(68, 16);
            lblTauxMax.TabIndex = 22;
            lblTauxMax.Text = "Taux Max:";
            // 
            // btAnnuler
            // 
            this.btAnnuler.BackColor = System.Drawing.Color.OrangeRed;
            this.btAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAnnuler.Location = new System.Drawing.Point(415, 252);
            this.btAnnuler.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btAnnuler.Name = "btAnnuler";
            this.btAnnuler.Size = new System.Drawing.Size(107, 42);
            this.btAnnuler.TabIndex = 17;
            this.btAnnuler.Text = "Annuler";
            this.btAnnuler.UseVisualStyleBackColor = false;
            this.btAnnuler.Click += new System.EventHandler(this.btAnnuler_Click);
            // 
            // btValider
            // 
            this.btValider.BackColor = System.Drawing.Color.LimeGreen;
            this.btValider.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btValider.Location = new System.Drawing.Point(195, 252);
            this.btValider.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btValider.Name = "btValider";
            this.btValider.Size = new System.Drawing.Size(107, 42);
            this.btValider.TabIndex = 16;
            this.btValider.Text = "Valider";
            this.btValider.UseVisualStyleBackColor = false;
            this.btValider.Click += new System.EventHandler(this.btValider_Click);
            // 
            // lblTitre
            // 
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.Location = new System.Drawing.Point(48, 28);
            this.lblTitre.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(433, 39);
            this.lblTitre.TabIndex = 10;
            this.lblTitre.Text = "Saisir les informations du nouveau produit dopant :";
            this.lblTitre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtLibelle
            // 
            this.txtLibelle.Location = new System.Drawing.Point(270, 101);
            this.txtLibelle.Name = "txtLibelle";
            this.txtLibelle.Size = new System.Drawing.Size(120, 22);
            this.txtLibelle.TabIndex = 21;
            // 
            // txtTauxMax
            // 
            this.txtTauxMax.Location = new System.Drawing.Point(270, 166);
            this.txtTauxMax.Name = "txtTauxMax";
            this.txtTauxMax.Size = new System.Drawing.Size(120, 22);
            this.txtTauxMax.TabIndex = 23;
            // 
            // FrmAjoutProdDopant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 319);
            this.Controls.Add(lblLibelle);
            this.Controls.Add(this.txtLibelle);
            this.Controls.Add(lblTauxMax);
            this.Controls.Add(this.txtTauxMax);
            this.Controls.Add(this.btAnnuler);
            this.Controls.Add(this.btValider);
            this.Controls.Add(this.lblTitre);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmAjoutProdDopant";
            this.Text = "Ajout d\'un nouveau produit dopant";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btAnnuler;
        private System.Windows.Forms.Button btValider;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.TextBox txtLibelle;
        private System.Windows.Forms.TextBox txtTauxMax;
    }
}