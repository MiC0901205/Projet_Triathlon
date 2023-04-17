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
            this.grpbxTriathlons = new System.Windows.Forms.GroupBox();
            this.btSupprimer = new System.Windows.Forms.Button();
            this.gridTriathlons = new System.Windows.Forms.DataGridView();
            this.colNumCli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomCli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrenomCLi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVilleCli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpbxDetailTriathlon = new System.Windows.Forms.GroupBox();
            this.comboBxLesTypesTriath = new System.Windows.Forms.ComboBox();
            this.lblTypeTriathlon = new System.Windows.Forms.Label();
            this.dateTimeCompet = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLieu = new System.Windows.Forms.TextBox();
            this.lblLieu = new System.Windows.Forms.Label();
            this.btModifier = new System.Windows.Forms.Button();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.grpbxLesTriathlons = new System.Windows.Forms.GroupBox();
            this.btNouveauTriathlon = new System.Windows.Forms.Button();
            this.comboBxLesTriathlons = new System.Windows.Forms.ComboBox();
            this.grpbxTriathlons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTriathlons)).BeginInit();
            this.grpbxDetailTriathlon.SuspendLayout();
            this.grpbxLesTriathlons.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbxTriathlons
            // 
            this.grpbxTriathlons.Controls.Add(this.btSupprimer);
            this.grpbxTriathlons.Controls.Add(this.gridTriathlons);
            this.grpbxTriathlons.Location = new System.Drawing.Point(269, 100);
            this.grpbxTriathlons.Margin = new System.Windows.Forms.Padding(2);
            this.grpbxTriathlons.Name = "grpbxTriathlons";
            this.grpbxTriathlons.Padding = new System.Windows.Forms.Padding(2);
            this.grpbxTriathlons.Size = new System.Drawing.Size(520, 339);
            this.grpbxTriathlons.TabIndex = 17;
            this.grpbxTriathlons.TabStop = false;
            this.grpbxTriathlons.Text = "Les triathlons";
            // 
            // btSupprimer
            // 
            this.btSupprimer.BackColor = System.Drawing.Color.OrangeRed;
            this.btSupprimer.Enabled = false;
            this.btSupprimer.Location = new System.Drawing.Point(224, 280);
            this.btSupprimer.Margin = new System.Windows.Forms.Padding(2);
            this.btSupprimer.Name = "btSupprimer";
            this.btSupprimer.Size = new System.Drawing.Size(141, 37);
            this.btSupprimer.TabIndex = 6;
            this.btSupprimer.Text = "Supprimer triathlon";
            this.btSupprimer.UseVisualStyleBackColor = false;
            // 
            // gridTriathlons
            // 
            this.gridTriathlons.AllowUserToAddRows = false;
            this.gridTriathlons.AllowUserToDeleteRows = false;
            this.gridTriathlons.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridTriathlons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTriathlons.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNumCli,
            this.colNomCli,
            this.colPrenomCLi,
            this.colVilleCli,
            this.Column1});
            this.gridTriathlons.Location = new System.Drawing.Point(10, 19);
            this.gridTriathlons.Margin = new System.Windows.Forms.Padding(2);
            this.gridTriathlons.MultiSelect = false;
            this.gridTriathlons.Name = "gridTriathlons";
            this.gridTriathlons.ReadOnly = true;
            this.gridTriathlons.RowHeadersWidth = 51;
            this.gridTriathlons.RowTemplate.Height = 28;
            this.gridTriathlons.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridTriathlons.Size = new System.Drawing.Size(510, 244);
            this.gridTriathlons.TabIndex = 0;
            // 
            // colNumCli
            // 
            this.colNumCli.HeaderText = "Numéro";
            this.colNumCli.MinimumWidth = 6;
            this.colNumCli.Name = "colNumCli";
            this.colNumCli.ReadOnly = true;
            this.colNumCli.Width = 69;
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
            this.colPrenomCLi.HeaderText = "Lieu";
            this.colPrenomCLi.MinimumWidth = 6;
            this.colPrenomCLi.Name = "colPrenomCLi";
            this.colPrenomCLi.ReadOnly = true;
            this.colPrenomCLi.Width = 52;
            // 
            // colVilleCli
            // 
            this.colVilleCli.HeaderText = "DateCompet";
            this.colVilleCli.MinimumWidth = 6;
            this.colVilleCli.Name = "colVilleCli";
            this.colVilleCli.ReadOnly = true;
            this.colVilleCli.Width = 91;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "CodeTypeTriath";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 108;
            // 
            // grpbxDetailTriathlon
            // 
            this.grpbxDetailTriathlon.Controls.Add(this.comboBxLesTypesTriath);
            this.grpbxDetailTriathlon.Controls.Add(this.lblTypeTriathlon);
            this.grpbxDetailTriathlon.Controls.Add(this.dateTimeCompet);
            this.grpbxDetailTriathlon.Controls.Add(this.label1);
            this.grpbxDetailTriathlon.Controls.Add(this.txtLieu);
            this.grpbxDetailTriathlon.Controls.Add(this.lblLieu);
            this.grpbxDetailTriathlon.Controls.Add(this.btModifier);
            this.grpbxDetailTriathlon.Controls.Add(this.txtNom);
            this.grpbxDetailTriathlon.Controls.Add(this.lblNom);
            this.grpbxDetailTriathlon.Location = new System.Drawing.Point(11, 92);
            this.grpbxDetailTriathlon.Margin = new System.Windows.Forms.Padding(2);
            this.grpbxDetailTriathlon.Name = "grpbxDetailTriathlon";
            this.grpbxDetailTriathlon.Padding = new System.Windows.Forms.Padding(2);
            this.grpbxDetailTriathlon.Size = new System.Drawing.Size(254, 347);
            this.grpbxDetailTriathlon.TabIndex = 16;
            this.grpbxDetailTriathlon.TabStop = false;
            this.grpbxDetailTriathlon.Text = "Détail du triathlon";
            // 
            // comboBxLesTypesTriath
            // 
            this.comboBxLesTypesTriath.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBxLesTypesTriath.FormattingEnabled = true;
            this.comboBxLesTypesTriath.Location = new System.Drawing.Point(19, 250);
            this.comboBxLesTypesTriath.Margin = new System.Windows.Forms.Padding(2);
            this.comboBxLesTypesTriath.Name = "comboBxLesTypesTriath";
            this.comboBxLesTypesTriath.Size = new System.Drawing.Size(166, 21);
            this.comboBxLesTypesTriath.TabIndex = 10;
            // 
            // lblTypeTriathlon
            // 
            this.lblTypeTriathlon.AutoSize = true;
            this.lblTypeTriathlon.Location = new System.Drawing.Point(16, 224);
            this.lblTypeTriathlon.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTypeTriathlon.Name = "lblTypeTriathlon";
            this.lblTypeTriathlon.Size = new System.Drawing.Size(77, 13);
            this.lblTypeTriathlon.TabIndex = 9;
            this.lblTypeTriathlon.Text = "Type triathlon :";
            // 
            // dateTimeCompet
            // 
            this.dateTimeCompet.Location = new System.Drawing.Point(19, 181);
            this.dateTimeCompet.Name = "dateTimeCompet";
            this.dateTimeCompet.Size = new System.Drawing.Size(200, 20);
            this.dateTimeCompet.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 153);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Date compétition :";
            // 
            // txtLieu
            // 
            this.txtLieu.Location = new System.Drawing.Point(19, 114);
            this.txtLieu.Margin = new System.Windows.Forms.Padding(2);
            this.txtLieu.MaxLength = 200;
            this.txtLieu.Name = "txtLieu";
            this.txtLieu.Size = new System.Drawing.Size(148, 20);
            this.txtLieu.TabIndex = 6;
            // 
            // lblLieu
            // 
            this.lblLieu.AutoSize = true;
            this.lblLieu.Location = new System.Drawing.Point(16, 90);
            this.lblLieu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLieu.Name = "lblLieu";
            this.lblLieu.Size = new System.Drawing.Size(33, 13);
            this.lblLieu.TabIndex = 5;
            this.lblLieu.Text = "Lieu :";
            // 
            // btModifier
            // 
            this.btModifier.BackColor = System.Drawing.Color.Silver;
            this.btModifier.Enabled = false;
            this.btModifier.Location = new System.Drawing.Point(89, 293);
            this.btModifier.Margin = new System.Windows.Forms.Padding(2);
            this.btModifier.Name = "btModifier";
            this.btModifier.Size = new System.Drawing.Size(78, 27);
            this.btModifier.TabIndex = 4;
            this.btModifier.Text = "Modifier";
            this.btModifier.UseVisualStyleBackColor = false;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(19, 54);
            this.txtNom.Margin = new System.Windows.Forms.Padding(2);
            this.txtNom.MaxLength = 200;
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(148, 20);
            this.txtNom.TabIndex = 1;
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(16, 30);
            this.lblNom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(35, 13);
            this.lblNom.TabIndex = 0;
            this.lblNom.Text = "Nom :";
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
            this.btNouveauTriathlon.Location = new System.Drawing.Point(458, 19);
            this.btNouveauTriathlon.Margin = new System.Windows.Forms.Padding(2);
            this.btNouveauTriathlon.Name = "btNouveauTriathlon";
            this.btNouveauTriathlon.Size = new System.Drawing.Size(129, 42);
            this.btNouveauTriathlon.TabIndex = 7;
            this.btNouveauTriathlon.Text = "Nouveau triathlon";
            this.btNouveauTriathlon.UseVisualStyleBackColor = false;
            // 
            // comboBxLesTriathlons
            // 
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
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpbxTriathlons);
            this.Controls.Add(this.grpbxDetailTriathlon);
            this.Controls.Add(this.grpbxLesTriathlons);
            this.Name = "FrmTriathlon";
            this.Text = "Gestion des triathlons";
            this.grpbxTriathlons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridTriathlons)).EndInit();
            this.grpbxDetailTriathlon.ResumeLayout(false);
            this.grpbxDetailTriathlon.PerformLayout();
            this.grpbxLesTriathlons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbxTriathlons;
        private System.Windows.Forms.Button btSupprimer;
        private System.Windows.Forms.DataGridView gridTriathlons;
        private System.Windows.Forms.GroupBox grpbxDetailTriathlon;
        private System.Windows.Forms.Button btModifier;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.GroupBox grpbxLesTriathlons;
        private System.Windows.Forms.Button btNouveauTriathlon;
        private System.Windows.Forms.ComboBox comboBxLesTriathlons;
        private System.Windows.Forms.TextBox txtLieu;
        private System.Windows.Forms.Label lblLieu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimeCompet;
        private System.Windows.Forms.ComboBox comboBxLesTypesTriath;
        private System.Windows.Forms.Label lblTypeTriathlon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumCli;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomCli;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrenomCLi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVilleCli;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}