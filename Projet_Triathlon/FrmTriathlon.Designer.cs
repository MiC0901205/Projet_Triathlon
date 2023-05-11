namespace Projet_Triathlon
{
    partial class FrmTriathlon
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
            System.Windows.Forms.Label lblDateCompet;
            System.Windows.Forms.Label lblLieu;
            System.Windows.Forms.Label lblNom;
            System.Windows.Forms.Label lblNumTriath;
            System.Windows.Forms.Label lblTypeTriathlon;
            this.grpbxInscriptions = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btSupprimerInscription = new System.Windows.Forms.Button();
            this.gridInscriptions = new System.Windows.Forms.DataGridView();
            this.numTriathDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numDossardDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numLicenceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateInscriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tempsNatationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tempsCourseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tempsCyclismeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindSrcInscription = new System.Windows.Forms.BindingSource(this.components);
            this.grpbxDetailTriathlon = new System.Windows.Forms.GroupBox();
            this.lblNum = new System.Windows.Forms.Label();
            this.bindSrcTriathlon = new System.Windows.Forms.BindingSource(this.components);
            this.comboBxLesTypesTriathlon = new System.Windows.Forms.ComboBox();
            this.bindSrcTypeTriathlon = new System.Windows.Forms.BindingSource(this.components);
            this.dateCompetDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.txtLieu = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.btSupprimerTriathlon = new System.Windows.Forms.Button();
            this.btModifier = new System.Windows.Forms.Button();
            this.grpbxLesTriathlons = new System.Windows.Forms.GroupBox();
            this.btNouveauTriathlon = new System.Windows.Forms.Button();
            this.comboBxLesTriathlons = new System.Windows.Forms.ComboBox();
            lblDateCompet = new System.Windows.Forms.Label();
            lblLieu = new System.Windows.Forms.Label();
            lblNom = new System.Windows.Forms.Label();
            lblNumTriath = new System.Windows.Forms.Label();
            lblTypeTriathlon = new System.Windows.Forms.Label();
            this.grpbxInscriptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridInscriptions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindSrcInscription)).BeginInit();
            this.grpbxDetailTriathlon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindSrcTriathlon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindSrcTypeTriathlon)).BeginInit();
            this.grpbxLesTriathlons.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDateCompet
            // 
            lblDateCompet.AutoSize = true;
            lblDateCompet.Location = new System.Drawing.Point(16, 82);
            lblDateCompet.Name = "lblDateCompet";
            lblDateCompet.Size = new System.Drawing.Size(72, 13);
            lblDateCompet.TabIndex = 11;
            lblDateCompet.Text = "Date Compet:";
            // 
            // lblLieu
            // 
            lblLieu.AutoSize = true;
            lblLieu.Location = new System.Drawing.Point(16, 120);
            lblLieu.Name = "lblLieu";
            lblLieu.Size = new System.Drawing.Size(30, 13);
            lblLieu.TabIndex = 13;
            lblLieu.Text = "Lieu:";
            // 
            // lblNom
            // 
            lblNom.AutoSize = true;
            lblNom.Location = new System.Drawing.Point(16, 156);
            lblNom.Name = "lblNom";
            lblNom.Size = new System.Drawing.Size(32, 13);
            lblNom.TabIndex = 15;
            lblNom.Text = "Nom:";
            // 
            // lblNumTriath
            // 
            lblNumTriath.AutoSize = true;
            lblNumTriath.Location = new System.Drawing.Point(16, 45);
            lblNumTriath.Name = "lblNumTriath";
            lblNumTriath.Size = new System.Drawing.Size(62, 13);
            lblNumTriath.TabIndex = 17;
            lblNumTriath.Text = "Num Triath:";
            // 
            // lblTypeTriathlon
            // 
            lblTypeTriathlon.AutoSize = true;
            lblTypeTriathlon.Location = new System.Drawing.Point(16, 194);
            lblTypeTriathlon.Name = "lblTypeTriathlon";
            lblTypeTriathlon.Size = new System.Drawing.Size(93, 13);
            lblTypeTriathlon.TabIndex = 18;
            lblTypeTriathlon.Text = "Le Type Triathlon:";
            // 
            // grpbxInscriptions
            // 
            this.grpbxInscriptions.Controls.Add(this.button1);
            this.grpbxInscriptions.Controls.Add(this.btSupprimerInscription);
            this.grpbxInscriptions.Controls.Add(this.gridInscriptions);
            this.grpbxInscriptions.Location = new System.Drawing.Point(279, 92);
            this.grpbxInscriptions.Margin = new System.Windows.Forms.Padding(2);
            this.grpbxInscriptions.Name = "grpbxInscriptions";
            this.grpbxInscriptions.Padding = new System.Windows.Forms.Padding(2);
            this.grpbxInscriptions.Size = new System.Drawing.Size(510, 347);
            this.grpbxInscriptions.TabIndex = 17;
            this.grpbxInscriptions.TabStop = false;
            this.grpbxInscriptions.Text = "Les inscriptions";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(166, 280);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 37);
            this.button1.TabIndex = 8;
            this.button1.Text = "Ajouter";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btSupprimerInscription
            // 
            this.btSupprimerInscription.BackColor = System.Drawing.Color.OrangeRed;
            this.btSupprimerInscription.Enabled = false;
            this.btSupprimerInscription.Location = new System.Drawing.Point(298, 280);
            this.btSupprimerInscription.Margin = new System.Windows.Forms.Padding(2);
            this.btSupprimerInscription.Name = "btSupprimerInscription";
            this.btSupprimerInscription.Size = new System.Drawing.Size(105, 37);
            this.btSupprimerInscription.TabIndex = 6;
            this.btSupprimerInscription.Text = "Supprimer";
            this.btSupprimerInscription.UseVisualStyleBackColor = false;
            // 
            // gridInscriptions
            // 
            this.gridInscriptions.AllowUserToAddRows = false;
            this.gridInscriptions.AllowUserToDeleteRows = false;
            this.gridInscriptions.AutoGenerateColumns = false;
            this.gridInscriptions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridInscriptions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridInscriptions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numTriathDataGridViewTextBoxColumn,
            this.numDossardDataGridViewTextBoxColumn,
            this.numLicenceDataGridViewTextBoxColumn,
            this.dateInscriptionDataGridViewTextBoxColumn,
            this.tempsNatationDataGridViewTextBoxColumn,
            this.tempsCourseDataGridViewTextBoxColumn,
            this.tempsCyclismeDataGridViewTextBoxColumn});
            this.gridInscriptions.DataSource = this.bindSrcInscription;
            this.gridInscriptions.Location = new System.Drawing.Point(10, 19);
            this.gridInscriptions.Margin = new System.Windows.Forms.Padding(2);
            this.gridInscriptions.MultiSelect = false;
            this.gridInscriptions.Name = "gridInscriptions";
            this.gridInscriptions.ReadOnly = true;
            this.gridInscriptions.RowHeadersWidth = 51;
            this.gridInscriptions.RowTemplate.Height = 28;
            this.gridInscriptions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridInscriptions.Size = new System.Drawing.Size(496, 244);
            this.gridInscriptions.TabIndex = 0;
            this.gridInscriptions.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridInscriptions_CellContentDoubleClick);
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
            // numLicenceDataGridViewTextBoxColumn
            // 
            this.numLicenceDataGridViewTextBoxColumn.DataPropertyName = "NumLicence";
            this.numLicenceDataGridViewTextBoxColumn.HeaderText = "NumLicence";
            this.numLicenceDataGridViewTextBoxColumn.Name = "numLicenceDataGridViewTextBoxColumn";
            this.numLicenceDataGridViewTextBoxColumn.ReadOnly = true;
            this.numLicenceDataGridViewTextBoxColumn.Width = 92;
            // 
            // dateInscriptionDataGridViewTextBoxColumn
            // 
            this.dateInscriptionDataGridViewTextBoxColumn.DataPropertyName = "DateInscription";
            this.dateInscriptionDataGridViewTextBoxColumn.HeaderText = "DateInscription";
            this.dateInscriptionDataGridViewTextBoxColumn.Name = "dateInscriptionDataGridViewTextBoxColumn";
            this.dateInscriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateInscriptionDataGridViewTextBoxColumn.Width = 103;
            // 
            // tempsNatationDataGridViewTextBoxColumn
            // 
            this.tempsNatationDataGridViewTextBoxColumn.DataPropertyName = "TempsNatation";
            this.tempsNatationDataGridViewTextBoxColumn.HeaderText = "TempsNatation";
            this.tempsNatationDataGridViewTextBoxColumn.Name = "tempsNatationDataGridViewTextBoxColumn";
            this.tempsNatationDataGridViewTextBoxColumn.ReadOnly = true;
            this.tempsNatationDataGridViewTextBoxColumn.Width = 104;
            // 
            // tempsCourseDataGridViewTextBoxColumn
            // 
            this.tempsCourseDataGridViewTextBoxColumn.DataPropertyName = "TempsCourse";
            this.tempsCourseDataGridViewTextBoxColumn.HeaderText = "TempsCourse";
            this.tempsCourseDataGridViewTextBoxColumn.Name = "tempsCourseDataGridViewTextBoxColumn";
            this.tempsCourseDataGridViewTextBoxColumn.ReadOnly = true;
            this.tempsCourseDataGridViewTextBoxColumn.Width = 97;
            // 
            // tempsCyclismeDataGridViewTextBoxColumn
            // 
            this.tempsCyclismeDataGridViewTextBoxColumn.DataPropertyName = "TempsCyclisme";
            this.tempsCyclismeDataGridViewTextBoxColumn.HeaderText = "TempsCyclisme";
            this.tempsCyclismeDataGridViewTextBoxColumn.Name = "tempsCyclismeDataGridViewTextBoxColumn";
            this.tempsCyclismeDataGridViewTextBoxColumn.ReadOnly = true;
            this.tempsCyclismeDataGridViewTextBoxColumn.Width = 105;
            // 
            // bindSrcInscription
            // 
            this.bindSrcInscription.DataSource = typeof(Projet_Triathlon.Inscription);
            // 
            // grpbxDetailTriathlon
            // 
            this.grpbxDetailTriathlon.Controls.Add(this.lblNum);
            this.grpbxDetailTriathlon.Controls.Add(lblTypeTriathlon);
            this.grpbxDetailTriathlon.Controls.Add(this.comboBxLesTypesTriathlon);
            this.grpbxDetailTriathlon.Controls.Add(lblDateCompet);
            this.grpbxDetailTriathlon.Controls.Add(this.dateCompetDateTimePicker);
            this.grpbxDetailTriathlon.Controls.Add(lblLieu);
            this.grpbxDetailTriathlon.Controls.Add(this.txtLieu);
            this.grpbxDetailTriathlon.Controls.Add(lblNom);
            this.grpbxDetailTriathlon.Controls.Add(this.txtNom);
            this.grpbxDetailTriathlon.Controls.Add(lblNumTriath);
            this.grpbxDetailTriathlon.Controls.Add(this.btSupprimerTriathlon);
            this.grpbxDetailTriathlon.Controls.Add(this.btModifier);
            this.grpbxDetailTriathlon.Location = new System.Drawing.Point(11, 92);
            this.grpbxDetailTriathlon.Margin = new System.Windows.Forms.Padding(2);
            this.grpbxDetailTriathlon.Name = "grpbxDetailTriathlon";
            this.grpbxDetailTriathlon.Padding = new System.Windows.Forms.Padding(2);
            this.grpbxDetailTriathlon.Size = new System.Drawing.Size(274, 347);
            this.grpbxDetailTriathlon.TabIndex = 16;
            this.grpbxDetailTriathlon.TabStop = false;
            this.grpbxDetailTriathlon.Text = "Détail du triathlon";
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindSrcTriathlon, "NumTriath", true));
            this.lblNum.Location = new System.Drawing.Point(91, 45);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(35, 13);
            this.lblNum.TabIndex = 20;
            this.lblNum.Text = "label1";
            // 
            // bindSrcTriathlon
            // 
            this.bindSrcTriathlon.DataSource = typeof(Projet_Triathlon.Triathlon);
            this.bindSrcTriathlon.CurrentChanged += new System.EventHandler(this.bindSrcTriathlon_CurrentChanged);
            // 
            // comboBxLesTypesTriathlon
            // 
            this.comboBxLesTypesTriathlon.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.bindSrcTriathlon, "UnTypeTriathlon", true));
            this.comboBxLesTypesTriathlon.DataSource = this.bindSrcTypeTriathlon;
            this.comboBxLesTypesTriathlon.DisplayMember = "Nom";
            this.comboBxLesTypesTriathlon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBxLesTypesTriathlon.FormattingEnabled = true;
            this.comboBxLesTypesTriathlon.Location = new System.Drawing.Point(117, 191);
            this.comboBxLesTypesTriathlon.Name = "comboBxLesTypesTriathlon";
            this.comboBxLesTypesTriathlon.Size = new System.Drawing.Size(146, 21);
            this.comboBxLesTypesTriathlon.TabIndex = 19;
            this.comboBxLesTypesTriathlon.ValueMember = "CodeTypeT";
            // 
            // bindSrcTypeTriathlon
            // 
            this.bindSrcTypeTriathlon.DataSource = typeof(Projet_Triathlon.TypeTriathlon);
            // 
            // dateCompetDateTimePicker
            // 
            this.dateCompetDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bindSrcTriathlon, "DateCompet", true));
            this.dateCompetDateTimePicker.Location = new System.Drawing.Point(94, 78);
            this.dateCompetDateTimePicker.Name = "dateCompetDateTimePicker";
            this.dateCompetDateTimePicker.Size = new System.Drawing.Size(169, 20);
            this.dateCompetDateTimePicker.TabIndex = 12;
            // 
            // txtLieu
            // 
            this.txtLieu.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindSrcTriathlon, "Lieu", true));
            this.txtLieu.Location = new System.Drawing.Point(94, 115);
            this.txtLieu.Name = "txtLieu";
            this.txtLieu.Size = new System.Drawing.Size(144, 20);
            this.txtLieu.TabIndex = 14;
            // 
            // txtNom
            // 
            this.txtNom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindSrcTriathlon, "Nom", true));
            this.txtNom.Location = new System.Drawing.Point(94, 150);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(144, 20);
            this.txtNom.TabIndex = 16;
            // 
            // btSupprimerTriathlon
            // 
            this.btSupprimerTriathlon.BackColor = System.Drawing.Color.OrangeRed;
            this.btSupprimerTriathlon.Enabled = false;
            this.btSupprimerTriathlon.Location = new System.Drawing.Point(117, 255);
            this.btSupprimerTriathlon.Margin = new System.Windows.Forms.Padding(2);
            this.btSupprimerTriathlon.Name = "btSupprimerTriathlon";
            this.btSupprimerTriathlon.Size = new System.Drawing.Size(84, 27);
            this.btSupprimerTriathlon.TabIndex = 11;
            this.btSupprimerTriathlon.Text = "Supprimer";
            this.btSupprimerTriathlon.UseVisualStyleBackColor = false;
            // 
            // btModifier
            // 
            this.btModifier.BackColor = System.Drawing.Color.Silver;
            this.btModifier.Enabled = false;
            this.btModifier.Location = new System.Drawing.Point(19, 255);
            this.btModifier.Margin = new System.Windows.Forms.Padding(2);
            this.btModifier.Name = "btModifier";
            this.btModifier.Size = new System.Drawing.Size(78, 27);
            this.btModifier.TabIndex = 4;
            this.btModifier.Text = "Modifier";
            this.btModifier.UseVisualStyleBackColor = false;
            // 
            // grpbxLesTriathlons
            // 
            this.grpbxLesTriathlons.Controls.Add(this.btNouveauTriathlon);
            this.grpbxLesTriathlons.Controls.Add(this.comboBxLesTriathlons);
            this.grpbxLesTriathlons.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbxLesTriathlons.Location = new System.Drawing.Point(11, 11);
            this.grpbxLesTriathlons.Margin = new System.Windows.Forms.Padding(2);
            this.grpbxLesTriathlons.Name = "grpbxLesTriathlons";
            this.grpbxLesTriathlons.Padding = new System.Windows.Forms.Padding(2);
            this.grpbxLesTriathlons.Size = new System.Drawing.Size(778, 77);
            this.grpbxLesTriathlons.TabIndex = 15;
            this.grpbxLesTriathlons.TabStop = false;
            this.grpbxLesTriathlons.Text = "Selectionner un triathlon dans la liste :";
            // 
            // btNouveauTriathlon
            // 
            this.btNouveauTriathlon.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btNouveauTriathlon.Location = new System.Drawing.Point(458, 23);
            this.btNouveauTriathlon.Margin = new System.Windows.Forms.Padding(2);
            this.btNouveauTriathlon.Name = "btNouveauTriathlon";
            this.btNouveauTriathlon.Size = new System.Drawing.Size(129, 33);
            this.btNouveauTriathlon.TabIndex = 7;
            this.btNouveauTriathlon.Text = "Nouveau triathlon";
            this.btNouveauTriathlon.UseVisualStyleBackColor = false;
            // 
            // comboBxLesTriathlons
            // 
            this.comboBxLesTriathlons.DataSource = this.bindSrcTriathlon;
            this.comboBxLesTriathlons.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBxLesTriathlons.FormattingEnabled = true;
            this.comboBxLesTriathlons.Location = new System.Drawing.Point(43, 31);
            this.comboBxLesTriathlons.Margin = new System.Windows.Forms.Padding(2);
            this.comboBxLesTriathlons.Name = "comboBxLesTriathlons";
            this.comboBxLesTriathlons.Size = new System.Drawing.Size(375, 21);
            this.comboBxLesTriathlons.TabIndex = 0;
            // 
            // FrmTriathlon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 486);
            this.Controls.Add(this.grpbxInscriptions);
            this.Controls.Add(this.grpbxDetailTriathlon);
            this.Controls.Add(this.grpbxLesTriathlons);
            this.Name = "FrmTriathlon";
            this.Text = "Gestion des triathlons";
            this.Load += new System.EventHandler(this.FrmTriathlon_Load);
            this.grpbxInscriptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridInscriptions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindSrcInscription)).EndInit();
            this.grpbxDetailTriathlon.ResumeLayout(false);
            this.grpbxDetailTriathlon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindSrcTriathlon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindSrcTypeTriathlon)).EndInit();
            this.grpbxLesTriathlons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbxInscriptions;
        private System.Windows.Forms.Button btSupprimerInscription;
        private System.Windows.Forms.DataGridView gridInscriptions;
        private System.Windows.Forms.GroupBox grpbxDetailTriathlon;
        private System.Windows.Forms.Button btModifier;
        private System.Windows.Forms.GroupBox grpbxLesTriathlons;
        private System.Windows.Forms.Button btNouveauTriathlon;
        private System.Windows.Forms.ComboBox comboBxLesTriathlons;
        private System.Windows.Forms.Button btSupprimerTriathlon;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource bindSrcTriathlon;
        private System.Windows.Forms.DataGridViewTextBoxColumn numTriathDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numDossardDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numLicenceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateInscriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tempsNatationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tempsCourseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tempsCyclismeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bindSrcInscription;
        private System.Windows.Forms.ComboBox comboBxLesTypesTriathlon;
        private System.Windows.Forms.DateTimePicker dateCompetDateTimePicker;
        private System.Windows.Forms.TextBox txtLieu;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.BindingSource bindSrcTypeTriathlon;
        private System.Windows.Forms.Label lblNum;
    }
}