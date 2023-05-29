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
            System.Windows.Forms.Label lblDateInscription;
            System.Windows.Forms.Label lblNumDossard;
            System.Windows.Forms.Label lblNumLicence;
            System.Windows.Forms.Label lblNumTriath;
            System.Windows.Forms.Label lblTempsCourse;
            System.Windows.Forms.Label lblTempsCyclisme;
            System.Windows.Forms.Label lblTempsNatation;
            this.grpbxLesControles = new System.Windows.Forms.GroupBox();
            this.controlerDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindSrcControler = new System.Windows.Forms.BindingSource(this.components);
            this.btAjouterControle = new System.Windows.Forms.Button();
            this.btSupprimerControle = new System.Windows.Forms.Button();
            this.grpbxDetailTypeTriath = new System.Windows.Forms.GroupBox();
            this.dateTimePickerDateInscription = new System.Windows.Forms.DateTimePicker();
            this.bindSrcInscription = new System.Windows.Forms.BindingSource(this.components);
            this.lblNumDoss = new System.Windows.Forms.Label();
            this.lblNumLic = new System.Windows.Forms.Label();
            this.lblNumT = new System.Windows.Forms.Label();
            this.lblTempsCo = new System.Windows.Forms.Label();
            this.lblTempsCy = new System.Windows.Forms.Label();
            this.lblTempsNat = new System.Windows.Forms.Label();
            this.btSupprimer = new System.Windows.Forms.Button();
            this.grpbxLesInscriptions = new System.Windows.Forms.GroupBox();
            this.btNouveau = new System.Windows.Forms.Button();
            this.comboBxLesInscriptions = new System.Windows.Forms.ComboBox();
            lblDateInscription = new System.Windows.Forms.Label();
            lblNumDossard = new System.Windows.Forms.Label();
            lblNumLicence = new System.Windows.Forms.Label();
            lblNumTriath = new System.Windows.Forms.Label();
            lblTempsCourse = new System.Windows.Forms.Label();
            lblTempsCyclisme = new System.Windows.Forms.Label();
            lblTempsNatation = new System.Windows.Forms.Label();
            this.grpbxLesControles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.controlerDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindSrcControler)).BeginInit();
            this.grpbxDetailTypeTriath.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindSrcInscription)).BeginInit();
            this.grpbxLesInscriptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDateInscription
            // 
            lblDateInscription.AutoSize = true;
            lblDateInscription.Location = new System.Drawing.Point(7, 141);
            lblDateInscription.Name = "lblDateInscription";
            lblDateInscription.Size = new System.Drawing.Size(84, 13);
            lblDateInscription.TabIndex = 7;
            lblDateInscription.Text = "Date Inscription:";
            // 
            // lblNumDossard
            // 
            lblNumDossard.AutoSize = true;
            lblNumDossard.Location = new System.Drawing.Point(9, 53);
            lblNumDossard.Name = "lblNumDossard";
            lblNumDossard.Size = new System.Drawing.Size(74, 13);
            lblNumDossard.TabIndex = 11;
            lblNumDossard.Text = "Num Dossard:";
            // 
            // lblNumLicence
            // 
            lblNumLicence.AutoSize = true;
            lblNumLicence.Location = new System.Drawing.Point(8, 82);
            lblNumLicence.Name = "lblNumLicence";
            lblNumLicence.Size = new System.Drawing.Size(73, 13);
            lblNumLicence.TabIndex = 13;
            lblNumLicence.Text = "Num Licence:";
            // 
            // lblNumTriath
            // 
            lblNumTriath.AutoSize = true;
            lblNumTriath.Location = new System.Drawing.Point(9, 111);
            lblNumTriath.Name = "lblNumTriath";
            lblNumTriath.Size = new System.Drawing.Size(62, 13);
            lblNumTriath.TabIndex = 15;
            lblNumTriath.Text = "Num Triath:";
            // 
            // lblTempsCourse
            // 
            lblTempsCourse.AutoSize = true;
            lblTempsCourse.Location = new System.Drawing.Point(6, 169);
            lblTempsCourse.Name = "lblTempsCourse";
            lblTempsCourse.Size = new System.Drawing.Size(78, 13);
            lblTempsCourse.TabIndex = 19;
            lblTempsCourse.Text = "Temps Course:";
            // 
            // lblTempsCyclisme
            // 
            lblTempsCyclisme.AutoSize = true;
            lblTempsCyclisme.Location = new System.Drawing.Point(6, 197);
            lblTempsCyclisme.Name = "lblTempsCyclisme";
            lblTempsCyclisme.Size = new System.Drawing.Size(86, 13);
            lblTempsCyclisme.TabIndex = 21;
            lblTempsCyclisme.Text = "Temps Cyclisme:";
            // 
            // lblTempsNatation
            // 
            lblTempsNatation.AutoSize = true;
            lblTempsNatation.Location = new System.Drawing.Point(6, 223);
            lblTempsNatation.Name = "lblTempsNatation";
            lblTempsNatation.Size = new System.Drawing.Size(85, 13);
            lblTempsNatation.TabIndex = 23;
            lblTempsNatation.Text = "Temps Natation:";
            // 
            // grpbxLesControles
            // 
            this.grpbxLesControles.Controls.Add(this.controlerDataGridView);
            this.grpbxLesControles.Controls.Add(this.btAjouterControle);
            this.grpbxLesControles.Controls.Add(this.btSupprimerControle);
            this.grpbxLesControles.Location = new System.Drawing.Point(230, 110);
            this.grpbxLesControles.Margin = new System.Windows.Forms.Padding(2);
            this.grpbxLesControles.Name = "grpbxLesControles";
            this.grpbxLesControles.Padding = new System.Windows.Forms.Padding(2);
            this.grpbxLesControles.Size = new System.Drawing.Size(559, 336);
            this.grpbxLesControles.TabIndex = 15;
            this.grpbxLesControles.TabStop = false;
            this.grpbxLesControles.Text = "Les contrôles";
            // 
            // controlerDataGridView
            // 
            this.controlerDataGridView.AllowUserToAddRows = false;
            this.controlerDataGridView.AllowUserToDeleteRows = false;
            this.controlerDataGridView.AutoGenerateColumns = false;
            this.controlerDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.controlerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.controlerDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.controlerDataGridView.DataSource = this.bindSrcControler;
            this.controlerDataGridView.Location = new System.Drawing.Point(5, 18);
            this.controlerDataGridView.Name = "controlerDataGridView";
            this.controlerDataGridView.ReadOnly = true;
            this.controlerDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.controlerDataGridView.Size = new System.Drawing.Size(549, 257);
            this.controlerDataGridView.TabIndex = 7;
            this.controlerDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.controlerDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "NumTriath";
            this.dataGridViewTextBoxColumn1.HeaderText = "NumTriath";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 81;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NumDossard";
            this.dataGridViewTextBoxColumn2.HeaderText = "NumDossard";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 93;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "CodeDop";
            this.dataGridViewTextBoxColumn3.HeaderText = "CodeDop";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 77;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "MesureEtablie";
            this.dataGridViewTextBoxColumn4.HeaderText = "MesureEtablie";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 99;
            // 
            // bindSrcControler
            // 
            this.bindSrcControler.DataSource = typeof(Projet_Triathlon.Controler);
            // 
            // btAjouterControle
            // 
            this.btAjouterControle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btAjouterControle.Enabled = false;
            this.btAjouterControle.Location = new System.Drawing.Point(130, 279);
            this.btAjouterControle.Margin = new System.Windows.Forms.Padding(2);
            this.btAjouterControle.Name = "btAjouterControle";
            this.btAjouterControle.Size = new System.Drawing.Size(142, 38);
            this.btAjouterControle.TabIndex = 7;
            this.btAjouterControle.Text = "Ajouter un contrôle";
            this.btAjouterControle.UseVisualStyleBackColor = false;
            this.btAjouterControle.Click += new System.EventHandler(this.btAjouterControle_Click);
            // 
            // btSupprimerControle
            // 
            this.btSupprimerControle.BackColor = System.Drawing.Color.OrangeRed;
            this.btSupprimerControle.Enabled = false;
            this.btSupprimerControle.Location = new System.Drawing.Point(308, 280);
            this.btSupprimerControle.Margin = new System.Windows.Forms.Padding(2);
            this.btSupprimerControle.Name = "btSupprimerControle";
            this.btSupprimerControle.Size = new System.Drawing.Size(142, 38);
            this.btSupprimerControle.TabIndex = 6;
            this.btSupprimerControle.Text = "Supprimer ce contrôle";
            this.btSupprimerControle.UseVisualStyleBackColor = false;
            this.btSupprimerControle.Click += new System.EventHandler(this.btSupprimerControle_Click);
            // 
            // grpbxDetailTypeTriath
            // 
            this.grpbxDetailTypeTriath.Controls.Add(lblDateInscription);
            this.grpbxDetailTypeTriath.Controls.Add(this.dateTimePickerDateInscription);
            this.grpbxDetailTypeTriath.Controls.Add(lblNumDossard);
            this.grpbxDetailTypeTriath.Controls.Add(this.lblNumDoss);
            this.grpbxDetailTypeTriath.Controls.Add(lblNumLicence);
            this.grpbxDetailTypeTriath.Controls.Add(this.lblNumLic);
            this.grpbxDetailTypeTriath.Controls.Add(lblNumTriath);
            this.grpbxDetailTypeTriath.Controls.Add(this.lblNumT);
            this.grpbxDetailTypeTriath.Controls.Add(lblTempsCourse);
            this.grpbxDetailTypeTriath.Controls.Add(this.lblTempsCo);
            this.grpbxDetailTypeTriath.Controls.Add(lblTempsCyclisme);
            this.grpbxDetailTypeTriath.Controls.Add(this.lblTempsCy);
            this.grpbxDetailTypeTriath.Controls.Add(lblTempsNatation);
            this.grpbxDetailTypeTriath.Controls.Add(this.lblTempsNat);
            this.grpbxDetailTypeTriath.Controls.Add(this.btSupprimer);
            this.grpbxDetailTypeTriath.Location = new System.Drawing.Point(11, 110);
            this.grpbxDetailTypeTriath.Margin = new System.Windows.Forms.Padding(2);
            this.grpbxDetailTypeTriath.Name = "grpbxDetailTypeTriath";
            this.grpbxDetailTypeTriath.Padding = new System.Windows.Forms.Padding(2);
            this.grpbxDetailTypeTriath.Size = new System.Drawing.Size(215, 336);
            this.grpbxDetailTypeTriath.TabIndex = 14;
            this.grpbxDetailTypeTriath.TabStop = false;
            this.grpbxDetailTypeTriath.Text = "Détail de l\'inscription";
            // 
            // dateTimePickerDateInscription
            // 
            this.dateTimePickerDateInscription.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bindSrcInscription, "DateInscription", true));
            this.dateTimePickerDateInscription.Enabled = false;
            this.dateTimePickerDateInscription.Location = new System.Drawing.Point(91, 138);
            this.dateTimePickerDateInscription.Name = "dateTimePickerDateInscription";
            this.dateTimePickerDateInscription.Size = new System.Drawing.Size(120, 20);
            this.dateTimePickerDateInscription.TabIndex = 8;
            // 
            // bindSrcInscription
            // 
            this.bindSrcInscription.DataSource = typeof(Projet_Triathlon.Inscription);
            this.bindSrcInscription.CurrentChanged += new System.EventHandler(this.bindSrcInscription_CurrentChanged);
            // 
            // lblNumDoss
            // 
            this.lblNumDoss.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindSrcInscription, "NumDossard", true));
            this.lblNumDoss.Location = new System.Drawing.Point(102, 54);
            this.lblNumDoss.Name = "lblNumDoss";
            this.lblNumDoss.Size = new System.Drawing.Size(57, 13);
            this.lblNumDoss.TabIndex = 12;
            this.lblNumDoss.Text = "label1";
            // 
            // lblNumLic
            // 
            this.lblNumLic.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindSrcInscription, "NumLicence", true));
            this.lblNumLic.Location = new System.Drawing.Point(102, 84);
            this.lblNumLic.Name = "lblNumLic";
            this.lblNumLic.Size = new System.Drawing.Size(40, 13);
            this.lblNumLic.TabIndex = 14;
            this.lblNumLic.Text = "label1";
            // 
            // lblNumT
            // 
            this.lblNumT.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindSrcInscription, "NumTriath", true));
            this.lblNumT.Location = new System.Drawing.Point(101, 111);
            this.lblNumT.Name = "lblNumT";
            this.lblNumT.Size = new System.Drawing.Size(40, 15);
            this.lblNumT.TabIndex = 16;
            this.lblNumT.Text = "label1";
            // 
            // lblTempsCo
            // 
            this.lblTempsCo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindSrcInscription, "TempsCourse", true));
            this.lblTempsCo.Location = new System.Drawing.Point(100, 169);
            this.lblTempsCo.Name = "lblTempsCo";
            this.lblTempsCo.Size = new System.Drawing.Size(48, 24);
            this.lblTempsCo.TabIndex = 20;
            this.lblTempsCo.Text = "label1";
            // 
            // lblTempsCy
            // 
            this.lblTempsCy.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindSrcInscription, "TempsCyclisme", true));
            this.lblTempsCy.Location = new System.Drawing.Point(100, 197);
            this.lblTempsCy.Name = "lblTempsCy";
            this.lblTempsCy.Size = new System.Drawing.Size(48, 13);
            this.lblTempsCy.TabIndex = 22;
            this.lblTempsCy.Text = "label1";
            // 
            // lblTempsNat
            // 
            this.lblTempsNat.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindSrcInscription, "TempsNatation", true));
            this.lblTempsNat.Location = new System.Drawing.Point(100, 223);
            this.lblTempsNat.Name = "lblTempsNat";
            this.lblTempsNat.Size = new System.Drawing.Size(39, 20);
            this.lblTempsNat.TabIndex = 24;
            this.lblTempsNat.Text = "label1";
            // 
            // btSupprimer
            // 
            this.btSupprimer.BackColor = System.Drawing.Color.OrangeRed;
            this.btSupprimer.Enabled = false;
            this.btSupprimer.Location = new System.Drawing.Point(45, 269);
            this.btSupprimer.Margin = new System.Windows.Forms.Padding(2);
            this.btSupprimer.Name = "btSupprimer";
            this.btSupprimer.Size = new System.Drawing.Size(82, 27);
            this.btSupprimer.TabIndex = 7;
            this.btSupprimer.Text = "Supprimer";
            this.btSupprimer.UseVisualStyleBackColor = false;
            this.btSupprimer.Click += new System.EventHandler(this.btSupprimer_Click);
            // 
            // grpbxLesInscriptions
            // 
            this.grpbxLesInscriptions.Controls.Add(this.btNouveau);
            this.grpbxLesInscriptions.Controls.Add(this.comboBxLesInscriptions);
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
            this.btNouveau.Click += new System.EventHandler(this.btNouveau_Click);
            // 
            // comboBxLesInscriptions
            // 
            this.comboBxLesInscriptions.DataSource = this.bindSrcInscription;
            this.comboBxLesInscriptions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBxLesInscriptions.FormattingEnabled = true;
            this.comboBxLesInscriptions.Location = new System.Drawing.Point(43, 31);
            this.comboBxLesInscriptions.Margin = new System.Windows.Forms.Padding(2);
            this.comboBxLesInscriptions.Name = "comboBxLesInscriptions";
            this.comboBxLesInscriptions.Size = new System.Drawing.Size(375, 21);
            this.comboBxLesInscriptions.TabIndex = 0;
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
            ((System.ComponentModel.ISupportInitialize)(this.controlerDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindSrcControler)).EndInit();
            this.grpbxDetailTypeTriath.ResumeLayout(false);
            this.grpbxDetailTypeTriath.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindSrcInscription)).EndInit();
            this.grpbxLesInscriptions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbxLesControles;
        private System.Windows.Forms.Button btSupprimerControle;
        private System.Windows.Forms.GroupBox grpbxDetailTypeTriath;
        private System.Windows.Forms.Button btSupprimer;
        private System.Windows.Forms.GroupBox grpbxLesInscriptions;
        private System.Windows.Forms.Button btNouveau;
        private System.Windows.Forms.ComboBox comboBxLesInscriptions;
        private System.Windows.Forms.Button btAjouterControle;
        private System.Windows.Forms.BindingSource bindSrcInscription;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateInscription;
        private System.Windows.Forms.Label lblNumDoss;
        private System.Windows.Forms.Label lblNumLic;
        private System.Windows.Forms.Label lblNumT;
        private System.Windows.Forms.Label lblTempsCo;
        private System.Windows.Forms.Label lblTempsCy;
        private System.Windows.Forms.Label lblTempsNat;
        private System.Windows.Forms.DataGridView controlerDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.BindingSource bindSrcControler;
    }
}