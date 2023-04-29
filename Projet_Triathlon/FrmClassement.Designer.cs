namespace Projet_Triathlon
{
    partial class FrmClassement
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
            this.grpbxLesTriathlonsCla = new System.Windows.Forms.GroupBox();
            this.comboBxLesTriathlonsCla = new System.Windows.Forms.ComboBox();
            this.grpbxLeClassement = new System.Windows.Forms.GroupBox();
            this.gridClassement = new System.Windows.Forms.DataGridView();
            this.colNumCli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomCli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrenomCLi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpbxTemps = new System.Windows.Forms.GroupBox();
            this.btSupprime = new System.Windows.Forms.Button();
            this.btModifier = new System.Windows.Forms.Button();
            this.grpbxLesTriathlonsCla.SuspendLayout();
            this.grpbxLeClassement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridClassement)).BeginInit();
            this.grpbxTemps.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbxLesTriathlonsCla
            // 
            this.grpbxLesTriathlonsCla.Controls.Add(this.comboBxLesTriathlonsCla);
            this.grpbxLesTriathlonsCla.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbxLesTriathlonsCla.Location = new System.Drawing.Point(11, 11);
            this.grpbxLesTriathlonsCla.Margin = new System.Windows.Forms.Padding(2);
            this.grpbxLesTriathlonsCla.Name = "grpbxLesTriathlonsCla";
            this.grpbxLesTriathlonsCla.Padding = new System.Windows.Forms.Padding(2);
            this.grpbxLesTriathlonsCla.Size = new System.Drawing.Size(778, 86);
            this.grpbxLesTriathlonsCla.TabIndex = 8;
            this.grpbxLesTriathlonsCla.TabStop = false;
            this.grpbxLesTriathlonsCla.Text = "Selectionner un triathlon dans la liste :";
            // 
            // comboBxLesTriathlonsCla
            // 
            this.comboBxLesTriathlonsCla.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBxLesTriathlonsCla.FormattingEnabled = true;
            this.comboBxLesTriathlonsCla.Location = new System.Drawing.Point(43, 31);
            this.comboBxLesTriathlonsCla.Margin = new System.Windows.Forms.Padding(2);
            this.comboBxLesTriathlonsCla.Name = "comboBxLesTriathlonsCla";
            this.comboBxLesTriathlonsCla.Size = new System.Drawing.Size(375, 21);
            this.comboBxLesTriathlonsCla.TabIndex = 0;
            // 
            // grpbxLeClassement
            // 
            this.grpbxLeClassement.Controls.Add(this.gridClassement);
            this.grpbxLeClassement.Location = new System.Drawing.Point(11, 101);
            this.grpbxLeClassement.Margin = new System.Windows.Forms.Padding(2);
            this.grpbxLeClassement.Name = "grpbxLeClassement";
            this.grpbxLeClassement.Padding = new System.Windows.Forms.Padding(2);
            this.grpbxLeClassement.Size = new System.Drawing.Size(571, 329);
            this.grpbxLeClassement.TabIndex = 10;
            this.grpbxLeClassement.TabStop = false;
            this.grpbxLeClassement.Text = "Le classement";
            // 
            // gridClassement
            // 
            this.gridClassement.AllowUserToAddRows = false;
            this.gridClassement.AllowUserToDeleteRows = false;
            this.gridClassement.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridClassement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridClassement.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNumCli,
            this.Column5,
            this.colNomCli,
            this.colPrenomCLi,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.gridClassement.Location = new System.Drawing.Point(10, 19);
            this.gridClassement.Margin = new System.Windows.Forms.Padding(2);
            this.gridClassement.MultiSelect = false;
            this.gridClassement.Name = "gridClassement";
            this.gridClassement.ReadOnly = true;
            this.gridClassement.RowHeadersWidth = 51;
            this.gridClassement.RowTemplate.Height = 28;
            this.gridClassement.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridClassement.Size = new System.Drawing.Size(548, 306);
            this.gridClassement.TabIndex = 0;
            // 
            // colNumCli
            // 
            this.colNumCli.HeaderText = "NumLicence";
            this.colNumCli.MinimumWidth = 6;
            this.colNumCli.Name = "colNumCli";
            this.colNumCli.ReadOnly = true;
            this.colNumCli.Width = 92;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "NumDossard";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 93;
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
            this.Column1.HeaderText = "TempsCourse";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 97;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "TempsCyclisme";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 105;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "TempsNatation";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 104;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "TempsTotal";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 88;
            // 
            // grpbxTemps
            // 
            this.grpbxTemps.Controls.Add(this.btSupprime);
            this.grpbxTemps.Controls.Add(this.btModifier);
            this.grpbxTemps.Location = new System.Drawing.Point(586, 101);
            this.grpbxTemps.Margin = new System.Windows.Forms.Padding(2);
            this.grpbxTemps.Name = "grpbxTemps";
            this.grpbxTemps.Padding = new System.Windows.Forms.Padding(2);
            this.grpbxTemps.Size = new System.Drawing.Size(203, 329);
            this.grpbxTemps.TabIndex = 12;
            this.grpbxTemps.TabStop = false;
            this.grpbxTemps.Text = "Temps";
            // 
            // btSupprime
            // 
            this.btSupprime.BackColor = System.Drawing.Color.OrangeRed;
            this.btSupprime.Enabled = false;
            this.btSupprime.Location = new System.Drawing.Point(18, 201);
            this.btSupprime.Margin = new System.Windows.Forms.Padding(2);
            this.btSupprime.Name = "btSupprime";
            this.btSupprime.Size = new System.Drawing.Size(85, 27);
            this.btSupprime.TabIndex = 7;
            this.btSupprime.Text = "Supprimer";
            this.btSupprime.UseVisualStyleBackColor = false;
            // 
            // btModifier
            // 
            this.btModifier.BackColor = System.Drawing.Color.Silver;
            this.btModifier.Enabled = false;
            this.btModifier.Location = new System.Drawing.Point(121, 201);
            this.btModifier.Margin = new System.Windows.Forms.Padding(2);
            this.btModifier.Name = "btModifier";
            this.btModifier.Size = new System.Drawing.Size(78, 27);
            this.btModifier.TabIndex = 4;
            this.btModifier.Text = "Enregistrer";
            this.btModifier.UseVisualStyleBackColor = false;
            // 
            // FrmClassement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpbxTemps);
            this.Controls.Add(this.grpbxLeClassement);
            this.Controls.Add(this.grpbxLesTriathlonsCla);
            this.Name = "FrmClassement";
            this.Text = "Classement";
            this.grpbxLesTriathlonsCla.ResumeLayout(false);
            this.grpbxLeClassement.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridClassement)).EndInit();
            this.grpbxTemps.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbxLesTriathlonsCla;
        private System.Windows.Forms.ComboBox comboBxLesTriathlonsCla;
        private System.Windows.Forms.GroupBox grpbxLeClassement;
        private System.Windows.Forms.DataGridView gridClassement;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumCli;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomCli;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrenomCLi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.GroupBox grpbxTemps;
        private System.Windows.Forms.Button btModifier;
        private System.Windows.Forms.Button btSupprime;
    }
}