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
            this.grpbxLesControles = new System.Windows.Forms.GroupBox();
            this.btAjouterControle = new System.Windows.Forms.Button();
            this.btSupprimerControle = new System.Windows.Forms.Button();
            this.gridControle = new System.Windows.Forms.DataGridView();
            this.colNumCli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomCli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrenomCLi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DistanceCyc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpbxDetailTypeTriath = new System.Windows.Forms.GroupBox();
            this.btSupprimerTypeTriath = new System.Windows.Forms.Button();
            this.txtDistanceNatation = new System.Windows.Forms.TextBox();
            this.lblTempsCourse = new System.Windows.Forms.Label();
            this.txtDistanceCyclisme = new System.Windows.Forms.TextBox();
            this.lblTempsNatation = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.lblTempsCyclisme = new System.Windows.Forms.Label();
            this.btModifier = new System.Windows.Forms.Button();
            this.txtDesignation = new System.Windows.Forms.TextBox();
            this.lblDateInscription = new System.Windows.Forms.Label();
            this.grpbxLesInscriptions = new System.Windows.Forms.GroupBox();
            this.btNouveau = new System.Windows.Forms.Button();
            this.comboBxLesTypesTriath = new System.Windows.Forms.ComboBox();
            this.grpbxLesControles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControle)).BeginInit();
            this.grpbxDetailTypeTriath.SuspendLayout();
            this.grpbxLesInscriptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbxLesControles
            // 
            this.grpbxLesControles.Controls.Add(this.btAjouterControle);
            this.grpbxLesControles.Controls.Add(this.btSupprimerControle);
            this.grpbxLesControles.Controls.Add(this.gridControle);
            this.grpbxLesControles.Location = new System.Drawing.Point(307, 135);
            this.grpbxLesControles.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpbxLesControles.Name = "grpbxLesControles";
            this.grpbxLesControles.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpbxLesControles.Size = new System.Drawing.Size(745, 405);
            this.grpbxLesControles.TabIndex = 15;
            this.grpbxLesControles.TabStop = false;
            this.grpbxLesControles.Text = "Les contrôles";
            // 
            // btAjouterControle
            // 
            this.btAjouterControle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btAjouterControle.Enabled = false;
            this.btAjouterControle.Location = new System.Drawing.Point(173, 321);
            this.btAjouterControle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btAjouterControle.Name = "btAjouterControle";
            this.btAjouterControle.Size = new System.Drawing.Size(189, 47);
            this.btAjouterControle.TabIndex = 7;
            this.btAjouterControle.Text = "Ajouter un contrôle";
            this.btAjouterControle.UseVisualStyleBackColor = false;
            // 
            // btSupprimerControle
            // 
            this.btSupprimerControle.BackColor = System.Drawing.Color.OrangeRed;
            this.btSupprimerControle.Enabled = false;
            this.btSupprimerControle.Location = new System.Drawing.Point(410, 321);
            this.btSupprimerControle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btSupprimerControle.Name = "btSupprimerControle";
            this.btSupprimerControle.Size = new System.Drawing.Size(189, 47);
            this.btSupprimerControle.TabIndex = 6;
            this.btSupprimerControle.Text = "Supprimer ce contrôle";
            this.btSupprimerControle.UseVisualStyleBackColor = false;
            // 
            // gridControle
            // 
            this.gridControle.AllowUserToAddRows = false;
            this.gridControle.AllowUserToDeleteRows = false;
            this.gridControle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridControle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridControle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNumCli,
            this.colNomCli,
            this.colPrenomCLi,
            this.DistanceCyc,
            this.Column1,
            this.Column2});
            this.gridControle.Location = new System.Drawing.Point(13, 23);
            this.gridControle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControle.MultiSelect = false;
            this.gridControle.Name = "gridControle";
            this.gridControle.ReadOnly = true;
            this.gridControle.RowHeadersWidth = 51;
            this.gridControle.RowTemplate.Height = 28;
            this.gridControle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridControle.Size = new System.Drawing.Size(732, 276);
            this.gridControle.TabIndex = 0;
            // 
            // colNumCli
            // 
            this.colNumCli.HeaderText = "Code";
            this.colNumCli.MinimumWidth = 6;
            this.colNumCli.Name = "colNumCli";
            this.colNumCli.ReadOnly = true;
            this.colNumCli.Width = 69;
            // 
            // colNomCli
            // 
            this.colNomCli.HeaderText = "Désignation";
            this.colNomCli.MinimumWidth = 6;
            this.colNomCli.Name = "colNomCli";
            this.colNomCli.ReadOnly = true;
            this.colNomCli.Width = 108;
            // 
            // colPrenomCLi
            // 
            this.colPrenomCLi.HeaderText = "Nom";
            this.colPrenomCLi.MinimumWidth = 6;
            this.colPrenomCLi.Name = "colPrenomCLi";
            this.colPrenomCLi.ReadOnly = true;
            this.colPrenomCLi.Width = 65;
            // 
            // DistanceCyc
            // 
            this.DistanceCyc.HeaderText = "DistanceCyc";
            this.DistanceCyc.MinimumWidth = 6;
            this.DistanceCyc.Name = "DistanceCyc";
            this.DistanceCyc.ReadOnly = true;
            this.DistanceCyc.Width = 112;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "DistanceNat";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 110;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "DistanceCourse";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 132;
            // 
            // grpbxDetailTypeTriath
            // 
            this.grpbxDetailTypeTriath.Controls.Add(this.btSupprimerTypeTriath);
            this.grpbxDetailTypeTriath.Controls.Add(this.txtDistanceNatation);
            this.grpbxDetailTypeTriath.Controls.Add(this.lblTempsCourse);
            this.grpbxDetailTypeTriath.Controls.Add(this.txtDistanceCyclisme);
            this.grpbxDetailTypeTriath.Controls.Add(this.lblTempsNatation);
            this.grpbxDetailTypeTriath.Controls.Add(this.txtNom);
            this.grpbxDetailTypeTriath.Controls.Add(this.lblTempsCyclisme);
            this.grpbxDetailTypeTriath.Controls.Add(this.btModifier);
            this.grpbxDetailTypeTriath.Controls.Add(this.txtDesignation);
            this.grpbxDetailTypeTriath.Controls.Add(this.lblDateInscription);
            this.grpbxDetailTypeTriath.Location = new System.Drawing.Point(15, 135);
            this.grpbxDetailTypeTriath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpbxDetailTypeTriath.Name = "grpbxDetailTypeTriath";
            this.grpbxDetailTypeTriath.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpbxDetailTypeTriath.Size = new System.Drawing.Size(287, 405);
            this.grpbxDetailTypeTriath.TabIndex = 14;
            this.grpbxDetailTypeTriath.TabStop = false;
            this.grpbxDetailTypeTriath.Text = "Détail de l\'inscription";
            // 
            // btSupprimerTypeTriath
            // 
            this.btSupprimerTypeTriath.BackColor = System.Drawing.Color.OrangeRed;
            this.btSupprimerTypeTriath.Enabled = false;
            this.btSupprimerTypeTriath.Location = new System.Drawing.Point(125, 356);
            this.btSupprimerTypeTriath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btSupprimerTypeTriath.Name = "btSupprimerTypeTriath";
            this.btSupprimerTypeTriath.Size = new System.Drawing.Size(109, 33);
            this.btSupprimerTypeTriath.TabIndex = 7;
            this.btSupprimerTypeTriath.Text = "Supprimer";
            this.btSupprimerTypeTriath.UseVisualStyleBackColor = false;
            // 
            // txtDistanceNatation
            // 
            this.txtDistanceNatation.Location = new System.Drawing.Point(16, 244);
            this.txtDistanceNatation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDistanceNatation.MaxLength = 200;
            this.txtDistanceNatation.Name = "txtDistanceNatation";
            this.txtDistanceNatation.Size = new System.Drawing.Size(144, 22);
            this.txtDistanceNatation.TabIndex = 10;
            // 
            // lblTempsCourse
            // 
            this.lblTempsCourse.AutoSize = true;
            this.lblTempsCourse.Location = new System.Drawing.Point(21, 222);
            this.lblTempsCourse.Name = "lblTempsCourse";
            this.lblTempsCourse.Size = new System.Drawing.Size(100, 16);
            this.lblTempsCourse.TabIndex = 9;
            this.lblTempsCourse.Text = "Temps course :";
            // 
            // txtDistanceCyclisme
            // 
            this.txtDistanceCyclisme.Location = new System.Drawing.Point(16, 181);
            this.txtDistanceCyclisme.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDistanceCyclisme.MaxLength = 200;
            this.txtDistanceCyclisme.Name = "txtDistanceCyclisme";
            this.txtDistanceCyclisme.Size = new System.Drawing.Size(144, 22);
            this.txtDistanceCyclisme.TabIndex = 8;
            // 
            // lblTempsNatation
            // 
            this.lblTempsNatation.AutoSize = true;
            this.lblTempsNatation.Location = new System.Drawing.Point(21, 159);
            this.lblTempsNatation.Name = "lblTempsNatation";
            this.lblTempsNatation.Size = new System.Drawing.Size(106, 16);
            this.lblTempsNatation.TabIndex = 7;
            this.lblTempsNatation.Text = "Temps natation :";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(16, 121);
            this.txtNom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNom.MaxLength = 200;
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(205, 22);
            this.txtNom.TabIndex = 6;
            // 
            // lblTempsCyclisme
            // 
            this.lblTempsCyclisme.AutoSize = true;
            this.lblTempsCyclisme.Location = new System.Drawing.Point(21, 98);
            this.lblTempsCyclisme.Name = "lblTempsCyclisme";
            this.lblTempsCyclisme.Size = new System.Drawing.Size(112, 16);
            this.lblTempsCyclisme.TabIndex = 5;
            this.lblTempsCyclisme.Text = "Temps cyclisme :";
            // 
            // btModifier
            // 
            this.btModifier.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btModifier.Enabled = false;
            this.btModifier.Location = new System.Drawing.Point(16, 356);
            this.btModifier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btModifier.Name = "btModifier";
            this.btModifier.Size = new System.Drawing.Size(104, 33);
            this.btModifier.TabIndex = 4;
            this.btModifier.Text = "Modifier";
            this.btModifier.UseVisualStyleBackColor = false;
            // 
            // txtDesignation
            // 
            this.txtDesignation.Location = new System.Drawing.Point(16, 59);
            this.txtDesignation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDesignation.MaxLength = 200;
            this.txtDesignation.Name = "txtDesignation";
            this.txtDesignation.Size = new System.Drawing.Size(144, 22);
            this.txtDesignation.TabIndex = 1;
            // 
            // lblDateInscription
            // 
            this.lblDateInscription.AutoSize = true;
            this.lblDateInscription.Location = new System.Drawing.Point(21, 37);
            this.lblDateInscription.Name = "lblDateInscription";
            this.lblDateInscription.Size = new System.Drawing.Size(130, 16);
            this.lblDateInscription.TabIndex = 0;
            this.lblDateInscription.Text = "Date de l\'inscription :";
            // 
            // grpbxLesInscriptions
            // 
            this.grpbxLesInscriptions.Controls.Add(this.btNouveau);
            this.grpbxLesInscriptions.Controls.Add(this.comboBxLesTypesTriath);
            this.grpbxLesInscriptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbxLesInscriptions.Location = new System.Drawing.Point(15, 14);
            this.grpbxLesInscriptions.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpbxLesInscriptions.Name = "grpbxLesInscriptions";
            this.grpbxLesInscriptions.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpbxLesInscriptions.Size = new System.Drawing.Size(1037, 106);
            this.grpbxLesInscriptions.TabIndex = 13;
            this.grpbxLesInscriptions.TabStop = false;
            this.grpbxLesInscriptions.Text = "Selectionner une inscription dans la liste :";
            // 
            // btNouveau
            // 
            this.btNouveau.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btNouveau.Location = new System.Drawing.Point(611, 21);
            this.btNouveau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btNouveau.Name = "btNouveau";
            this.btNouveau.Size = new System.Drawing.Size(188, 49);
            this.btNouveau.TabIndex = 7;
            this.btNouveau.Text = "Nouvelle inscription";
            this.btNouveau.UseVisualStyleBackColor = false;
            // 
            // comboBxLesTypesTriath
            // 
            this.comboBxLesTypesTriath.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBxLesTypesTriath.FormattingEnabled = true;
            this.comboBxLesTypesTriath.Location = new System.Drawing.Point(57, 38);
            this.comboBxLesTypesTriath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBxLesTypesTriath.Name = "comboBxLesTypesTriath";
            this.comboBxLesTypesTriath.Size = new System.Drawing.Size(499, 24);
            this.comboBxLesTypesTriath.TabIndex = 0;
            // 
            // FrmControle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.grpbxLesControles);
            this.Controls.Add(this.grpbxDetailTypeTriath);
            this.Controls.Add(this.grpbxLesInscriptions);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmControle";
            this.Text = "Gestion des contrôles";
            this.grpbxLesControles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControle)).EndInit();
            this.grpbxDetailTypeTriath.ResumeLayout(false);
            this.grpbxDetailTypeTriath.PerformLayout();
            this.grpbxLesInscriptions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbxLesControles;
        private System.Windows.Forms.Button btSupprimerControle;
        private System.Windows.Forms.DataGridView gridControle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumCli;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomCli;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrenomCLi;
        private System.Windows.Forms.DataGridViewTextBoxColumn DistanceCyc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.GroupBox grpbxDetailTypeTriath;
        private System.Windows.Forms.Button btSupprimerTypeTriath;
        private System.Windows.Forms.TextBox txtDistanceNatation;
        private System.Windows.Forms.Label lblTempsCourse;
        private System.Windows.Forms.TextBox txtDistanceCyclisme;
        private System.Windows.Forms.Label lblTempsNatation;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label lblTempsCyclisme;
        private System.Windows.Forms.Button btModifier;
        private System.Windows.Forms.TextBox txtDesignation;
        private System.Windows.Forms.Label lblDateInscription;
        private System.Windows.Forms.GroupBox grpbxLesInscriptions;
        private System.Windows.Forms.Button btNouveau;
        private System.Windows.Forms.ComboBox comboBxLesTypesTriath;
        private System.Windows.Forms.Button btAjouterControle;
    }
}