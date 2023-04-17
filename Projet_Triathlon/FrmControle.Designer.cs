namespace Projet_Triathlon
{
    partial class FrmControle
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
            this.grpbxControles = new System.Windows.Forms.GroupBox();
            this.btSupprime = new System.Windows.Forms.Button();
            this.gridControle = new System.Windows.Forms.DataGridView();
            this.CodeProdDop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumTriath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumDossard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MesureEtablie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpbxDetailControle = new System.Windows.Forms.GroupBox();
            this.comboBxLesInscriptions = new System.Windows.Forms.ComboBox();
            this.comboBxLesProdsDopant = new System.Windows.Forms.ComboBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblMesureEtablie = new System.Windows.Forms.Label();
            this.lblInscription = new System.Windows.Forms.Label();
            this.btModifier = new System.Windows.Forms.Button();
            this.lblProdDopant = new System.Windows.Forms.Label();
            this.grpbxLesContrôles = new System.Windows.Forms.GroupBox();
            this.btNouveauControle = new System.Windows.Forms.Button();
            this.comboBxLesControles = new System.Windows.Forms.ComboBox();
            this.grpbxControles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControle)).BeginInit();
            this.grpbxDetailControle.SuspendLayout();
            this.grpbxLesContrôles.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbxControles
            // 
            this.grpbxControles.Controls.Add(this.btSupprime);
            this.grpbxControles.Controls.Add(this.gridControle);
            this.grpbxControles.Location = new System.Drawing.Point(285, 100);
            this.grpbxControles.Margin = new System.Windows.Forms.Padding(2);
            this.grpbxControles.Name = "grpbxControles";
            this.grpbxControles.Padding = new System.Windows.Forms.Padding(2);
            this.grpbxControles.Size = new System.Drawing.Size(504, 339);
            this.grpbxControles.TabIndex = 12;
            this.grpbxControles.TabStop = false;
            this.grpbxControles.Text = "Les contrôles";
            // 
            // btSupprime
            // 
            this.btSupprime.BackColor = System.Drawing.Color.OrangeRed;
            this.btSupprime.Enabled = false;
            this.btSupprime.Location = new System.Drawing.Point(197, 293);
            this.btSupprime.Margin = new System.Windows.Forms.Padding(2);
            this.btSupprime.Name = "btSupprime";
            this.btSupprime.Size = new System.Drawing.Size(116, 32);
            this.btSupprime.TabIndex = 6;
            this.btSupprime.Text = "Supprimer contrôle";
            this.btSupprime.UseVisualStyleBackColor = false;
            // 
            // gridControle
            // 
            this.gridControle.AllowUserToAddRows = false;
            this.gridControle.AllowUserToDeleteRows = false;
            this.gridControle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridControle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridControle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodeProdDop,
            this.NumTriath,
            this.NumDossard,
            this.MesureEtablie});
            this.gridControle.Location = new System.Drawing.Point(10, 19);
            this.gridControle.Margin = new System.Windows.Forms.Padding(2);
            this.gridControle.MultiSelect = false;
            this.gridControle.Name = "gridControle";
            this.gridControle.ReadOnly = true;
            this.gridControle.RowHeadersWidth = 51;
            this.gridControle.RowTemplate.Height = 28;
            this.gridControle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridControle.Size = new System.Drawing.Size(494, 258);
            this.gridControle.TabIndex = 0;
            // 
            // CodeProdDop
            // 
            this.CodeProdDop.HeaderText = "CodeProdDopant";
            this.CodeProdDop.MinimumWidth = 6;
            this.CodeProdDop.Name = "CodeProdDop";
            this.CodeProdDop.ReadOnly = true;
            this.CodeProdDop.Width = 114;
            // 
            // NumTriath
            // 
            this.NumTriath.HeaderText = "NumTriath";
            this.NumTriath.MinimumWidth = 6;
            this.NumTriath.Name = "NumTriath";
            this.NumTriath.ReadOnly = true;
            this.NumTriath.Width = 81;
            // 
            // NumDossard
            // 
            this.NumDossard.HeaderText = "NumDossard";
            this.NumDossard.MinimumWidth = 6;
            this.NumDossard.Name = "NumDossard";
            this.NumDossard.ReadOnly = true;
            this.NumDossard.Width = 93;
            // 
            // MesureEtablie
            // 
            this.MesureEtablie.HeaderText = "MesureEtablie";
            this.MesureEtablie.MinimumWidth = 6;
            this.MesureEtablie.Name = "MesureEtablie";
            this.MesureEtablie.ReadOnly = true;
            this.MesureEtablie.Width = 99;
            // 
            // grpbxDetailControle
            // 
            this.grpbxDetailControle.Controls.Add(this.comboBxLesInscriptions);
            this.grpbxDetailControle.Controls.Add(this.comboBxLesProdsDopant);
            this.grpbxDetailControle.Controls.Add(this.textBox3);
            this.grpbxDetailControle.Controls.Add(this.lblMesureEtablie);
            this.grpbxDetailControle.Controls.Add(this.lblInscription);
            this.grpbxDetailControle.Controls.Add(this.btModifier);
            this.grpbxDetailControle.Controls.Add(this.lblProdDopant);
            this.grpbxDetailControle.Location = new System.Drawing.Point(10, 100);
            this.grpbxDetailControle.Margin = new System.Windows.Forms.Padding(2);
            this.grpbxDetailControle.Name = "grpbxDetailControle";
            this.grpbxDetailControle.Padding = new System.Windows.Forms.Padding(2);
            this.grpbxDetailControle.Size = new System.Drawing.Size(256, 339);
            this.grpbxDetailControle.TabIndex = 11;
            this.grpbxDetailControle.TabStop = false;
            this.grpbxDetailControle.Text = "Détail du contrôle";
            // 
            // comboBxLesInscriptions
            // 
            this.comboBxLesInscriptions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBxLesInscriptions.FormattingEnabled = true;
            this.comboBxLesInscriptions.Location = new System.Drawing.Point(4, 110);
            this.comboBxLesInscriptions.Margin = new System.Windows.Forms.Padding(2);
            this.comboBxLesInscriptions.Name = "comboBxLesInscriptions";
            this.comboBxLesInscriptions.Size = new System.Drawing.Size(164, 21);
            this.comboBxLesInscriptions.TabIndex = 12;
            // 
            // comboBxLesProdsDopant
            // 
            this.comboBxLesProdsDopant.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBxLesProdsDopant.FormattingEnabled = true;
            this.comboBxLesProdsDopant.Location = new System.Drawing.Point(12, 54);
            this.comboBxLesProdsDopant.Margin = new System.Windows.Forms.Padding(2);
            this.comboBxLesProdsDopant.Name = "comboBxLesProdsDopant";
            this.comboBxLesProdsDopant.Size = new System.Drawing.Size(156, 21);
            this.comboBxLesProdsDopant.TabIndex = 11;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(12, 167);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.MaxLength = 200;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(86, 20);
            this.textBox3.TabIndex = 10;
            // 
            // lblMesureEtablie
            // 
            this.lblMesureEtablie.AutoSize = true;
            this.lblMesureEtablie.Location = new System.Drawing.Point(16, 145);
            this.lblMesureEtablie.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMesureEtablie.Name = "lblMesureEtablie";
            this.lblMesureEtablie.Size = new System.Drawing.Size(82, 13);
            this.lblMesureEtablie.TabIndex = 8;
            this.lblMesureEtablie.Text = "Mesure établie :";
            // 
            // lblInscription
            // 
            this.lblInscription.AutoSize = true;
            this.lblInscription.Location = new System.Drawing.Point(12, 86);
            this.lblInscription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInscription.Name = "lblInscription";
            this.lblInscription.Size = new System.Drawing.Size(61, 13);
            this.lblInscription.TabIndex = 7;
            this.lblInscription.Text = "Inscription :";
            // 
            // btModifier
            // 
            this.btModifier.BackColor = System.Drawing.Color.Silver;
            this.btModifier.Enabled = false;
            this.btModifier.Location = new System.Drawing.Point(68, 208);
            this.btModifier.Margin = new System.Windows.Forms.Padding(2);
            this.btModifier.Name = "btModifier";
            this.btModifier.Size = new System.Drawing.Size(78, 27);
            this.btModifier.TabIndex = 4;
            this.btModifier.Text = "Modifier";
            this.btModifier.UseVisualStyleBackColor = false;
            // 
            // lblProdDopant
            // 
            this.lblProdDopant.AutoSize = true;
            this.lblProdDopant.Location = new System.Drawing.Point(16, 30);
            this.lblProdDopant.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProdDopant.Name = "lblProdDopant";
            this.lblProdDopant.Size = new System.Drawing.Size(82, 13);
            this.lblProdDopant.TabIndex = 0;
            this.lblProdDopant.Text = "Produit dopant :";
            // 
            // grpbxLesContrôles
            // 
            this.grpbxLesContrôles.Controls.Add(this.btNouveauControle);
            this.grpbxLesContrôles.Controls.Add(this.comboBxLesControles);
            this.grpbxLesContrôles.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbxLesContrôles.Location = new System.Drawing.Point(11, 11);
            this.grpbxLesContrôles.Margin = new System.Windows.Forms.Padding(2);
            this.grpbxLesContrôles.Name = "grpbxLesContrôles";
            this.grpbxLesContrôles.Padding = new System.Windows.Forms.Padding(2);
            this.grpbxLesContrôles.Size = new System.Drawing.Size(778, 78);
            this.grpbxLesContrôles.TabIndex = 10;
            this.grpbxLesContrôles.TabStop = false;
            this.grpbxLesContrôles.Text = "Selectionner un contrôle dans la liste :";
            // 
            // btNouveauControle
            // 
            this.btNouveauControle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btNouveauControle.Location = new System.Drawing.Point(458, 25);
            this.btNouveauControle.Margin = new System.Windows.Forms.Padding(2);
            this.btNouveauControle.Name = "btNouveauControle";
            this.btNouveauControle.Size = new System.Drawing.Size(129, 32);
            this.btNouveauControle.TabIndex = 7;
            this.btNouveauControle.Text = "Nouveau contrôle";
            this.btNouveauControle.UseVisualStyleBackColor = false;
            // 
            // comboBxLesControles
            // 
            this.comboBxLesControles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBxLesControles.FormattingEnabled = true;
            this.comboBxLesControles.Location = new System.Drawing.Point(43, 31);
            this.comboBxLesControles.Margin = new System.Windows.Forms.Padding(2);
            this.comboBxLesControles.Name = "comboBxLesControles";
            this.comboBxLesControles.Size = new System.Drawing.Size(375, 21);
            this.comboBxLesControles.TabIndex = 0;
            // 
            // FrmControle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpbxControles);
            this.Controls.Add(this.grpbxDetailControle);
            this.Controls.Add(this.grpbxLesContrôles);
            this.Name = "FrmControle";
            this.Text = "Gestion des contrôles";
            this.grpbxControles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControle)).EndInit();
            this.grpbxDetailControle.ResumeLayout(false);
            this.grpbxDetailControle.PerformLayout();
            this.grpbxLesContrôles.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbxControles;
        private System.Windows.Forms.Button btSupprime;
        private System.Windows.Forms.DataGridView gridControle;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodeProdDop;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumTriath;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumDossard;
        private System.Windows.Forms.DataGridViewTextBoxColumn MesureEtablie;
        private System.Windows.Forms.GroupBox grpbxDetailControle;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblMesureEtablie;
        private System.Windows.Forms.Label lblInscription;
        private System.Windows.Forms.Button btModifier;
        private System.Windows.Forms.Label lblProdDopant;
        private System.Windows.Forms.GroupBox grpbxLesContrôles;
        private System.Windows.Forms.Button btNouveauControle;
        private System.Windows.Forms.ComboBox comboBxLesControles;
        private System.Windows.Forms.ComboBox comboBxLesInscriptions;
        private System.Windows.Forms.ComboBox comboBxLesProdsDopant;
    }
}