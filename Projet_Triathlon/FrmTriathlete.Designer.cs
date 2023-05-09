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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label lblAdresse;
            System.Windows.Forms.Label lblCp;
            System.Windows.Forms.Label lblDateNaissance;
            System.Windows.Forms.Label lblNom;
            System.Windows.Forms.Label lblPrenom;
            System.Windows.Forms.Label lblVille;
            System.Windows.Forms.Label lblNumDossard;
            System.Windows.Forms.Label lblNumLicence;
            this.tabControlTriathlete = new System.Windows.Forms.TabControl();
            this.tabPageListe = new System.Windows.Forms.TabPage();
            this.tabPageDetail = new System.Windows.Forms.TabPage();
            this.btSupprimer = new System.Windows.Forms.Button();
            this.btAnnuler = new System.Windows.Forms.Button();
            this.btEnregistrer = new System.Windows.Forms.Button();
            this.btAjouter = new System.Windows.Forms.Button();
            this.triathleteDataGridView = new System.Windows.Forms.DataGridView();
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.txtCp = new System.Windows.Forms.TextBox();
            this.DateTimePickerDateNaissance = new System.Windows.Forms.DateTimePicker();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtVille = new System.Windows.Forms.TextBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindSrcTriathlete = new System.Windows.Forms.BindingSource(this.components);
            this.txtNumDossard = new System.Windows.Forms.TextBox();
            this.txtNumLicence = new System.Windows.Forms.TextBox();
            lblAdresse = new System.Windows.Forms.Label();
            lblCp = new System.Windows.Forms.Label();
            lblDateNaissance = new System.Windows.Forms.Label();
            lblNom = new System.Windows.Forms.Label();
            lblPrenom = new System.Windows.Forms.Label();
            lblVille = new System.Windows.Forms.Label();
            lblNumDossard = new System.Windows.Forms.Label();
            lblNumLicence = new System.Windows.Forms.Label();
            this.tabControlTriathlete.SuspendLayout();
            this.tabPageListe.SuspendLayout();
            this.tabPageDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.triathleteDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindSrcTriathlete)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlTriathlete
            // 
            this.tabControlTriathlete.Controls.Add(this.tabPageListe);
            this.tabControlTriathlete.Controls.Add(this.tabPageDetail);
            this.tabControlTriathlete.Location = new System.Drawing.Point(1, 13);
            this.tabControlTriathlete.Margin = new System.Windows.Forms.Padding(4);
            this.tabControlTriathlete.Name = "tabControlTriathlete";
            this.tabControlTriathlete.SelectedIndex = 0;
            this.tabControlTriathlete.Size = new System.Drawing.Size(1064, 473);
            this.tabControlTriathlete.TabIndex = 3;
            // 
            // tabPageListe
            // 
            this.tabPageListe.Controls.Add(this.triathleteDataGridView);
            this.tabPageListe.Location = new System.Drawing.Point(4, 25);
            this.tabPageListe.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageListe.Name = "tabPageListe";
            this.tabPageListe.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageListe.Size = new System.Drawing.Size(1056, 444);
            this.tabPageListe.TabIndex = 0;
            this.tabPageListe.Text = "Liste des triathlètes";
            this.tabPageListe.UseVisualStyleBackColor = true;
            // 
            // tabPageDetail
            // 
            this.tabPageDetail.AutoScroll = true;
            this.tabPageDetail.Controls.Add(lblNumDossard);
            this.tabPageDetail.Controls.Add(this.txtNumDossard);
            this.tabPageDetail.Controls.Add(lblNumLicence);
            this.tabPageDetail.Controls.Add(this.txtNumLicence);
            this.tabPageDetail.Controls.Add(lblAdresse);
            this.tabPageDetail.Controls.Add(this.txtAdresse);
            this.tabPageDetail.Controls.Add(lblCp);
            this.tabPageDetail.Controls.Add(this.txtCp);
            this.tabPageDetail.Controls.Add(lblDateNaissance);
            this.tabPageDetail.Controls.Add(this.DateTimePickerDateNaissance);
            this.tabPageDetail.Controls.Add(lblNom);
            this.tabPageDetail.Controls.Add(this.txtNom);
            this.tabPageDetail.Controls.Add(lblPrenom);
            this.tabPageDetail.Controls.Add(this.txtPrenom);
            this.tabPageDetail.Controls.Add(lblVille);
            this.tabPageDetail.Controls.Add(this.txtVille);
            this.tabPageDetail.Controls.Add(this.btSupprimer);
            this.tabPageDetail.Controls.Add(this.btAnnuler);
            this.tabPageDetail.Controls.Add(this.btEnregistrer);
            this.tabPageDetail.Location = new System.Drawing.Point(4, 25);
            this.tabPageDetail.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageDetail.Name = "tabPageDetail";
            this.tabPageDetail.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageDetail.Size = new System.Drawing.Size(1056, 444);
            this.tabPageDetail.TabIndex = 1;
            this.tabPageDetail.Text = "Détail d\'un triathlète";
            this.tabPageDetail.UseVisualStyleBackColor = true;
            // 
            // btSupprimer
            // 
            this.btSupprimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btSupprimer.Location = new System.Drawing.Point(605, 399);
            this.btSupprimer.Margin = new System.Windows.Forms.Padding(4);
            this.btSupprimer.Name = "btSupprimer";
            this.btSupprimer.Size = new System.Drawing.Size(237, 37);
            this.btSupprimer.TabIndex = 10;
            this.btSupprimer.Text = "Supprimer ce triathlète";
            this.btSupprimer.UseVisualStyleBackColor = false;
            // 
            // btAnnuler
            // 
            this.btAnnuler.Location = new System.Drawing.Point(352, 359);
            this.btAnnuler.Margin = new System.Windows.Forms.Padding(4);
            this.btAnnuler.Name = "btAnnuler";
            this.btAnnuler.Size = new System.Drawing.Size(100, 28);
            this.btAnnuler.TabIndex = 9;
            this.btAnnuler.Text = "Annuler";
            this.btAnnuler.UseVisualStyleBackColor = true;
            // 
            // btEnregistrer
            // 
            this.btEnregistrer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btEnregistrer.Location = new System.Drawing.Point(224, 359);
            this.btEnregistrer.Margin = new System.Windows.Forms.Padding(4);
            this.btEnregistrer.Name = "btEnregistrer";
            this.btEnregistrer.Size = new System.Drawing.Size(100, 28);
            this.btEnregistrer.TabIndex = 8;
            this.btEnregistrer.Text = "Enregistrer";
            this.btEnregistrer.UseVisualStyleBackColor = false;
            // 
            // btAjouter
            // 
            this.btAjouter.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btAjouter.Location = new System.Drawing.Point(407, 485);
            this.btAjouter.Margin = new System.Windows.Forms.Padding(4);
            this.btAjouter.Name = "btAjouter";
            this.btAjouter.Size = new System.Drawing.Size(216, 63);
            this.btAjouter.TabIndex = 5;
            this.btAjouter.Text = "Ajouter un nouveau triathlète";
            this.btAjouter.UseVisualStyleBackColor = false;
            // 
            // triathleteDataGridView
            // 
            this.triathleteDataGridView.AllowUserToAddRows = false;
            this.triathleteDataGridView.AllowUserToDeleteRows = false;
            this.triathleteDataGridView.AutoGenerateColumns = false;
            this.triathleteDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.triathleteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.triathleteDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.triathleteDataGridView.DataSource = this.bindSrcTriathlete;
            this.triathleteDataGridView.Location = new System.Drawing.Point(7, 3);
            this.triathleteDataGridView.Name = "triathleteDataGridView";
            this.triathleteDataGridView.ReadOnly = true;
            this.triathleteDataGridView.RowHeadersWidth = 51;
            this.triathleteDataGridView.RowTemplate.Height = 24;
            this.triathleteDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.triathleteDataGridView.Size = new System.Drawing.Size(1046, 433);
            this.triathleteDataGridView.TabIndex = 0;
            this.triathleteDataGridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.triathleteDataGridView_CellContentDoubleClick);
            // 
            // lblAdresse
            // 
            lblAdresse.AutoSize = true;
            lblAdresse.Location = new System.Drawing.Point(221, 111);
            lblAdresse.Name = "lblAdresse";
            lblAdresse.Size = new System.Drawing.Size(61, 16);
            lblAdresse.TabIndex = 10;
            lblAdresse.Text = "Adresse:";
            // 
            // txtAdresse
            // 
            this.txtAdresse.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindSrcTriathlete, "Adresse", true));
            this.txtAdresse.Location = new System.Drawing.Point(338, 108);
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(200, 22);
            this.txtAdresse.TabIndex = 11;
            // 
            // lblCp
            // 
            lblCp.AutoSize = true;
            lblCp.Location = new System.Drawing.Point(221, 152);
            lblCp.Name = "lblCp";
            lblCp.Size = new System.Drawing.Size(27, 16);
            lblCp.TabIndex = 12;
            lblCp.Text = "Cp:";
            // 
            // txtCp
            // 
            this.txtCp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindSrcTriathlete, "Cp", true));
            this.txtCp.Location = new System.Drawing.Point(338, 149);
            this.txtCp.Name = "txtCp";
            this.txtCp.Size = new System.Drawing.Size(200, 22);
            this.txtCp.TabIndex = 13;
            // 
            // lblDateNaissance
            // 
            lblDateNaissance.AutoSize = true;
            lblDateNaissance.Location = new System.Drawing.Point(221, 195);
            lblDateNaissance.Name = "lblDateNaissance";
            lblDateNaissance.Size = new System.Drawing.Size(107, 16);
            lblDateNaissance.TabIndex = 14;
            lblDateNaissance.Text = "Date Naissance:";
            // 
            // DateTimePickerDateNaissance
            // 
            this.DateTimePickerDateNaissance.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bindSrcTriathlete, "DateNaissance", true));
            this.DateTimePickerDateNaissance.Location = new System.Drawing.Point(338, 191);
            this.DateTimePickerDateNaissance.Name = "DateTimePickerDateNaissance";
            this.DateTimePickerDateNaissance.Size = new System.Drawing.Size(200, 22);
            this.DateTimePickerDateNaissance.TabIndex = 15;
            // 
            // lblNom
            // 
            lblNom.AutoSize = true;
            lblNom.Location = new System.Drawing.Point(221, 232);
            lblNom.Name = "lblNom";
            lblNom.Size = new System.Drawing.Size(39, 16);
            lblNom.TabIndex = 16;
            lblNom.Text = "Nom:";
            // 
            // txtNom
            // 
            this.txtNom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindSrcTriathlete, "Nom", true));
            this.txtNom.Location = new System.Drawing.Point(338, 229);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(200, 22);
            this.txtNom.TabIndex = 17;
            // 
            // lblPrenom
            // 
            lblPrenom.AutoSize = true;
            lblPrenom.Location = new System.Drawing.Point(221, 274);
            lblPrenom.Name = "lblPrenom";
            lblPrenom.Size = new System.Drawing.Size(57, 16);
            lblPrenom.TabIndex = 22;
            lblPrenom.Text = "Prenom:";
            // 
            // txtPrenom
            // 
            this.txtPrenom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindSrcTriathlete, "Prenom", true));
            this.txtPrenom.Location = new System.Drawing.Point(338, 271);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(200, 22);
            this.txtPrenom.TabIndex = 23;
            // 
            // lblVille
            // 
            lblVille.AutoSize = true;
            lblVille.Location = new System.Drawing.Point(221, 311);
            lblVille.Name = "lblVille";
            lblVille.Size = new System.Drawing.Size(36, 16);
            lblVille.TabIndex = 32;
            lblVille.Text = "Ville:";
            // 
            // txtVille
            // 
            this.txtVille.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindSrcTriathlete, "Ville", true));
            this.txtVille.Location = new System.Drawing.Point(338, 308);
            this.txtVille.Name = "txtVille";
            this.txtVille.Size = new System.Drawing.Size(200, 22);
            this.txtVille.TabIndex = 33;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "NumLicence";
            this.dataGridViewTextBoxColumn1.HeaderText = "NumLicence";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NumDossard";
            this.dataGridViewTextBoxColumn2.HeaderText = "NumDossard";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Cp";
            this.dataGridViewTextBoxColumn3.HeaderText = "Cp";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Nom";
            this.dataGridViewTextBoxColumn4.HeaderText = "Nom";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Prenom";
            this.dataGridViewTextBoxColumn5.HeaderText = "Prenom";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Adresse";
            this.dataGridViewTextBoxColumn6.HeaderText = "Adresse";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Ville";
            this.dataGridViewTextBoxColumn7.HeaderText = "Ville";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "DateNaissance";
            this.dataGridViewTextBoxColumn8.HeaderText = "DateNaissance";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // bindSrcTriathlete
            // 
            this.bindSrcTriathlete.DataSource = typeof(Projet_Triathlon.Triathlete);
            // 
            // lblNumDossard
            // 
            lblNumDossard.AutoSize = true;
            lblNumDossard.Location = new System.Drawing.Point(221, 27);
            lblNumDossard.Name = "lblNumDossard";
            lblNumDossard.Size = new System.Drawing.Size(93, 16);
            lblNumDossard.TabIndex = 34;
            lblNumDossard.Text = "Num Dossard:";
            // 
            // txtNumDossard
            // 
            this.txtNumDossard.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindSrcTriathlete, "NumDossard", true));
            this.txtNumDossard.Location = new System.Drawing.Point(338, 24);
            this.txtNumDossard.Name = "txtNumDossard";
            this.txtNumDossard.Size = new System.Drawing.Size(200, 22);
            this.txtNumDossard.TabIndex = 35;
            // 
            // lblNumLicence
            // 
            lblNumLicence.AutoSize = true;
            lblNumLicence.Location = new System.Drawing.Point(221, 76);
            lblNumLicence.Name = "lblNumLicence";
            lblNumLicence.Size = new System.Drawing.Size(88, 16);
            lblNumLicence.TabIndex = 36;
            lblNumLicence.Text = "Num Licence:";
            // 
            // txtNumLicence
            // 
            this.txtNumLicence.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindSrcTriathlete, "NumLicence", true));
            this.txtNumLicence.Location = new System.Drawing.Point(338, 70);
            this.txtNumLicence.Name = "txtNumLicence";
            this.txtNumLicence.Size = new System.Drawing.Size(200, 22);
            this.txtNumLicence.TabIndex = 37;
            // 
            // FrmTriathlete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btAjouter);
            this.Controls.Add(this.tabControlTriathlete);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmTriathlete";
            this.Text = "Gestion des triathlètes";
            this.Load += new System.EventHandler(this.FrmTriathlete_Load);
            this.tabControlTriathlete.ResumeLayout(false);
            this.tabPageListe.ResumeLayout(false);
            this.tabPageDetail.ResumeLayout(false);
            this.tabPageDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.triathleteDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindSrcTriathlete)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlTriathlete;
        private System.Windows.Forms.TabPage tabPageListe;
        private System.Windows.Forms.TabPage tabPageDetail;
        private System.Windows.Forms.Button btSupprimer;
        private System.Windows.Forms.Button btAnnuler;
        private System.Windows.Forms.Button btEnregistrer;
        private System.Windows.Forms.Button btAjouter;
        private System.Windows.Forms.DataGridView triathleteDataGridView;
        private System.Windows.Forms.BindingSource bindSrcTriathlete;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.TextBox txtAdresse;
        private System.Windows.Forms.TextBox txtCp;
        private System.Windows.Forms.DateTimePicker DateTimePickerDateNaissance;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtVille;
        private System.Windows.Forms.TextBox txtNumDossard;
        private System.Windows.Forms.TextBox txtNumLicence;
    }
}

