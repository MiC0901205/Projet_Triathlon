namespace Projet_Triathlon
{
    partial class FrmTriathlete
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpbxTriathletes = new System.Windows.Forms.GroupBox();
            this.btSupprimer = new System.Windows.Forms.Button();
            this.gridTriathlete = new System.Windows.Forms.DataGridView();
            this.colNumCli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomCli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrenomCLi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateNaissance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpbxDetailTriathlete = new System.Windows.Forms.GroupBox();
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.lblAdresse = new System.Windows.Forms.Label();
            this.txtVille = new System.Windows.Forms.TextBox();
            this.lblVille = new System.Windows.Forms.Label();
            this.txtCP = new System.Windows.Forms.TextBox();
            this.lblCP = new System.Windows.Forms.Label();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.btModifier = new System.Windows.Forms.Button();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.lblLibelle = new System.Windows.Forms.Label();
            this.btNouveauTriathlete = new System.Windows.Forms.Button();
            this.grpbxTriathletes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTriathlete)).BeginInit();
            this.grpbxDetailTriathlete.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbxTriathletes
            // 
            this.grpbxTriathletes.Controls.Add(this.btNouveauTriathlete);
            this.grpbxTriathletes.Controls.Add(this.btSupprimer);
            this.grpbxTriathletes.Controls.Add(this.gridTriathlete);
            this.grpbxTriathletes.Location = new System.Drawing.Point(242, 56);
            this.grpbxTriathletes.Margin = new System.Windows.Forms.Padding(2);
            this.grpbxTriathletes.Name = "grpbxTriathletes";
            this.grpbxTriathletes.Padding = new System.Windows.Forms.Padding(2);
            this.grpbxTriathletes.Size = new System.Drawing.Size(547, 329);
            this.grpbxTriathletes.TabIndex = 12;
            this.grpbxTriathletes.TabStop = false;
            this.grpbxTriathletes.Text = "Les triathlètes";
            // 
            // btSupprimer
            // 
            this.btSupprimer.BackColor = System.Drawing.Color.OrangeRed;
            this.btSupprimer.Enabled = false;
            this.btSupprimer.Location = new System.Drawing.Point(160, 277);
            this.btSupprimer.Margin = new System.Windows.Forms.Padding(2);
            this.btSupprimer.Name = "btSupprimer";
            this.btSupprimer.Size = new System.Drawing.Size(129, 32);
            this.btSupprimer.TabIndex = 6;
            this.btSupprimer.Text = "Supprimer triathlète";
            this.btSupprimer.UseVisualStyleBackColor = false;
            // 
            // gridTriathlete
            // 
            this.gridTriathlete.AllowUserToAddRows = false;
            this.gridTriathlete.AllowUserToDeleteRows = false;
            this.gridTriathlete.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridTriathlete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTriathlete.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNumCli,
            this.colNomCli,
            this.colPrenomCLi,
            this.Column1,
            this.Column2,
            this.Column3,
            this.DateNaissance});
            this.gridTriathlete.Location = new System.Drawing.Point(10, 19);
            this.gridTriathlete.Margin = new System.Windows.Forms.Padding(2);
            this.gridTriathlete.MultiSelect = false;
            this.gridTriathlete.Name = "gridTriathlete";
            this.gridTriathlete.ReadOnly = true;
            this.gridTriathlete.RowHeadersWidth = 51;
            this.gridTriathlete.RowTemplate.Height = 28;
            this.gridTriathlete.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridTriathlete.Size = new System.Drawing.Size(533, 236);
            this.gridTriathlete.TabIndex = 0;
            // 
            // colNumCli
            // 
            this.colNumCli.HeaderText = "Num";
            this.colNumCli.MinimumWidth = 6;
            this.colNumCli.Name = "colNumCli";
            this.colNumCli.ReadOnly = true;
            this.colNumCli.Width = 54;
            // 
            // colNomCli
            // 
            this.colNomCli.HeaderText = "Nom";
            this.colNomCli.MinimumWidth = 6;
            this.colNomCli.Name = "colNomCli";
            this.colNomCli.ReadOnly = true;
            this.colNomCli.Width = 54;
            // 
            // colPrenomCLi
            // 
            this.colPrenomCLi.HeaderText = "Prénom";
            this.colPrenomCLi.MinimumWidth = 6;
            this.colPrenomCLi.Name = "colPrenomCLi";
            this.colPrenomCLi.ReadOnly = true;
            this.colPrenomCLi.Width = 68;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Code Postale";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 95;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Ville";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 51;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Adresse";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 70;
            // 
            // DateNaissance
            // 
            this.DateNaissance.HeaderText = "DateNaissance";
            this.DateNaissance.Name = "DateNaissance";
            this.DateNaissance.ReadOnly = true;
            this.DateNaissance.Width = 105;
            // 
            // grpbxDetailTriathlete
            // 
            this.grpbxDetailTriathlete.Controls.Add(this.txtAdresse);
            this.grpbxDetailTriathlete.Controls.Add(this.lblAdresse);
            this.grpbxDetailTriathlete.Controls.Add(this.txtVille);
            this.grpbxDetailTriathlete.Controls.Add(this.lblVille);
            this.grpbxDetailTriathlete.Controls.Add(this.txtCP);
            this.grpbxDetailTriathlete.Controls.Add(this.lblCP);
            this.grpbxDetailTriathlete.Controls.Add(this.txtPrenom);
            this.grpbxDetailTriathlete.Controls.Add(this.lblPrenom);
            this.grpbxDetailTriathlete.Controls.Add(this.btModifier);
            this.grpbxDetailTriathlete.Controls.Add(this.txtNom);
            this.grpbxDetailTriathlete.Controls.Add(this.lblLibelle);
            this.grpbxDetailTriathlete.Location = new System.Drawing.Point(11, 56);
            this.grpbxDetailTriathlete.Margin = new System.Windows.Forms.Padding(2);
            this.grpbxDetailTriathlete.Name = "grpbxDetailTriathlete";
            this.grpbxDetailTriathlete.Padding = new System.Windows.Forms.Padding(2);
            this.grpbxDetailTriathlete.Size = new System.Drawing.Size(227, 329);
            this.grpbxDetailTriathlete.TabIndex = 11;
            this.grpbxDetailTriathlete.TabStop = false;
            this.grpbxDetailTriathlete.Text = "Détail du triathlète";
            // 
            // txtAdresse
            // 
            this.txtAdresse.Location = new System.Drawing.Point(9, 246);
            this.txtAdresse.Margin = new System.Windows.Forms.Padding(2);
            this.txtAdresse.MaxLength = 200;
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(191, 20);
            this.txtAdresse.TabIndex = 12;
            // 
            // lblAdresse
            // 
            this.lblAdresse.AutoSize = true;
            this.lblAdresse.Location = new System.Drawing.Point(13, 228);
            this.lblAdresse.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdresse.Name = "lblAdresse";
            this.lblAdresse.Size = new System.Drawing.Size(51, 13);
            this.lblAdresse.TabIndex = 11;
            this.lblAdresse.Text = "Adresse :";
            // 
            // txtVille
            // 
            this.txtVille.Location = new System.Drawing.Point(9, 194);
            this.txtVille.Margin = new System.Windows.Forms.Padding(2);
            this.txtVille.MaxLength = 200;
            this.txtVille.Name = "txtVille";
            this.txtVille.Size = new System.Drawing.Size(141, 20);
            this.txtVille.TabIndex = 10;
            // 
            // lblVille
            // 
            this.lblVille.AutoSize = true;
            this.lblVille.Location = new System.Drawing.Point(13, 176);
            this.lblVille.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVille.Name = "lblVille";
            this.lblVille.Size = new System.Drawing.Size(32, 13);
            this.lblVille.TabIndex = 9;
            this.lblVille.Text = "Ville :";
            // 
            // txtCP
            // 
            this.txtCP.Location = new System.Drawing.Point(9, 145);
            this.txtCP.Margin = new System.Windows.Forms.Padding(2);
            this.txtCP.MaxLength = 200;
            this.txtCP.Name = "txtCP";
            this.txtCP.Size = new System.Drawing.Size(61, 20);
            this.txtCP.TabIndex = 8;
            // 
            // lblCP
            // 
            this.lblCP.AutoSize = true;
            this.lblCP.Location = new System.Drawing.Point(13, 127);
            this.lblCP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCP.Name = "lblCP";
            this.lblCP.Size = new System.Drawing.Size(75, 13);
            this.lblCP.TabIndex = 7;
            this.lblCP.Text = "Code postale :";
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(9, 93);
            this.txtPrenom.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrenom.MaxLength = 200;
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(112, 20);
            this.txtPrenom.TabIndex = 6;
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(13, 75);
            this.lblPrenom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(49, 13);
            this.lblPrenom.TabIndex = 5;
            this.lblPrenom.Text = "Prénom :";
            // 
            // btModifier
            // 
            this.btModifier.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btModifier.Enabled = false;
            this.btModifier.Location = new System.Drawing.Point(72, 288);
            this.btModifier.Margin = new System.Windows.Forms.Padding(2);
            this.btModifier.Name = "btModifier";
            this.btModifier.Size = new System.Drawing.Size(78, 27);
            this.btModifier.TabIndex = 4;
            this.btModifier.Text = "Modifier";
            this.btModifier.UseVisualStyleBackColor = false;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(9, 43);
            this.txtNom.Margin = new System.Windows.Forms.Padding(2);
            this.txtNom.MaxLength = 200;
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(112, 20);
            this.txtNom.TabIndex = 1;
            // 
            // lblLibelle
            // 
            this.lblLibelle.AutoSize = true;
            this.lblLibelle.Location = new System.Drawing.Point(13, 25);
            this.lblLibelle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLibelle.Name = "lblLibelle";
            this.lblLibelle.Size = new System.Drawing.Size(35, 13);
            this.lblLibelle.TabIndex = 0;
            this.lblLibelle.Text = "Nom :";
            // 
            // btNouveauTriathlete
            // 
            this.btNouveauTriathlete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btNouveauTriathlete.Location = new System.Drawing.Point(304, 277);
            this.btNouveauTriathlete.Margin = new System.Windows.Forms.Padding(2);
            this.btNouveauTriathlete.Name = "btNouveauTriathlete";
            this.btNouveauTriathlete.Size = new System.Drawing.Size(129, 32);
            this.btNouveauTriathlete.TabIndex = 7;
            this.btNouveauTriathlete.Text = "Nouveau triathlète";
            this.btNouveauTriathlete.UseVisualStyleBackColor = false;
            // 
            // FrmTriathlete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpbxTriathletes);
            this.Controls.Add(this.grpbxDetailTriathlete);
            this.Name = "FrmTriathlete";
            this.Text = "Gestion des triathlètes";
            this.grpbxTriathletes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridTriathlete)).EndInit();
            this.grpbxDetailTriathlete.ResumeLayout(false);
            this.grpbxDetailTriathlete.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbxTriathletes;
        private System.Windows.Forms.Button btSupprimer;
        private System.Windows.Forms.DataGridView gridTriathlete;
        private System.Windows.Forms.GroupBox grpbxDetailTriathlete;
        private System.Windows.Forms.Button btModifier;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label lblLibelle;
        private System.Windows.Forms.TextBox txtAdresse;
        private System.Windows.Forms.Label lblAdresse;
        private System.Windows.Forms.TextBox txtVille;
        private System.Windows.Forms.Label lblVille;
        private System.Windows.Forms.TextBox txtCP;
        private System.Windows.Forms.Label lblCP;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumCli;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomCli;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrenomCLi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateNaissance;
        private System.Windows.Forms.Button btNouveauTriathlete;
    }
}

