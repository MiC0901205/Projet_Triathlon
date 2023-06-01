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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label lblCodeDop;
            System.Windows.Forms.Label lblMesureEtabli;
            System.Windows.Forms.Label lblNumDossard;
            System.Windows.Forms.Label lblNumTriath;
            this.btAnnuler = new System.Windows.Forms.Button();
            this.btValider = new System.Windows.Forms.Button();
            this.lblTitre = new System.Windows.Forms.Label();
            this.bindSrcControler = new System.Windows.Forms.BindingSource(this.components);
            this.comboBxLesCodeDop = new System.Windows.Forms.ComboBox();
            this.txtMesureEtablie = new System.Windows.Forms.TextBox();
            this.comboBxLesNumDossard = new System.Windows.Forms.ComboBox();
            this.comboBxLesNumTriath = new System.Windows.Forms.ComboBox();
            lblCodeDop = new System.Windows.Forms.Label();
            lblMesureEtabli = new System.Windows.Forms.Label();
            lblNumDossard = new System.Windows.Forms.Label();
            lblNumTriath = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindSrcControler)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodeDop
            // 
            lblCodeDop.AutoSize = true;
            lblCodeDop.Location = new System.Drawing.Point(136, 171);
            lblCodeDop.Name = "lblCodeDop";
            lblCodeDop.Size = new System.Drawing.Size(72, 16);
            lblCodeDop.TabIndex = 59;
            lblCodeDop.Text = "Code Dop:";
            // 
            // lblMesureEtabli
            // 
            lblMesureEtabli.AutoSize = true;
            lblMesureEtabli.Location = new System.Drawing.Point(136, 220);
            lblMesureEtabli.Name = "lblMesureEtabli";
            lblMesureEtabli.Size = new System.Drawing.Size(100, 16);
            lblMesureEtabli.TabIndex = 61;
            lblMesureEtabli.Text = "Mesure Etablie:";
            // 
            // lblNumDossard
            // 
            lblNumDossard.AutoSize = true;
            lblNumDossard.Location = new System.Drawing.Point(136, 113);
            lblNumDossard.Name = "lblNumDossard";
            lblNumDossard.Size = new System.Drawing.Size(93, 16);
            lblNumDossard.TabIndex = 63;
            lblNumDossard.Text = "Num Dossard:";
            // 
            // lblNumTriath
            // 
            lblNumTriath.AutoSize = true;
            lblNumTriath.Location = new System.Drawing.Point(136, 68);
            lblNumTriath.Name = "lblNumTriath";
            lblNumTriath.Size = new System.Drawing.Size(75, 16);
            lblNumTriath.TabIndex = 65;
            lblNumTriath.Text = "Num Triath:";
            // 
            // btAnnuler
            // 
            this.btAnnuler.BackColor = System.Drawing.Color.OrangeRed;
            this.btAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAnnuler.Location = new System.Drawing.Point(342, 276);
            this.btAnnuler.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btAnnuler.Name = "btAnnuler";
            this.btAnnuler.Size = new System.Drawing.Size(107, 42);
            this.btAnnuler.TabIndex = 35;
            this.btAnnuler.Text = "Annuler";
            this.btAnnuler.UseVisualStyleBackColor = false;
            this.btAnnuler.Click += new System.EventHandler(this.btAnnuler_Click);
            // 
            // btValider
            // 
            this.btValider.BackColor = System.Drawing.Color.LimeGreen;
            this.btValider.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btValider.Location = new System.Drawing.Point(122, 276);
            this.btValider.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btValider.Name = "btValider";
            this.btValider.Size = new System.Drawing.Size(107, 42);
            this.btValider.TabIndex = 34;
            this.btValider.Text = "Valider";
            this.btValider.UseVisualStyleBackColor = false;
            this.btValider.Click += new System.EventHandler(this.btValider_Click);
            // 
            // lblTitre
            // 
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.Location = new System.Drawing.Point(17, 11);
            this.lblTitre.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(433, 39);
            this.lblTitre.TabIndex = 31;
            this.lblTitre.Text = "Saisir les informations du nouveau contrôle :";
            this.lblTitre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bindSrcControler
            // 
            this.bindSrcControler.DataSource = typeof(Projet_Triathlon.Controler);
            // 
            // comboBxLesCodeDop
            // 
            this.comboBxLesCodeDop.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindSrcControler, "CodeDop", true));
            this.comboBxLesCodeDop.DataSource = this.bindSrcControler;
            this.comboBxLesCodeDop.DisplayMember = "CodeDop";
            this.comboBxLesCodeDop.FormattingEnabled = true;
            this.comboBxLesCodeDop.Location = new System.Drawing.Point(242, 168);
            this.comboBxLesCodeDop.Name = "comboBxLesCodeDop";
            this.comboBxLesCodeDop.Size = new System.Drawing.Size(121, 24);
            this.comboBxLesCodeDop.TabIndex = 60;
            // 
            // txtMesureEtablie
            // 
            this.txtMesureEtablie.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindSrcControler, "MesureEtablie", true));
            this.txtMesureEtablie.Location = new System.Drawing.Point(242, 217);
            this.txtMesureEtablie.Name = "txtMesureEtablie";
            this.txtMesureEtablie.Size = new System.Drawing.Size(121, 22);
            this.txtMesureEtablie.TabIndex = 62;
            // 
            // comboBxLesNumDossard
            // 
            this.comboBxLesNumDossard.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindSrcControler, "NumDossard", true));
            this.comboBxLesNumDossard.DataSource = this.bindSrcControler;
            this.comboBxLesNumDossard.DisplayMember = "NumDossard";
            this.comboBxLesNumDossard.FormattingEnabled = true;
            this.comboBxLesNumDossard.Location = new System.Drawing.Point(242, 109);
            this.comboBxLesNumDossard.Name = "comboBxLesNumDossard";
            this.comboBxLesNumDossard.Size = new System.Drawing.Size(121, 24);
            this.comboBxLesNumDossard.TabIndex = 64;
            // 
            // comboBxLesNumTriath
            // 
            this.comboBxLesNumTriath.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindSrcControler, "NumTriath", true));
            this.comboBxLesNumTriath.FormattingEnabled = true;
            this.comboBxLesNumTriath.Location = new System.Drawing.Point(242, 65);
            this.comboBxLesNumTriath.Name = "comboBxLesNumTriath";
            this.comboBxLesNumTriath.Size = new System.Drawing.Size(121, 24);
            this.comboBxLesNumTriath.TabIndex = 66;
            this.comboBxLesNumTriath.SelectedIndexChanged += new System.EventHandler(this.comboBxLesNumTriath_SelectedIndexChanged);
            // 
            // FrmAjoutControle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 554);
            this.Controls.Add(lblCodeDop);
            this.Controls.Add(this.comboBxLesCodeDop);
            this.Controls.Add(lblMesureEtabli);
            this.Controls.Add(this.txtMesureEtablie);
            this.Controls.Add(lblNumDossard);
            this.Controls.Add(this.comboBxLesNumDossard);
            this.Controls.Add(lblNumTriath);
            this.Controls.Add(this.comboBxLesNumTriath);
            this.Controls.Add(this.btAnnuler);
            this.Controls.Add(this.btValider);
            this.Controls.Add(this.lblTitre);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmAjoutControle";
            this.Text = "Ajout d\'un nouveau contrôle";
            this.Load += new System.EventHandler(this.FrmAjoutControle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindSrcControler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btAnnuler;
        private System.Windows.Forms.Button btValider;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.BindingSource bindSrcControler;
        private System.Windows.Forms.ComboBox comboBxLesCodeDop;
        private System.Windows.Forms.TextBox txtMesureEtablie;
        private System.Windows.Forms.ComboBox comboBxLesNumDossard;
        private System.Windows.Forms.ComboBox comboBxLesNumTriath;
    }
}