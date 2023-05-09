namespace Projet_Triathlon
{
    partial class FrmProdDopant
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
            System.Windows.Forms.Label codeDopLabel;
            System.Windows.Forms.Label libelleLabel;
            System.Windows.Forms.Label tauxMaxLabel;
            this.tabControlProdDopant = new System.Windows.Forms.TabControl();
            this.tabPageListe = new System.Windows.Forms.TabPage();
            this.prodDopantDataGridView = new System.Windows.Forms.DataGridView();
            this.tabPageDetail = new System.Windows.Forms.TabPage();
            this.codeDopTextBox = new System.Windows.Forms.TextBox();
            this.libelleTextBox = new System.Windows.Forms.TextBox();
            this.tauxMaxTextBox = new System.Windows.Forms.TextBox();
            this.lblDetailProdDopant = new System.Windows.Forms.Label();
            this.btAnnuler = new System.Windows.Forms.Button();
            this.btEnregistrer = new System.Windows.Forms.Button();
            this.btSupprimer = new System.Windows.Forms.Button();
            this.btAjouter = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindSrcProdDopant = new System.Windows.Forms.BindingSource(this.components);
            codeDopLabel = new System.Windows.Forms.Label();
            libelleLabel = new System.Windows.Forms.Label();
            tauxMaxLabel = new System.Windows.Forms.Label();
            this.tabControlProdDopant.SuspendLayout();
            this.tabPageListe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prodDopantDataGridView)).BeginInit();
            this.tabPageDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindSrcProdDopant)).BeginInit();
            this.SuspendLayout();
            // 
            // codeDopLabel
            // 
            codeDopLabel.AutoSize = true;
            codeDopLabel.Location = new System.Drawing.Point(247, 103);
            codeDopLabel.Name = "codeDopLabel";
            codeDopLabel.Size = new System.Drawing.Size(72, 16);
            codeDopLabel.TabIndex = 18;
            codeDopLabel.Text = "Code Dop:";
            // 
            // libelleLabel
            // 
            libelleLabel.AutoSize = true;
            libelleLabel.Location = new System.Drawing.Point(247, 167);
            libelleLabel.Name = "libelleLabel";
            libelleLabel.Size = new System.Drawing.Size(50, 16);
            libelleLabel.TabIndex = 20;
            libelleLabel.Text = "Libelle:";
            // 
            // tauxMaxLabel
            // 
            tauxMaxLabel.AutoSize = true;
            tauxMaxLabel.Location = new System.Drawing.Point(247, 242);
            tauxMaxLabel.Name = "tauxMaxLabel";
            tauxMaxLabel.Size = new System.Drawing.Size(68, 16);
            tauxMaxLabel.TabIndex = 22;
            tauxMaxLabel.Text = "Taux Max:";
            // 
            // tabControlProdDopant
            // 
            this.tabControlProdDopant.Controls.Add(this.tabPageListe);
            this.tabControlProdDopant.Controls.Add(this.tabPageDetail);
            this.tabControlProdDopant.Location = new System.Drawing.Point(6, 6);
            this.tabControlProdDopant.Margin = new System.Windows.Forms.Padding(4);
            this.tabControlProdDopant.Name = "tabControlProdDopant";
            this.tabControlProdDopant.SelectedIndex = 0;
            this.tabControlProdDopant.Size = new System.Drawing.Size(1065, 471);
            this.tabControlProdDopant.TabIndex = 3;
            // 
            // tabPageListe
            // 
            this.tabPageListe.AutoScroll = true;
            this.tabPageListe.Controls.Add(this.prodDopantDataGridView);
            this.tabPageListe.Location = new System.Drawing.Point(4, 25);
            this.tabPageListe.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageListe.Name = "tabPageListe";
            this.tabPageListe.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageListe.Size = new System.Drawing.Size(1057, 442);
            this.tabPageListe.TabIndex = 0;
            this.tabPageListe.Text = "Liste des produits dopants";
            this.tabPageListe.UseVisualStyleBackColor = true;
            // 
            // prodDopantDataGridView
            // 
            this.prodDopantDataGridView.AllowUserToAddRows = false;
            this.prodDopantDataGridView.AllowUserToDeleteRows = false;
            this.prodDopantDataGridView.AutoGenerateColumns = false;
            this.prodDopantDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.prodDopantDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.prodDopantDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.prodDopantDataGridView.DataSource = this.bindSrcProdDopant;
            this.prodDopantDataGridView.Location = new System.Drawing.Point(3, 0);
            this.prodDopantDataGridView.Name = "prodDopantDataGridView";
            this.prodDopantDataGridView.ReadOnly = true;
            this.prodDopantDataGridView.RowHeadersWidth = 51;
            this.prodDopantDataGridView.RowTemplate.Height = 24;
            this.prodDopantDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.prodDopantDataGridView.Size = new System.Drawing.Size(1047, 435);
            this.prodDopantDataGridView.TabIndex = 0;
            this.prodDopantDataGridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.prodDopantDataGridView_CellContentDoubleClick);
            // 
            // tabPageDetail
            // 
            this.tabPageDetail.AutoScroll = true;
            this.tabPageDetail.Controls.Add(codeDopLabel);
            this.tabPageDetail.Controls.Add(this.codeDopTextBox);
            this.tabPageDetail.Controls.Add(libelleLabel);
            this.tabPageDetail.Controls.Add(this.libelleTextBox);
            this.tabPageDetail.Controls.Add(tauxMaxLabel);
            this.tabPageDetail.Controls.Add(this.tauxMaxTextBox);
            this.tabPageDetail.Controls.Add(this.lblDetailProdDopant);
            this.tabPageDetail.Controls.Add(this.btAnnuler);
            this.tabPageDetail.Controls.Add(this.btEnregistrer);
            this.tabPageDetail.Controls.Add(this.btSupprimer);
            this.tabPageDetail.Location = new System.Drawing.Point(4, 25);
            this.tabPageDetail.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageDetail.Name = "tabPageDetail";
            this.tabPageDetail.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageDetail.Size = new System.Drawing.Size(1057, 442);
            this.tabPageDetail.TabIndex = 1;
            this.tabPageDetail.Text = "Détail d\'un produit dopant";
            this.tabPageDetail.UseVisualStyleBackColor = true;
            // 
            // codeDopTextBox
            // 
            this.codeDopTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindSrcProdDopant, "CodeDop", true));
            this.codeDopTextBox.Location = new System.Drawing.Point(325, 97);
            this.codeDopTextBox.Name = "codeDopTextBox";
            this.codeDopTextBox.Size = new System.Drawing.Size(100, 22);
            this.codeDopTextBox.TabIndex = 19;
            // 
            // libelleTextBox
            // 
            this.libelleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindSrcProdDopant, "Libelle", true));
            this.libelleTextBox.Location = new System.Drawing.Point(325, 164);
            this.libelleTextBox.Name = "libelleTextBox";
            this.libelleTextBox.Size = new System.Drawing.Size(100, 22);
            this.libelleTextBox.TabIndex = 21;
            // 
            // tauxMaxTextBox
            // 
            this.tauxMaxTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindSrcProdDopant, "TauxMax", true));
            this.tauxMaxTextBox.Location = new System.Drawing.Point(325, 239);
            this.tauxMaxTextBox.Name = "tauxMaxTextBox";
            this.tauxMaxTextBox.Size = new System.Drawing.Size(100, 22);
            this.tauxMaxTextBox.TabIndex = 23;
            // 
            // lblDetailProdDopant
            // 
            this.lblDetailProdDopant.AutoSize = true;
            this.lblDetailProdDopant.Location = new System.Drawing.Point(180, 43);
            this.lblDetailProdDopant.Name = "lblDetailProdDopant";
            this.lblDetailProdDopant.Size = new System.Drawing.Size(201, 16);
            this.lblDetailProdDopant.TabIndex = 18;
            this.lblDetailProdDopant.Text = "Les données du produit dopant : ";
            // 
            // btAnnuler
            // 
            this.btAnnuler.Location = new System.Drawing.Point(370, 310);
            this.btAnnuler.Margin = new System.Windows.Forms.Padding(4);
            this.btAnnuler.Name = "btAnnuler";
            this.btAnnuler.Size = new System.Drawing.Size(100, 28);
            this.btAnnuler.TabIndex = 17;
            this.btAnnuler.Text = "Annuler";
            this.btAnnuler.UseVisualStyleBackColor = true;
            // 
            // btEnregistrer
            // 
            this.btEnregistrer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btEnregistrer.Location = new System.Drawing.Point(246, 310);
            this.btEnregistrer.Margin = new System.Windows.Forms.Padding(4);
            this.btEnregistrer.Name = "btEnregistrer";
            this.btEnregistrer.Size = new System.Drawing.Size(100, 28);
            this.btEnregistrer.TabIndex = 16;
            this.btEnregistrer.Text = "Enregistrer";
            this.btEnregistrer.UseVisualStyleBackColor = false;
            // 
            // btSupprimer
            // 
            this.btSupprimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btSupprimer.Location = new System.Drawing.Point(641, 393);
            this.btSupprimer.Margin = new System.Windows.Forms.Padding(4);
            this.btSupprimer.Name = "btSupprimer";
            this.btSupprimer.Size = new System.Drawing.Size(237, 37);
            this.btSupprimer.TabIndex = 10;
            this.btSupprimer.Text = "Supprimer ce produit";
            this.btSupprimer.UseVisualStyleBackColor = false;
            // 
            // btAjouter
            // 
            this.btAjouter.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btAjouter.Location = new System.Drawing.Point(436, 485);
            this.btAjouter.Margin = new System.Windows.Forms.Padding(4);
            this.btAjouter.Name = "btAjouter";
            this.btAjouter.Size = new System.Drawing.Size(216, 63);
            this.btAjouter.TabIndex = 4;
            this.btAjouter.Text = "Ajouter un nouveau produit";
            this.btAjouter.UseVisualStyleBackColor = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CodeDop";
            this.dataGridViewTextBoxColumn1.HeaderText = "CodeDop";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 95;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Libelle";
            this.dataGridViewTextBoxColumn2.HeaderText = "Libelle";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 76;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "TauxMax";
            this.dataGridViewTextBoxColumn3.HeaderText = "TauxMax";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 91;
            // 
            // bindSrcProdDopant
            // 
            this.bindSrcProdDopant.DataSource = typeof(Projet_Triathlon.ProdDopant);
            // 
            // FrmProdDopant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 561);
            this.Controls.Add(this.btAjouter);
            this.Controls.Add(this.tabControlProdDopant);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmProdDopant";
            this.Text = "Gestion des produits dopants";
            this.Load += new System.EventHandler(this.FrmProdDopant_Load);
            this.tabControlProdDopant.ResumeLayout(false);
            this.tabPageListe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.prodDopantDataGridView)).EndInit();
            this.tabPageDetail.ResumeLayout(false);
            this.tabPageDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindSrcProdDopant)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControlProdDopant;
        private System.Windows.Forms.TabPage tabPageListe;
        private System.Windows.Forms.Button btAjouter;
        private System.Windows.Forms.TabPage tabPageDetail;
        private System.Windows.Forms.Button btSupprimer;
        private System.Windows.Forms.Button btAnnuler;
        private System.Windows.Forms.Button btEnregistrer;
        private System.Windows.Forms.Label lblDetailProdDopant;
        private System.Windows.Forms.DataGridView prodDopantDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.BindingSource bindSrcProdDopant;
        private System.Windows.Forms.TextBox codeDopTextBox;
        private System.Windows.Forms.TextBox libelleTextBox;
        private System.Windows.Forms.TextBox tauxMaxTextBox;
    }
}