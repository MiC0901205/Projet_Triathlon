namespace Projet_Triathlon
{
    partial class FrmInscription
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
            this.grpbxInscriptions = new System.Windows.Forms.GroupBox();
            this.btSupprimerTriathlon = new System.Windows.Forms.Button();
            this.gridInscription = new System.Windows.Forms.DataGridView();
            this.colNumCli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomCli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrenomCLi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVilleCli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpbxDetailInscription = new System.Windows.Forms.GroupBox();
            this.txtTempsCycl = new System.Windows.Forms.TextBox();
            this.lblTempsCycl = new System.Windows.Forms.Label();
            this.btModifier = new System.Windows.Forms.Button();
            this.txtTempsCourse = new System.Windows.Forms.TextBox();
            this.txtTempsNat = new System.Windows.Forms.TextBox();
            this.lblTempsCourse = new System.Windows.Forms.Label();
            this.lblTempsNat = new System.Windows.Forms.Label();
            this.grpbxLesInscriptions = new System.Windows.Forms.GroupBox();
            this.btNouvelleInscription = new System.Windows.Forms.Button();
            this.comboBxLesInscriptions = new System.Windows.Forms.ComboBox();
            this.grpbxInscriptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridInscription)).BeginInit();
            this.grpbxDetailInscription.SuspendLayout();
            this.grpbxLesInscriptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbxInscriptions
            // 
            this.grpbxInscriptions.Controls.Add(this.btSupprimerTriathlon);
            this.grpbxInscriptions.Controls.Add(this.gridInscription);
            this.grpbxInscriptions.Location = new System.Drawing.Point(270, 93);
            this.grpbxInscriptions.Margin = new System.Windows.Forms.Padding(2);
            this.grpbxInscriptions.Name = "grpbxInscriptions";
            this.grpbxInscriptions.Padding = new System.Windows.Forms.Padding(2);
            this.grpbxInscriptions.Size = new System.Drawing.Size(519, 346);
            this.grpbxInscriptions.TabIndex = 20;
            this.grpbxInscriptions.TabStop = false;
            this.grpbxInscriptions.Text = "Les inscriptions";
            // 
            // btSupprimerTriathlon
            // 
            this.btSupprimerTriathlon.BackColor = System.Drawing.Color.OrangeRed;
            this.btSupprimerTriathlon.Enabled = false;
            this.btSupprimerTriathlon.Location = new System.Drawing.Point(199, 286);
            this.btSupprimerTriathlon.Margin = new System.Windows.Forms.Padding(2);
            this.btSupprimerTriathlon.Name = "btSupprimerTriathlon";
            this.btSupprimerTriathlon.Size = new System.Drawing.Size(144, 35);
            this.btSupprimerTriathlon.TabIndex = 6;
            this.btSupprimerTriathlon.Text = "Supprimer inscription";
            this.btSupprimerTriathlon.UseVisualStyleBackColor = false;
            // 
            // gridInscription
            // 
            this.gridInscription.AllowUserToAddRows = false;
            this.gridInscription.AllowUserToDeleteRows = false;
            this.gridInscription.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridInscription.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridInscription.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNumCli,
            this.colNomCli,
            this.colPrenomCLi,
            this.colVilleCli,
            this.Column1,
            this.Column2,
            this.Column3});
            this.gridInscription.Location = new System.Drawing.Point(10, 19);
            this.gridInscription.Margin = new System.Windows.Forms.Padding(2);
            this.gridInscription.MultiSelect = false;
            this.gridInscription.Name = "gridInscription";
            this.gridInscription.ReadOnly = true;
            this.gridInscription.RowHeadersWidth = 51;
            this.gridInscription.RowTemplate.Height = 28;
            this.gridInscription.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridInscription.Size = new System.Drawing.Size(509, 245);
            this.gridInscription.TabIndex = 0;
            // 
            // colNumCli
            // 
            this.colNumCli.HeaderText = "NumTriath";
            this.colNumCli.MinimumWidth = 6;
            this.colNumCli.Name = "colNumCli";
            this.colNumCli.ReadOnly = true;
            this.colNumCli.Width = 81;
            // 
            // colNomCli
            // 
            this.colNomCli.HeaderText = "NumDoss";
            this.colNomCli.MinimumWidth = 6;
            this.colNomCli.Name = "colNomCli";
            this.colNomCli.ReadOnly = true;
            this.colNomCli.Width = 78;
            // 
            // colPrenomCLi
            // 
            this.colPrenomCLi.HeaderText = "DateInscr";
            this.colPrenomCLi.MinimumWidth = 6;
            this.colPrenomCLi.Name = "colPrenomCLi";
            this.colPrenomCLi.ReadOnly = true;
            this.colPrenomCLi.Width = 78;
            // 
            // colVilleCli
            // 
            this.colVilleCli.HeaderText = "TempsNat";
            this.colVilleCli.MinimumWidth = 6;
            this.colVilleCli.Name = "colVilleCli";
            this.colVilleCli.ReadOnly = true;
            this.colVilleCli.Width = 81;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "TempsCo";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 77;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "TempsCy";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 76;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "NumLic";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 68;
            // 
            // grpbxDetailInscription
            // 
            this.grpbxDetailInscription.Controls.Add(this.txtTempsCycl);
            this.grpbxDetailInscription.Controls.Add(this.lblTempsCycl);
            this.grpbxDetailInscription.Controls.Add(this.btModifier);
            this.grpbxDetailInscription.Controls.Add(this.txtTempsCourse);
            this.grpbxDetailInscription.Controls.Add(this.txtTempsNat);
            this.grpbxDetailInscription.Controls.Add(this.lblTempsCourse);
            this.grpbxDetailInscription.Controls.Add(this.lblTempsNat);
            this.grpbxDetailInscription.Location = new System.Drawing.Point(11, 93);
            this.grpbxDetailInscription.Margin = new System.Windows.Forms.Padding(2);
            this.grpbxDetailInscription.Name = "grpbxDetailInscription";
            this.grpbxDetailInscription.Padding = new System.Windows.Forms.Padding(2);
            this.grpbxDetailInscription.Size = new System.Drawing.Size(256, 346);
            this.grpbxDetailInscription.TabIndex = 19;
            this.grpbxDetailInscription.TabStop = false;
            this.grpbxDetailInscription.Text = "Détail de l\'inscription";
            // 
            // txtTempsCycl
            // 
            this.txtTempsCycl.Location = new System.Drawing.Point(19, 160);
            this.txtTempsCycl.Margin = new System.Windows.Forms.Padding(2);
            this.txtTempsCycl.MaxLength = 200;
            this.txtTempsCycl.Name = "txtTempsCycl";
            this.txtTempsCycl.Size = new System.Drawing.Size(211, 20);
            this.txtTempsCycl.TabIndex = 10;
            // 
            // lblTempsCycl
            // 
            this.lblTempsCycl.AutoSize = true;
            this.lblTempsCycl.Location = new System.Drawing.Point(16, 142);
            this.lblTempsCycl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTempsCycl.Name = "lblTempsCycl";
            this.lblTempsCycl.Size = new System.Drawing.Size(88, 13);
            this.lblTempsCycl.TabIndex = 9;
            this.lblTempsCycl.Text = "Temps cyclisme :";
            // 
            // btModifier
            // 
            this.btModifier.BackColor = System.Drawing.Color.Silver;
            this.btModifier.Enabled = false;
            this.btModifier.Location = new System.Drawing.Point(72, 196);
            this.btModifier.Margin = new System.Windows.Forms.Padding(2);
            this.btModifier.Name = "btModifier";
            this.btModifier.Size = new System.Drawing.Size(78, 27);
            this.btModifier.TabIndex = 4;
            this.btModifier.Text = "Modifier";
            this.btModifier.UseVisualStyleBackColor = false;
            // 
            // txtTempsCourse
            // 
            this.txtTempsCourse.Location = new System.Drawing.Point(19, 108);
            this.txtTempsCourse.Margin = new System.Windows.Forms.Padding(2);
            this.txtTempsCourse.MaxLength = 200;
            this.txtTempsCourse.Name = "txtTempsCourse";
            this.txtTempsCourse.Size = new System.Drawing.Size(211, 20);
            this.txtTempsCourse.TabIndex = 8;
            // 
            // txtTempsNat
            // 
            this.txtTempsNat.Location = new System.Drawing.Point(19, 59);
            this.txtTempsNat.Margin = new System.Windows.Forms.Padding(2);
            this.txtTempsNat.MaxLength = 200;
            this.txtTempsNat.Name = "txtTempsNat";
            this.txtTempsNat.Size = new System.Drawing.Size(211, 20);
            this.txtTempsNat.TabIndex = 7;
            // 
            // lblTempsCourse
            // 
            this.lblTempsCourse.AutoSize = true;
            this.lblTempsCourse.Location = new System.Drawing.Point(16, 90);
            this.lblTempsCourse.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTempsCourse.Name = "lblTempsCourse";
            this.lblTempsCourse.Size = new System.Drawing.Size(80, 13);
            this.lblTempsCourse.TabIndex = 6;
            this.lblTempsCourse.Text = "Temps course :";
            // 
            // lblTempsNat
            // 
            this.lblTempsNat.AutoSize = true;
            this.lblTempsNat.Location = new System.Drawing.Point(16, 35);
            this.lblTempsNat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTempsNat.Name = "lblTempsNat";
            this.lblTempsNat.Size = new System.Drawing.Size(86, 13);
            this.lblTempsNat.TabIndex = 5;
            this.lblTempsNat.Text = "Temps natation :";
            // 
            // grpbxLesInscriptions
            // 
            this.grpbxLesInscriptions.Controls.Add(this.btNouvelleInscription);
            this.grpbxLesInscriptions.Controls.Add(this.comboBxLesInscriptions);
            this.grpbxLesInscriptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbxLesInscriptions.Location = new System.Drawing.Point(11, 11);
            this.grpbxLesInscriptions.Margin = new System.Windows.Forms.Padding(2);
            this.grpbxLesInscriptions.Name = "grpbxLesInscriptions";
            this.grpbxLesInscriptions.Padding = new System.Windows.Forms.Padding(2);
            this.grpbxLesInscriptions.Size = new System.Drawing.Size(778, 78);
            this.grpbxLesInscriptions.TabIndex = 18;
            this.grpbxLesInscriptions.TabStop = false;
            this.grpbxLesInscriptions.Text = "Selectionner une inscription dans la liste :";
            // 
            // btNouvelleInscription
            // 
            this.btNouvelleInscription.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btNouvelleInscription.Location = new System.Drawing.Point(458, 19);
            this.btNouvelleInscription.Margin = new System.Windows.Forms.Padding(2);
            this.btNouvelleInscription.Name = "btNouvelleInscription";
            this.btNouvelleInscription.Size = new System.Drawing.Size(129, 42);
            this.btNouvelleInscription.TabIndex = 7;
            this.btNouvelleInscription.Text = "Nouvelle inscription";
            this.btNouvelleInscription.UseVisualStyleBackColor = false;
            // 
            // comboBxLesInscriptions
            // 
            this.comboBxLesInscriptions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBxLesInscriptions.FormattingEnabled = true;
            this.comboBxLesInscriptions.Location = new System.Drawing.Point(43, 31);
            this.comboBxLesInscriptions.Margin = new System.Windows.Forms.Padding(2);
            this.comboBxLesInscriptions.Name = "comboBxLesInscriptions";
            this.comboBxLesInscriptions.Size = new System.Drawing.Size(375, 21);
            this.comboBxLesInscriptions.TabIndex = 0;
            // 
            // FrmInscription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpbxInscriptions);
            this.Controls.Add(this.grpbxDetailInscription);
            this.Controls.Add(this.grpbxLesInscriptions);
            this.Name = "FrmInscription";
            this.Text = "Gestion des inscriptions";
            this.grpbxInscriptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridInscription)).EndInit();
            this.grpbxDetailInscription.ResumeLayout(false);
            this.grpbxDetailInscription.PerformLayout();
            this.grpbxLesInscriptions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbxInscriptions;
        private System.Windows.Forms.Button btSupprimerTriathlon;
        private System.Windows.Forms.DataGridView gridInscription;
        private System.Windows.Forms.GroupBox grpbxDetailInscription;
        private System.Windows.Forms.TextBox txtTempsCycl;
        private System.Windows.Forms.Label lblTempsCycl;
        private System.Windows.Forms.Button btModifier;
        private System.Windows.Forms.TextBox txtTempsCourse;
        private System.Windows.Forms.TextBox txtTempsNat;
        private System.Windows.Forms.Label lblTempsCourse;
        private System.Windows.Forms.Label lblTempsNat;
        private System.Windows.Forms.GroupBox grpbxLesInscriptions;
        private System.Windows.Forms.Button btNouvelleInscription;
        private System.Windows.Forms.ComboBox comboBxLesInscriptions;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumCli;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomCli;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrenomCLi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVilleCli;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}