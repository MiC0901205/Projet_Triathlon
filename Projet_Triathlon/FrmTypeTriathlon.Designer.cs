﻿namespace Projet_Triathlon
{
    partial class FrmTypeTriathlon
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
            this.grpbxLesTypesTriathlon = new System.Windows.Forms.GroupBox();
            this.btSupprimer = new System.Windows.Forms.Button();
            this.gridTypeTriath = new System.Windows.Forms.DataGridView();
            this.colNumCli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomCli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrenomCLi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DistanceCyc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpbxDetailTypeTriath = new System.Windows.Forms.GroupBox();
            this.txtDistanceCourse = new System.Windows.Forms.TextBox();
            this.lblDistanceCourse = new System.Windows.Forms.Label();
            this.txtDistanceNatation = new System.Windows.Forms.TextBox();
            this.lblDistanceNatation = new System.Windows.Forms.Label();
            this.txtDistanceCyclisme = new System.Windows.Forms.TextBox();
            this.lblDistanceCyclisme = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.btModifier = new System.Windows.Forms.Button();
            this.txtDesignation = new System.Windows.Forms.TextBox();
            this.lblDesignation = new System.Windows.Forms.Label();
            this.grpbxLesTypesTriath = new System.Windows.Forms.GroupBox();
            this.btNouveauTypeTriath = new System.Windows.Forms.Button();
            this.comboBxLesTypesTriath = new System.Windows.Forms.ComboBox();
            this.grpbxLesTypesTriathlon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTypeTriath)).BeginInit();
            this.grpbxDetailTypeTriath.SuspendLayout();
            this.grpbxLesTypesTriath.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbxLesTypesTriathlon
            // 
            this.grpbxLesTypesTriathlon.Controls.Add(this.btSupprimer);
            this.grpbxLesTypesTriathlon.Controls.Add(this.gridTypeTriath);
            this.grpbxLesTypesTriathlon.Location = new System.Drawing.Point(230, 110);
            this.grpbxLesTypesTriathlon.Margin = new System.Windows.Forms.Padding(2);
            this.grpbxLesTypesTriathlon.Name = "grpbxLesTypesTriathlon";
            this.grpbxLesTypesTriathlon.Padding = new System.Windows.Forms.Padding(2);
            this.grpbxLesTypesTriathlon.Size = new System.Drawing.Size(559, 329);
            this.grpbxLesTypesTriathlon.TabIndex = 12;
            this.grpbxLesTypesTriathlon.TabStop = false;
            this.grpbxLesTypesTriathlon.Text = "Les types de triathlon";
            // 
            // btSupprimer
            // 
            this.btSupprimer.BackColor = System.Drawing.Color.OrangeRed;
            this.btSupprimer.Enabled = false;
            this.btSupprimer.Location = new System.Drawing.Point(238, 266);
            this.btSupprimer.Margin = new System.Windows.Forms.Padding(2);
            this.btSupprimer.Name = "btSupprimer";
            this.btSupprimer.Size = new System.Drawing.Size(142, 38);
            this.btSupprimer.TabIndex = 6;
            this.btSupprimer.Text = "Supprimer type de triathlon";
            this.btSupprimer.UseVisualStyleBackColor = false;
            // 
            // gridTypeTriath
            // 
            this.gridTypeTriath.AllowUserToAddRows = false;
            this.gridTypeTriath.AllowUserToDeleteRows = false;
            this.gridTypeTriath.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridTypeTriath.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTypeTriath.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNumCli,
            this.colNomCli,
            this.colPrenomCLi,
            this.DistanceCyc,
            this.Column1,
            this.Column2});
            this.gridTypeTriath.Location = new System.Drawing.Point(10, 19);
            this.gridTypeTriath.Margin = new System.Windows.Forms.Padding(2);
            this.gridTypeTriath.MultiSelect = false;
            this.gridTypeTriath.Name = "gridTypeTriath";
            this.gridTypeTriath.ReadOnly = true;
            this.gridTypeTriath.RowHeadersWidth = 51;
            this.gridTypeTriath.RowTemplate.Height = 28;
            this.gridTypeTriath.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridTypeTriath.Size = new System.Drawing.Size(549, 224);
            this.gridTypeTriath.TabIndex = 0;
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
            this.DistanceCyc.Name = "DistanceCyc";
            this.DistanceCyc.ReadOnly = true;
            this.DistanceCyc.Width = 92;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "DistanceNat";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 91;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "DistanceCourse";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 107;
            // 
            // grpbxDetailTypeTriath
            // 
            this.grpbxDetailTypeTriath.Controls.Add(this.txtDistanceCourse);
            this.grpbxDetailTypeTriath.Controls.Add(this.lblDistanceCourse);
            this.grpbxDetailTypeTriath.Controls.Add(this.txtDistanceNatation);
            this.grpbxDetailTypeTriath.Controls.Add(this.lblDistanceNatation);
            this.grpbxDetailTypeTriath.Controls.Add(this.txtDistanceCyclisme);
            this.grpbxDetailTypeTriath.Controls.Add(this.lblDistanceCyclisme);
            this.grpbxDetailTypeTriath.Controls.Add(this.txtNom);
            this.grpbxDetailTypeTriath.Controls.Add(this.lblNom);
            this.grpbxDetailTypeTriath.Controls.Add(this.btModifier);
            this.grpbxDetailTypeTriath.Controls.Add(this.txtDesignation);
            this.grpbxDetailTypeTriath.Controls.Add(this.lblDesignation);
            this.grpbxDetailTypeTriath.Location = new System.Drawing.Point(11, 110);
            this.grpbxDetailTypeTriath.Margin = new System.Windows.Forms.Padding(2);
            this.grpbxDetailTypeTriath.Name = "grpbxDetailTypeTriath";
            this.grpbxDetailTypeTriath.Padding = new System.Windows.Forms.Padding(2);
            this.grpbxDetailTypeTriath.Size = new System.Drawing.Size(215, 329);
            this.grpbxDetailTypeTriath.TabIndex = 11;
            this.grpbxDetailTypeTriath.TabStop = false;
            this.grpbxDetailTypeTriath.Text = "Détail du type de triathlon";
            // 
            // txtDistanceCourse
            // 
            this.txtDistanceCourse.Location = new System.Drawing.Point(12, 248);
            this.txtDistanceCourse.Margin = new System.Windows.Forms.Padding(2);
            this.txtDistanceCourse.MaxLength = 200;
            this.txtDistanceCourse.Name = "txtDistanceCourse";
            this.txtDistanceCourse.Size = new System.Drawing.Size(109, 20);
            this.txtDistanceCourse.TabIndex = 12;
            // 
            // lblDistanceCourse
            // 
            this.lblDistanceCourse.AutoSize = true;
            this.lblDistanceCourse.Location = new System.Drawing.Point(16, 230);
            this.lblDistanceCourse.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDistanceCourse.Name = "lblDistanceCourse";
            this.lblDistanceCourse.Size = new System.Drawing.Size(91, 13);
            this.lblDistanceCourse.TabIndex = 11;
            this.lblDistanceCourse.Text = "Distance Course :";
            // 
            // txtDistanceNatation
            // 
            this.txtDistanceNatation.Location = new System.Drawing.Point(12, 198);
            this.txtDistanceNatation.Margin = new System.Windows.Forms.Padding(2);
            this.txtDistanceNatation.MaxLength = 200;
            this.txtDistanceNatation.Name = "txtDistanceNatation";
            this.txtDistanceNatation.Size = new System.Drawing.Size(109, 20);
            this.txtDistanceNatation.TabIndex = 10;
            // 
            // lblDistanceNatation
            // 
            this.lblDistanceNatation.AutoSize = true;
            this.lblDistanceNatation.Location = new System.Drawing.Point(16, 180);
            this.lblDistanceNatation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDistanceNatation.Name = "lblDistanceNatation";
            this.lblDistanceNatation.Size = new System.Drawing.Size(98, 13);
            this.lblDistanceNatation.TabIndex = 9;
            this.lblDistanceNatation.Text = "Distance Natation :";
            // 
            // txtDistanceCyclisme
            // 
            this.txtDistanceCyclisme.Location = new System.Drawing.Point(12, 147);
            this.txtDistanceCyclisme.Margin = new System.Windows.Forms.Padding(2);
            this.txtDistanceCyclisme.MaxLength = 200;
            this.txtDistanceCyclisme.Name = "txtDistanceCyclisme";
            this.txtDistanceCyclisme.Size = new System.Drawing.Size(109, 20);
            this.txtDistanceCyclisme.TabIndex = 8;
            // 
            // lblDistanceCyclisme
            // 
            this.lblDistanceCyclisme.AutoSize = true;
            this.lblDistanceCyclisme.Location = new System.Drawing.Point(16, 129);
            this.lblDistanceCyclisme.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDistanceCyclisme.Name = "lblDistanceCyclisme";
            this.lblDistanceCyclisme.Size = new System.Drawing.Size(99, 13);
            this.lblDistanceCyclisme.TabIndex = 7;
            this.lblDistanceCyclisme.Text = "Distance Cyclisme :";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(12, 98);
            this.txtNom.Margin = new System.Windows.Forms.Padding(2);
            this.txtNom.MaxLength = 200;
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(155, 20);
            this.txtNom.TabIndex = 6;
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(16, 80);
            this.lblNom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(35, 13);
            this.lblNom.TabIndex = 5;
            this.lblNom.Text = "Nom :";
            // 
            // btModifier
            // 
            this.btModifier.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btModifier.Enabled = false;
            this.btModifier.Location = new System.Drawing.Point(43, 289);
            this.btModifier.Margin = new System.Windows.Forms.Padding(2);
            this.btModifier.Name = "btModifier";
            this.btModifier.Size = new System.Drawing.Size(78, 27);
            this.btModifier.TabIndex = 4;
            this.btModifier.Text = "Modifier";
            this.btModifier.UseVisualStyleBackColor = false;
            // 
            // txtDesignation
            // 
            this.txtDesignation.Location = new System.Drawing.Point(12, 48);
            this.txtDesignation.Margin = new System.Windows.Forms.Padding(2);
            this.txtDesignation.MaxLength = 200;
            this.txtDesignation.Name = "txtDesignation";
            this.txtDesignation.Size = new System.Drawing.Size(73, 20);
            this.txtDesignation.TabIndex = 1;
            // 
            // lblDesignation
            // 
            this.lblDesignation.AutoSize = true;
            this.lblDesignation.Location = new System.Drawing.Point(16, 30);
            this.lblDesignation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDesignation.Name = "lblDesignation";
            this.lblDesignation.Size = new System.Drawing.Size(69, 13);
            this.lblDesignation.TabIndex = 0;
            this.lblDesignation.Text = "Désignation :";
            // 
            // grpbxLesTypesTriath
            // 
            this.grpbxLesTypesTriath.Controls.Add(this.btNouveauTypeTriath);
            this.grpbxLesTypesTriath.Controls.Add(this.comboBxLesTypesTriath);
            this.grpbxLesTypesTriath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbxLesTypesTriath.Location = new System.Drawing.Point(11, 11);
            this.grpbxLesTypesTriath.Margin = new System.Windows.Forms.Padding(2);
            this.grpbxLesTypesTriath.Name = "grpbxLesTypesTriath";
            this.grpbxLesTypesTriath.Padding = new System.Windows.Forms.Padding(2);
            this.grpbxLesTypesTriath.Size = new System.Drawing.Size(778, 86);
            this.grpbxLesTypesTriath.TabIndex = 10;
            this.grpbxLesTypesTriath.TabStop = false;
            this.grpbxLesTypesTriath.Text = "Selectionner un type de triathlon dans la liste :";
            // 
            // btNouveauTypeTriath
            // 
            this.btNouveauTypeTriath.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btNouveauTypeTriath.Location = new System.Drawing.Point(458, 25);
            this.btNouveauTypeTriath.Margin = new System.Windows.Forms.Padding(2);
            this.btNouveauTypeTriath.Name = "btNouveauTypeTriath";
            this.btNouveauTypeTriath.Size = new System.Drawing.Size(141, 32);
            this.btNouveauTypeTriath.TabIndex = 7;
            this.btNouveauTypeTriath.Text = "Nouveau type de triathlon";
            this.btNouveauTypeTriath.UseVisualStyleBackColor = false;
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
            // FrmTypeTriathlon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpbxLesTypesTriathlon);
            this.Controls.Add(this.grpbxDetailTypeTriath);
            this.Controls.Add(this.grpbxLesTypesTriath);
            this.Name = "FrmTypeTriathlon";
            this.Text = "Gestion des types de tryathlon";
            this.grpbxLesTypesTriathlon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridTypeTriath)).EndInit();
            this.grpbxDetailTypeTriath.ResumeLayout(false);
            this.grpbxDetailTypeTriath.PerformLayout();
            this.grpbxLesTypesTriath.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbxLesTypesTriathlon;
        private System.Windows.Forms.Button btSupprimer;
        private System.Windows.Forms.DataGridView gridTypeTriath;
        private System.Windows.Forms.GroupBox grpbxDetailTypeTriath;
        private System.Windows.Forms.Button btModifier;
        private System.Windows.Forms.TextBox txtDesignation;
        private System.Windows.Forms.Label lblDesignation;
        private System.Windows.Forms.GroupBox grpbxLesTypesTriath;
        private System.Windows.Forms.Button btNouveauTypeTriath;
        private System.Windows.Forms.ComboBox comboBxLesTypesTriath;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumCli;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomCli;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrenomCLi;
        private System.Windows.Forms.DataGridViewTextBoxColumn DistanceCyc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.TextBox txtDistanceCyclisme;
        private System.Windows.Forms.Label lblDistanceCyclisme;
        private System.Windows.Forms.TextBox txtDistanceCourse;
        private System.Windows.Forms.Label lblDistanceCourse;
        private System.Windows.Forms.TextBox txtDistanceNatation;
        private System.Windows.Forms.Label lblDistanceNatation;
    }
}