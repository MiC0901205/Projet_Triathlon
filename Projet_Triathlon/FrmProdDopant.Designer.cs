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
            this.grpbxLesProdsDops = new System.Windows.Forms.GroupBox();
            this.btNouveauProdDop = new System.Windows.Forms.Button();
            this.comboBxLesProdsDop = new System.Windows.Forms.ComboBox();
            this.grpbxDetailProduitDopant = new System.Windows.Forms.GroupBox();
            this.btSupprimer = new System.Windows.Forms.Button();
            this.txtTauxMax = new System.Windows.Forms.TextBox();
            this.lblTauxMax = new System.Windows.Forms.Label();
            this.btModifier = new System.Windows.Forms.Button();
            this.txtLibelle = new System.Windows.Forms.TextBox();
            this.lblLibelle = new System.Windows.Forms.Label();
            this.grpbxProdDopand = new System.Windows.Forms.GroupBox();
            this.bindSrcProdDopant = new System.Windows.Forms.BindingSource(this.components);
            this.gridProdDop = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpbxLesProdsDops.SuspendLayout();
            this.grpbxDetailProduitDopant.SuspendLayout();
            this.grpbxProdDopand.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindSrcProdDopant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridProdDop)).BeginInit();
            this.SuspendLayout();
            // 
            // grpbxLesProdsDops
            // 
            this.grpbxLesProdsDops.Controls.Add(this.btNouveauProdDop);
            this.grpbxLesProdsDops.Controls.Add(this.comboBxLesProdsDop);
            this.grpbxLesProdsDops.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbxLesProdsDops.Location = new System.Drawing.Point(15, 14);
            this.grpbxLesProdsDops.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpbxLesProdsDops.Name = "grpbxLesProdsDops";
            this.grpbxLesProdsDops.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpbxLesProdsDops.Size = new System.Drawing.Size(1037, 106);
            this.grpbxLesProdsDops.TabIndex = 7;
            this.grpbxLesProdsDops.TabStop = false;
            this.grpbxLesProdsDops.Text = "Selectionner un produit dans la liste :";
            // 
            // btNouveauProdDop
            // 
            this.btNouveauProdDop.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btNouveauProdDop.Location = new System.Drawing.Point(611, 21);
            this.btNouveauProdDop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btNouveauProdDop.Name = "btNouveauProdDop";
            this.btNouveauProdDop.Size = new System.Drawing.Size(185, 43);
            this.btNouveauProdDop.TabIndex = 7;
            this.btNouveauProdDop.Text = "Nouveau produit dopant";
            this.btNouveauProdDop.UseVisualStyleBackColor = false;
            this.btNouveauProdDop.Click += new System.EventHandler(this.btNouveauProdDop_Click);
            // 
            // comboBxLesProdsDop
            // 
            this.comboBxLesProdsDop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBxLesProdsDop.FormattingEnabled = true;
            this.comboBxLesProdsDop.Location = new System.Drawing.Point(57, 38);
            this.comboBxLesProdsDop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBxLesProdsDop.Name = "comboBxLesProdsDop";
            this.comboBxLesProdsDop.Size = new System.Drawing.Size(499, 24);
            this.comboBxLesProdsDop.TabIndex = 0;
            this.comboBxLesProdsDop.SelectedIndexChanged += new System.EventHandler(this.comboBxLesProdsDop_SelectedIndexChanged);
            // 
            // grpbxDetailProduitDopant
            // 
            this.grpbxDetailProduitDopant.Controls.Add(this.btSupprimer);
            this.grpbxDetailProduitDopant.Controls.Add(this.txtTauxMax);
            this.grpbxDetailProduitDopant.Controls.Add(this.lblTauxMax);
            this.grpbxDetailProduitDopant.Controls.Add(this.btModifier);
            this.grpbxDetailProduitDopant.Controls.Add(this.txtLibelle);
            this.grpbxDetailProduitDopant.Controls.Add(this.lblLibelle);
            this.grpbxDetailProduitDopant.Location = new System.Drawing.Point(15, 135);
            this.grpbxDetailProduitDopant.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpbxDetailProduitDopant.Name = "grpbxDetailProduitDopant";
            this.grpbxDetailProduitDopant.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpbxDetailProduitDopant.Size = new System.Drawing.Size(383, 405);
            this.grpbxDetailProduitDopant.TabIndex = 8;
            this.grpbxDetailProduitDopant.TabStop = false;
            this.grpbxDetailProduitDopant.Text = "Détail du produit";
            // 
            // btSupprimer
            // 
            this.btSupprimer.BackColor = System.Drawing.Color.OrangeRed;
            this.btSupprimer.Enabled = false;
            this.btSupprimer.Location = new System.Drawing.Point(137, 202);
            this.btSupprimer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btSupprimer.Name = "btSupprimer";
            this.btSupprimer.Size = new System.Drawing.Size(112, 33);
            this.btSupprimer.TabIndex = 6;
            this.btSupprimer.Text = "Supprimer";
            this.btSupprimer.UseVisualStyleBackColor = false;
            this.btSupprimer.Click += new System.EventHandler(this.btSupprimer_Click);
            // 
            // txtTauxMax
            // 
            this.txtTauxMax.Location = new System.Drawing.Point(16, 126);
            this.txtTauxMax.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTauxMax.MaxLength = 200;
            this.txtTauxMax.Name = "txtTauxMax";
            this.txtTauxMax.Size = new System.Drawing.Size(144, 22);
            this.txtTauxMax.TabIndex = 6;
            // 
            // lblTauxMax
            // 
            this.lblTauxMax.AutoSize = true;
            this.lblTauxMax.Location = new System.Drawing.Point(21, 103);
            this.lblTauxMax.Name = "lblTauxMax";
            this.lblTauxMax.Size = new System.Drawing.Size(71, 16);
            this.lblTauxMax.TabIndex = 5;
            this.lblTauxMax.Text = "Taux Max :";
            // 
            // btModifier
            // 
            this.btModifier.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btModifier.Enabled = false;
            this.btModifier.Location = new System.Drawing.Point(16, 202);
            this.btModifier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btModifier.Name = "btModifier";
            this.btModifier.Size = new System.Drawing.Size(104, 33);
            this.btModifier.TabIndex = 4;
            this.btModifier.Text = "Modifier";
            this.btModifier.UseVisualStyleBackColor = false;
            this.btModifier.Click += new System.EventHandler(this.btModifier_Click);
            // 
            // txtLibelle
            // 
            this.txtLibelle.Location = new System.Drawing.Point(16, 59);
            this.txtLibelle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLibelle.MaxLength = 200;
            this.txtLibelle.Name = "txtLibelle";
            this.txtLibelle.Size = new System.Drawing.Size(272, 22);
            this.txtLibelle.TabIndex = 1;
            // 
            // lblLibelle
            // 
            this.lblLibelle.AutoSize = true;
            this.lblLibelle.Location = new System.Drawing.Point(21, 37);
            this.lblLibelle.Name = "lblLibelle";
            this.lblLibelle.Size = new System.Drawing.Size(56, 16);
            this.lblLibelle.TabIndex = 0;
            this.lblLibelle.Text = "Libelle  :";
            // 
            // grpbxProdDopand
            // 
            this.grpbxProdDopand.Controls.Add(this.gridProdDop);
            this.grpbxProdDopand.Location = new System.Drawing.Point(419, 135);
            this.grpbxProdDopand.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpbxProdDopand.Name = "grpbxProdDopand";
            this.grpbxProdDopand.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpbxProdDopand.Size = new System.Drawing.Size(633, 406);
            this.grpbxProdDopand.TabIndex = 18;
            this.grpbxProdDopand.TabStop = false;
            this.grpbxProdDopand.Text = "Les produits dopants";
            // 
            // bindSrcProdDopant
            // 
            this.bindSrcProdDopant.DataSource = typeof(Projet_Triathlon.ProdDopant);
            // 
            // gridProdDop
            // 
            this.gridProdDop.AutoGenerateColumns = false;
            this.gridProdDop.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridProdDop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProdDop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.gridProdDop.DataSource = this.bindSrcProdDopant;
            this.gridProdDop.Location = new System.Drawing.Point(6, 20);
            this.gridProdDop.Name = "gridProdDop";
            this.gridProdDop.RowHeadersWidth = 51;
            this.gridProdDop.RowTemplate.Height = 24;
            this.gridProdDop.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridProdDop.Size = new System.Drawing.Size(621, 381);
            this.gridProdDop.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CodDop";
            this.dataGridViewTextBoxColumn1.HeaderText = "CodDop";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 87;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Libelle";
            this.dataGridViewTextBoxColumn2.HeaderText = "Libelle";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 76;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "TauxMax";
            this.dataGridViewTextBoxColumn3.HeaderText = "TauxMax";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 91;
            // 
            // FrmProdDopant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.grpbxProdDopand);
            this.Controls.Add(this.grpbxDetailProduitDopant);
            this.Controls.Add(this.grpbxLesProdsDops);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmProdDopant";
            this.Text = "Gestion des produits dopants";
            this.Load += new System.EventHandler(this.FrmProdDopant_Load);
            this.grpbxLesProdsDops.ResumeLayout(false);
            this.grpbxDetailProduitDopant.ResumeLayout(false);
            this.grpbxDetailProduitDopant.PerformLayout();
            this.grpbxProdDopand.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindSrcProdDopant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridProdDop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbxLesProdsDops;
        private System.Windows.Forms.Button btNouveauProdDop;
        private System.Windows.Forms.ComboBox comboBxLesProdsDop;
        private System.Windows.Forms.GroupBox grpbxDetailProduitDopant;
        private System.Windows.Forms.Button btModifier;
        private System.Windows.Forms.TextBox txtLibelle;
        private System.Windows.Forms.Label lblLibelle;
        private System.Windows.Forms.Button btSupprimer;
        private System.Windows.Forms.TextBox txtTauxMax;
        private System.Windows.Forms.Label lblTauxMax;
        private System.Windows.Forms.GroupBox grpbxProdDopand;
        private System.Windows.Forms.BindingSource bindSrcProdDopant;
        private System.Windows.Forms.DataGridView gridProdDop;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}