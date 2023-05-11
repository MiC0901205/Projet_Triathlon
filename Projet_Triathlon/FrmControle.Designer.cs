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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label dateInscriptionLabel;
            System.Windows.Forms.Label numDossardLabel;
            System.Windows.Forms.Label numLicenceLabel;
            System.Windows.Forms.Label numTriathLabel;
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
            this.numTriathDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numDossardDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeDopDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mesureEtablieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindSrcControler = new System.Windows.Forms.BindingSource(this.components);
            this.grpbxDetailTypeTriath = new System.Windows.Forms.GroupBox();
            this.btSupprimerTypeTriath = new System.Windows.Forms.Button();
            this.btModifier = new System.Windows.Forms.Button();
            this.grpbxLesInscriptions = new System.Windows.Forms.GroupBox();
            this.btNouveau = new System.Windows.Forms.Button();
            this.comboBxLesTypesTriath = new System.Windows.Forms.ComboBox();
            this.inscriptionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateInscriptionDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.numDossardLabel1 = new System.Windows.Forms.Label();
            this.numLicenceLabel1 = new System.Windows.Forms.Label();
            this.numTriathLabel1 = new System.Windows.Forms.Label();
            dateInscriptionLabel = new System.Windows.Forms.Label();
            numDossardLabel = new System.Windows.Forms.Label();
            numLicenceLabel = new System.Windows.Forms.Label();
            numTriathLabel = new System.Windows.Forms.Label();
            this.grpbxLesControles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindSrcControler)).BeginInit();
            this.grpbxDetailTypeTriath.SuspendLayout();
            this.grpbxLesInscriptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inscriptionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grpbxLesControles
            // 
            this.grpbxLesControles.Controls.Add(this.btAjouterControle);
            this.grpbxLesControles.Controls.Add(this.btSupprimerControle);
            this.grpbxLesControles.Controls.Add(this.gridControle);
            this.grpbxLesControles.Location = new System.Drawing.Point(230, 110);
            this.grpbxLesControles.Margin = new System.Windows.Forms.Padding(2);
            this.grpbxLesControles.Name = "grpbxLesControles";
            this.grpbxLesControles.Padding = new System.Windows.Forms.Padding(2);
            this.grpbxLesControles.Size = new System.Drawing.Size(559, 329);
            this.grpbxLesControles.TabIndex = 15;
            this.grpbxLesControles.TabStop = false;
            this.grpbxLesControles.Text = "Les contrôles";
            // 
            // btAjouterControle
            // 
            this.btAjouterControle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btAjouterControle.Enabled = false;
            this.btAjouterControle.Location = new System.Drawing.Point(130, 261);
            this.btAjouterControle.Margin = new System.Windows.Forms.Padding(2);
            this.btAjouterControle.Name = "btAjouterControle";
            this.btAjouterControle.Size = new System.Drawing.Size(142, 38);
            this.btAjouterControle.TabIndex = 7;
            this.btAjouterControle.Text = "Ajouter un contrôle";
            this.btAjouterControle.UseVisualStyleBackColor = false;
            // 
            // btSupprimerControle
            // 
            this.btSupprimerControle.BackColor = System.Drawing.Color.OrangeRed;
            this.btSupprimerControle.Enabled = false;
            this.btSupprimerControle.Location = new System.Drawing.Point(308, 261);
            this.btSupprimerControle.Margin = new System.Windows.Forms.Padding(2);
            this.btSupprimerControle.Name = "btSupprimerControle";
            this.btSupprimerControle.Size = new System.Drawing.Size(142, 38);
            this.btSupprimerControle.TabIndex = 6;
            this.btSupprimerControle.Text = "Supprimer ce contrôle";
            this.btSupprimerControle.UseVisualStyleBackColor = false;
            // 
            // gridControle
            // 
            this.gridControle.AllowUserToAddRows = false;
            this.gridControle.AllowUserToDeleteRows = false;
            this.gridControle.AutoGenerateColumns = false;
            this.gridControle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridControle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridControle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNumCli,
            this.colNomCli,
            this.colPrenomCLi,
            this.DistanceCyc,
            this.Column1,
            this.Column2,
            this.numTriathDataGridViewTextBoxColumn,
            this.numDossardDataGridViewTextBoxColumn,
            this.codeDopDataGridViewTextBoxColumn,
            this.mesureEtablieDataGridViewTextBoxColumn});
            this.gridControle.DataSource = this.bindSrcControler;
            this.gridControle.Location = new System.Drawing.Point(10, 19);
            this.gridControle.Margin = new System.Windows.Forms.Padding(2);
            this.gridControle.MultiSelect = false;
            this.gridControle.Name = "gridControle";
            this.gridControle.ReadOnly = true;
            this.gridControle.RowHeadersWidth = 51;
            this.gridControle.RowTemplate.Height = 28;
            this.gridControle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridControle.Size = new System.Drawing.Size(549, 224);
            this.gridControle.TabIndex = 0;
            // 
            // colNumCli
            // 
            this.colNumCli.HeaderText = "Code";
            this.colNumCli.MinimumWidth = 6;
            this.colNumCli.Name = "colNumCli";
            this.colNumCli.ReadOnly = true;
            this.colNumCli.Width = 57;
            // 
            // colNomCli
            // 
            this.colNomCli.HeaderText = "Désignation";
            this.colNomCli.MinimumWidth = 6;
            this.colNomCli.Name = "colNomCli";
            this.colNomCli.ReadOnly = true;
            this.colNomCli.Width = 88;
            // 
            // colPrenomCLi
            // 
            this.colPrenomCLi.HeaderText = "Nom";
            this.colPrenomCLi.MinimumWidth = 6;
            this.colPrenomCLi.Name = "colPrenomCLi";
            this.colPrenomCLi.ReadOnly = true;
            this.colPrenomCLi.Width = 54;
            // 
            // DistanceCyc
            // 
            this.DistanceCyc.HeaderText = "DistanceCyc";
            this.DistanceCyc.MinimumWidth = 6;
            this.DistanceCyc.Name = "DistanceCyc";
            this.DistanceCyc.ReadOnly = true;
            this.DistanceCyc.Width = 92;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "DistanceNat";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 91;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "DistanceCourse";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 107;
            // 
            // numTriathDataGridViewTextBoxColumn
            // 
            this.numTriathDataGridViewTextBoxColumn.DataPropertyName = "NumTriath";
            this.numTriathDataGridViewTextBoxColumn.HeaderText = "NumTriath";
            this.numTriathDataGridViewTextBoxColumn.Name = "numTriathDataGridViewTextBoxColumn";
            this.numTriathDataGridViewTextBoxColumn.ReadOnly = true;
            this.numTriathDataGridViewTextBoxColumn.Width = 81;
            // 
            // numDossardDataGridViewTextBoxColumn
            // 
            this.numDossardDataGridViewTextBoxColumn.DataPropertyName = "NumDossard";
            this.numDossardDataGridViewTextBoxColumn.HeaderText = "NumDossard";
            this.numDossardDataGridViewTextBoxColumn.Name = "numDossardDataGridViewTextBoxColumn";
            this.numDossardDataGridViewTextBoxColumn.ReadOnly = true;
            this.numDossardDataGridViewTextBoxColumn.Width = 93;
            // 
            // codeDopDataGridViewTextBoxColumn
            // 
            this.codeDopDataGridViewTextBoxColumn.DataPropertyName = "CodeDop";
            this.codeDopDataGridViewTextBoxColumn.HeaderText = "CodeDop";
            this.codeDopDataGridViewTextBoxColumn.Name = "codeDopDataGridViewTextBoxColumn";
            this.codeDopDataGridViewTextBoxColumn.ReadOnly = true;
            this.codeDopDataGridViewTextBoxColumn.Width = 77;
            // 
            // mesureEtablieDataGridViewTextBoxColumn
            // 
            this.mesureEtablieDataGridViewTextBoxColumn.DataPropertyName = "MesureEtablie";
            this.mesureEtablieDataGridViewTextBoxColumn.HeaderText = "MesureEtablie";
            this.mesureEtablieDataGridViewTextBoxColumn.Name = "mesureEtablieDataGridViewTextBoxColumn";
            this.mesureEtablieDataGridViewTextBoxColumn.ReadOnly = true;
            this.mesureEtablieDataGridViewTextBoxColumn.Width = 99;
            // 
            // bindSrcControler
            // 
            this.bindSrcControler.DataSource = typeof(Projet_Triathlon.Controler);
            // 
            // grpbxDetailTypeTriath
            // 
            this.grpbxDetailTypeTriath.Controls.Add(dateInscriptionLabel);
            this.grpbxDetailTypeTriath.Controls.Add(this.dateInscriptionDateTimePicker);
            this.grpbxDetailTypeTriath.Controls.Add(numDossardLabel);
            this.grpbxDetailTypeTriath.Controls.Add(this.numDossardLabel1);
            this.grpbxDetailTypeTriath.Controls.Add(numLicenceLabel);
            this.grpbxDetailTypeTriath.Controls.Add(this.numLicenceLabel1);
            this.grpbxDetailTypeTriath.Controls.Add(numTriathLabel);
            this.grpbxDetailTypeTriath.Controls.Add(this.numTriathLabel1);
            this.grpbxDetailTypeTriath.Controls.Add(this.btSupprimerTypeTriath);
            this.grpbxDetailTypeTriath.Controls.Add(this.btModifier);
            this.grpbxDetailTypeTriath.Location = new System.Drawing.Point(11, 110);
            this.grpbxDetailTypeTriath.Margin = new System.Windows.Forms.Padding(2);
            this.grpbxDetailTypeTriath.Name = "grpbxDetailTypeTriath";
            this.grpbxDetailTypeTriath.Padding = new System.Windows.Forms.Padding(2);
            this.grpbxDetailTypeTriath.Size = new System.Drawing.Size(343, 336);
            this.grpbxDetailTypeTriath.TabIndex = 14;
            this.grpbxDetailTypeTriath.TabStop = false;
            this.grpbxDetailTypeTriath.Text = "Détail de l\'inscription";
            // 
            // btSupprimerTypeTriath
            // 
            this.btSupprimerTypeTriath.BackColor = System.Drawing.Color.OrangeRed;
            this.btSupprimerTypeTriath.Enabled = false;
            this.btSupprimerTypeTriath.Location = new System.Drawing.Point(94, 289);
            this.btSupprimerTypeTriath.Margin = new System.Windows.Forms.Padding(2);
            this.btSupprimerTypeTriath.Name = "btSupprimerTypeTriath";
            this.btSupprimerTypeTriath.Size = new System.Drawing.Size(82, 27);
            this.btSupprimerTypeTriath.TabIndex = 7;
            this.btSupprimerTypeTriath.Text = "Supprimer";
            this.btSupprimerTypeTriath.UseVisualStyleBackColor = false;
            // 
            // btModifier
            // 
            this.btModifier.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btModifier.Enabled = false;
            this.btModifier.Location = new System.Drawing.Point(12, 289);
            this.btModifier.Margin = new System.Windows.Forms.Padding(2);
            this.btModifier.Name = "btModifier";
            this.btModifier.Size = new System.Drawing.Size(78, 27);
            this.btModifier.TabIndex = 4;
            this.btModifier.Text = "Modifier";
            this.btModifier.UseVisualStyleBackColor = false;
            // 
            // grpbxLesInscriptions
            // 
            this.grpbxLesInscriptions.Controls.Add(this.btNouveau);
            this.grpbxLesInscriptions.Controls.Add(this.comboBxLesTypesTriath);
            this.grpbxLesInscriptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbxLesInscriptions.Location = new System.Drawing.Point(11, 11);
            this.grpbxLesInscriptions.Margin = new System.Windows.Forms.Padding(2);
            this.grpbxLesInscriptions.Name = "grpbxLesInscriptions";
            this.grpbxLesInscriptions.Padding = new System.Windows.Forms.Padding(2);
            this.grpbxLesInscriptions.Size = new System.Drawing.Size(778, 86);
            this.grpbxLesInscriptions.TabIndex = 13;
            this.grpbxLesInscriptions.TabStop = false;
            this.grpbxLesInscriptions.Text = "Selectionner une inscription dans la liste :";
            // 
            // btNouveau
            // 
            this.btNouveau.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btNouveau.Location = new System.Drawing.Point(458, 17);
            this.btNouveau.Margin = new System.Windows.Forms.Padding(2);
            this.btNouveau.Name = "btNouveau";
            this.btNouveau.Size = new System.Drawing.Size(141, 40);
            this.btNouveau.TabIndex = 7;
            this.btNouveau.Text = "Nouvelle inscription";
            this.btNouveau.UseVisualStyleBackColor = false;
            // 
            // comboBxLesTypesTriath
            // 
            this.comboBxLesTypesTriath.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBxLesTypesTriath.FormattingEnabled = true;
            this.comboBxLesTypesTriath.Location = new System.Drawing.Point(43, 31);
            this.comboBxLesTypesTriath.Margin = new System.Windows.Forms.Padding(2);
            this.comboBxLesTypesTriath.Name = "comboBxLesTypesTriath";
            this.comboBxLesTypesTriath.Size = new System.Drawing.Size(375, 21);
            this.comboBxLesTypesTriath.TabIndex = 0;
            // 
            // inscriptionBindingSource
            // 
            this.inscriptionBindingSource.DataSource = typeof(Projet_Triathlon.Inscription);
            // 
            // dateInscriptionLabel
            // 
            dateInscriptionLabel.AutoSize = true;
            dateInscriptionLabel.Location = new System.Drawing.Point(31, 80);
            dateInscriptionLabel.Name = "dateInscriptionLabel";
            dateInscriptionLabel.Size = new System.Drawing.Size(84, 13);
            dateInscriptionLabel.TabIndex = 7;
            dateInscriptionLabel.Text = "Date Inscription:";
            // 
            // dateInscriptionDateTimePicker
            // 
            this.dateInscriptionDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.inscriptionBindingSource, "DateInscription", true));
            this.dateInscriptionDateTimePicker.Enabled = false;
            this.dateInscriptionDateTimePicker.Location = new System.Drawing.Point(123, 76);
            this.dateInscriptionDateTimePicker.Name = "dateInscriptionDateTimePicker";
            this.dateInscriptionDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateInscriptionDateTimePicker.TabIndex = 8;
            // 
            // numDossardLabel
            // 
            numDossardLabel.AutoSize = true;
            numDossardLabel.Location = new System.Drawing.Point(31, 99);
            numDossardLabel.Name = "numDossardLabel";
            numDossardLabel.Size = new System.Drawing.Size(74, 13);
            numDossardLabel.TabIndex = 9;
            numDossardLabel.Text = "Num Dossard:";
            // 
            // numDossardLabel1
            // 
            this.numDossardLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inscriptionBindingSource, "NumDossard", true));
            this.numDossardLabel1.Location = new System.Drawing.Point(123, 99);
            this.numDossardLabel1.Name = "numDossardLabel1";
            this.numDossardLabel1.Size = new System.Drawing.Size(200, 23);
            this.numDossardLabel1.TabIndex = 10;
            this.numDossardLabel1.Text = "label1";
            // 
            // numLicenceLabel
            // 
            numLicenceLabel.AutoSize = true;
            numLicenceLabel.Location = new System.Drawing.Point(31, 122);
            numLicenceLabel.Name = "numLicenceLabel";
            numLicenceLabel.Size = new System.Drawing.Size(73, 13);
            numLicenceLabel.TabIndex = 11;
            numLicenceLabel.Text = "Num Licence:";
            // 
            // numLicenceLabel1
            // 
            this.numLicenceLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inscriptionBindingSource, "NumLicence", true));
            this.numLicenceLabel1.Location = new System.Drawing.Point(123, 122);
            this.numLicenceLabel1.Name = "numLicenceLabel1";
            this.numLicenceLabel1.Size = new System.Drawing.Size(200, 23);
            this.numLicenceLabel1.TabIndex = 12;
            this.numLicenceLabel1.Text = "label1";
            // 
            // numTriathLabel
            // 
            numTriathLabel.AutoSize = true;
            numTriathLabel.Location = new System.Drawing.Point(31, 145);
            numTriathLabel.Name = "numTriathLabel";
            numTriathLabel.Size = new System.Drawing.Size(62, 13);
            numTriathLabel.TabIndex = 13;
            numTriathLabel.Text = "Num Triath:";
            // 
            // numTriathLabel1
            // 
            this.numTriathLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inscriptionBindingSource, "NumTriath", true));
            this.numTriathLabel1.Location = new System.Drawing.Point(123, 145);
            this.numTriathLabel1.Name = "numTriathLabel1";
            this.numTriathLabel1.Size = new System.Drawing.Size(200, 23);
            this.numTriathLabel1.TabIndex = 14;
            this.numTriathLabel1.Text = "label1";
            // 
            // FrmControle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpbxLesControles);
            this.Controls.Add(this.grpbxDetailTypeTriath);
            this.Controls.Add(this.grpbxLesInscriptions);
            this.Name = "FrmControle";
            this.Text = "Gestion des contrôles";
            this.Load += new System.EventHandler(this.FrmControle_Load);
            this.grpbxLesControles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindSrcControler)).EndInit();
            this.grpbxDetailTypeTriath.ResumeLayout(false);
            this.grpbxDetailTypeTriath.PerformLayout();
            this.grpbxLesInscriptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.inscriptionBindingSource)).EndInit();
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
        private System.Windows.Forms.Button btModifier;
        private System.Windows.Forms.GroupBox grpbxLesInscriptions;
        private System.Windows.Forms.Button btNouveau;
        private System.Windows.Forms.ComboBox comboBxLesTypesTriath;
        private System.Windows.Forms.Button btAjouterControle;
        private System.Windows.Forms.DataGridViewTextBoxColumn numTriathDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numDossardDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDopDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mesureEtablieDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bindSrcControler;
        private System.Windows.Forms.DateTimePicker dateInscriptionDateTimePicker;
        private System.Windows.Forms.BindingSource inscriptionBindingSource;
        private System.Windows.Forms.Label numDossardLabel1;
        private System.Windows.Forms.Label numLicenceLabel1;
        private System.Windows.Forms.Label numTriathLabel1;
    }
}