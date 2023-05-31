namespace Projet_Triathlon
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label lblCodeType;
            System.Windows.Forms.Label lblDesignation;
            System.Windows.Forms.Label lblDistanceCourse;
            System.Windows.Forms.Label lblDistanceCyclisme;
            System.Windows.Forms.Label lblDistanceNatation;
            System.Windows.Forms.Label lblNom;
            this.grpbxLesTriathlons = new System.Windows.Forms.GroupBox();
            this.triathlonDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindSrcTriathlon = new System.Windows.Forms.BindingSource(this.components);
            this.btSupprimerTriathlon = new System.Windows.Forms.Button();
            this.grpbxDetailTypeTriath = new System.Windows.Forms.GroupBox();
            this.lblCodeTypeT = new System.Windows.Forms.Label();
            this.bindSrcTypeTriathlon = new System.Windows.Forms.BindingSource(this.components);
            this.txtDesignation = new System.Windows.Forms.TextBox();
            this.txtDistanceCourse = new System.Windows.Forms.TextBox();
            this.txtDistanceCyclisme = new System.Windows.Forms.TextBox();
            this.txtDistanceNatation = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.btSupprimer = new System.Windows.Forms.Button();
            this.btModifier = new System.Windows.Forms.Button();
            this.grpbxLesTypesTriath = new System.Windows.Forms.GroupBox();
            this.btNouveau = new System.Windows.Forms.Button();
            this.comboBxLesTypesTriath = new System.Windows.Forms.ComboBox();
            lblCodeType = new System.Windows.Forms.Label();
            lblDesignation = new System.Windows.Forms.Label();
            lblDistanceCourse = new System.Windows.Forms.Label();
            lblDistanceCyclisme = new System.Windows.Forms.Label();
            lblDistanceNatation = new System.Windows.Forms.Label();
            lblNom = new System.Windows.Forms.Label();
            this.grpbxLesTriathlons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.triathlonDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindSrcTriathlon)).BeginInit();
            this.grpbxDetailTypeTriath.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindSrcTypeTriathlon)).BeginInit();
            this.grpbxLesTypesTriath.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCodeType
            // 
            lblCodeType.AutoSize = true;
            lblCodeType.Location = new System.Drawing.Point(13, 41);
            lblCodeType.Name = "lblCodeType";
            lblCodeType.Size = new System.Drawing.Size(81, 16);
            lblCodeType.TabIndex = 7;
            lblCodeType.Text = "Code Type :";
            // 
            // lblDesignation
            // 
            lblDesignation.AutoSize = true;
            lblDesignation.Location = new System.Drawing.Point(13, 112);
            lblDesignation.Name = "lblDesignation";
            lblDesignation.Size = new System.Drawing.Size(85, 16);
            lblDesignation.TabIndex = 9;
            lblDesignation.Text = "Designation :";
            // 
            // lblDistanceCourse
            // 
            lblDistanceCourse.AutoSize = true;
            lblDistanceCourse.Location = new System.Drawing.Point(13, 156);
            lblDistanceCourse.Name = "lblDistanceCourse";
            lblDistanceCourse.Size = new System.Drawing.Size(112, 16);
            lblDistanceCourse.TabIndex = 11;
            lblDistanceCourse.Text = "Distance Course :";
            // 
            // lblDistanceCyclisme
            // 
            lblDistanceCyclisme.AutoSize = true;
            lblDistanceCyclisme.Location = new System.Drawing.Point(13, 208);
            lblDistanceCyclisme.Name = "lblDistanceCyclisme";
            lblDistanceCyclisme.Size = new System.Drawing.Size(121, 16);
            lblDistanceCyclisme.TabIndex = 13;
            lblDistanceCyclisme.Text = "Distance Cyclisme:";
            // 
            // lblDistanceNatation
            // 
            lblDistanceNatation.AutoSize = true;
            lblDistanceNatation.Location = new System.Drawing.Point(13, 256);
            lblDistanceNatation.Name = "lblDistanceNatation";
            lblDistanceNatation.Size = new System.Drawing.Size(116, 16);
            lblDistanceNatation.TabIndex = 15;
            lblDistanceNatation.Text = "Distance Natation:";
            // 
            // lblNom
            // 
            lblNom.AutoSize = true;
            lblNom.Location = new System.Drawing.Point(13, 76);
            lblNom.Name = "lblNom";
            lblNom.Size = new System.Drawing.Size(42, 16);
            lblNom.TabIndex = 17;
            lblNom.Text = "Nom :";
            // 
            // grpbxLesTriathlons
            // 
            this.grpbxLesTriathlons.Controls.Add(this.triathlonDataGridView);
            this.grpbxLesTriathlons.Controls.Add(this.btSupprimerTriathlon);
            this.grpbxLesTriathlons.Location = new System.Drawing.Point(307, 135);
            this.grpbxLesTriathlons.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpbxLesTriathlons.Name = "grpbxLesTriathlons";
            this.grpbxLesTriathlons.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpbxLesTriathlons.Size = new System.Drawing.Size(745, 405);
            this.grpbxLesTriathlons.TabIndex = 12;
            this.grpbxLesTriathlons.TabStop = false;
            this.grpbxLesTriathlons.Text = "Les triathlons";
            // 
            // triathlonDataGridView
            // 
            this.triathlonDataGridView.AllowUserToAddRows = false;
            this.triathlonDataGridView.AllowUserToDeleteRows = false;
            this.triathlonDataGridView.AutoGenerateColumns = false;
            this.triathlonDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.triathlonDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.triathlonDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.triathlonDataGridView.DataSource = this.bindSrcTriathlon;
            this.triathlonDataGridView.Location = new System.Drawing.Point(5, 27);
            this.triathlonDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.triathlonDataGridView.Name = "triathlonDataGridView";
            this.triathlonDataGridView.ReadOnly = true;
            this.triathlonDataGridView.RowHeadersWidth = 51;
            this.triathlonDataGridView.RowTemplate.Height = 24;
            this.triathlonDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.triathlonDataGridView.Size = new System.Drawing.Size(733, 298);
            this.triathlonDataGridView.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "NumTriath";
            this.dataGridViewTextBoxColumn1.HeaderText = "NumTriath";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 98;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CodeTypeT";
            this.dataGridViewTextBoxColumn2.HeaderText = "CodeTypeT";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 110;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Nom";
            this.dataGridViewTextBoxColumn3.HeaderText = "Nom";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 65;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Lieu";
            this.dataGridViewTextBoxColumn4.HeaderText = "Lieu";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 61;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "DateCompet";
            this.dataGridViewTextBoxColumn5.HeaderText = "DateCompet";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 112;
            // 
            // bindSrcTriathlon
            // 
            this.bindSrcTriathlon.DataSource = typeof(Projet_Triathlon.Triathlon);
            // 
            // btSupprimerTriathlon
            // 
            this.btSupprimerTriathlon.BackColor = System.Drawing.Color.OrangeRed;
            this.btSupprimerTriathlon.Location = new System.Drawing.Point(256, 330);
            this.btSupprimerTriathlon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btSupprimerTriathlon.Name = "btSupprimerTriathlon";
            this.btSupprimerTriathlon.Size = new System.Drawing.Size(189, 47);
            this.btSupprimerTriathlon.TabIndex = 6;
            this.btSupprimerTriathlon.Text = "Supprimer ce triathlon";
            this.btSupprimerTriathlon.UseVisualStyleBackColor = false;
            this.btSupprimerTriathlon.Click += new System.EventHandler(this.btSupprimerTriathlon_Click);
            // 
            // grpbxDetailTypeTriath
            // 
            this.grpbxDetailTypeTriath.Controls.Add(this.lblCodeTypeT);
            this.grpbxDetailTypeTriath.Controls.Add(lblCodeType);
            this.grpbxDetailTypeTriath.Controls.Add(lblDesignation);
            this.grpbxDetailTypeTriath.Controls.Add(this.txtDesignation);
            this.grpbxDetailTypeTriath.Controls.Add(lblDistanceCourse);
            this.grpbxDetailTypeTriath.Controls.Add(this.txtDistanceCourse);
            this.grpbxDetailTypeTriath.Controls.Add(lblDistanceCyclisme);
            this.grpbxDetailTypeTriath.Controls.Add(this.txtDistanceCyclisme);
            this.grpbxDetailTypeTriath.Controls.Add(lblDistanceNatation);
            this.grpbxDetailTypeTriath.Controls.Add(this.txtDistanceNatation);
            this.grpbxDetailTypeTriath.Controls.Add(lblNom);
            this.grpbxDetailTypeTriath.Controls.Add(this.txtNom);
            this.grpbxDetailTypeTriath.Controls.Add(this.btSupprimer);
            this.grpbxDetailTypeTriath.Controls.Add(this.btModifier);
            this.grpbxDetailTypeTriath.Location = new System.Drawing.Point(15, 135);
            this.grpbxDetailTypeTriath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpbxDetailTypeTriath.Name = "grpbxDetailTypeTriath";
            this.grpbxDetailTypeTriath.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpbxDetailTypeTriath.Size = new System.Drawing.Size(285, 409);
            this.grpbxDetailTypeTriath.TabIndex = 11;
            this.grpbxDetailTypeTriath.TabStop = false;
            this.grpbxDetailTypeTriath.Text = "Détail du type de triathlon";
            // 
            // lblCodeTypeT
            // 
            this.lblCodeTypeT.AutoSize = true;
            this.lblCodeTypeT.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindSrcTypeTriathlon, "CodeTypeT", true));
            this.lblCodeTypeT.Location = new System.Drawing.Point(136, 41);
            this.lblCodeTypeT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodeTypeT.Name = "lblCodeTypeT";
            this.lblCodeTypeT.Size = new System.Drawing.Size(44, 16);
            this.lblCodeTypeT.TabIndex = 19;
            this.lblCodeTypeT.Text = "label1";
            // 
            // bindSrcTypeTriathlon
            // 
            this.bindSrcTypeTriathlon.DataSource = typeof(Projet_Triathlon.TypeTriathlon);
            this.bindSrcTypeTriathlon.CurrentChanged += new System.EventHandler(this.bindSrcTypeTriathlon_CurrentChanged);
            // 
            // txtDesignation
            // 
            this.txtDesignation.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindSrcTypeTriathlon, "Designation", true));
            this.txtDesignation.Location = new System.Drawing.Point(140, 106);
            this.txtDesignation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDesignation.Name = "txtDesignation";
            this.txtDesignation.Size = new System.Drawing.Size(119, 22);
            this.txtDesignation.TabIndex = 10;
            // 
            // txtDistanceCourse
            // 
            this.txtDistanceCourse.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindSrcTypeTriathlon, "DistanceCourse", true));
            this.txtDistanceCourse.Location = new System.Drawing.Point(140, 150);
            this.txtDistanceCourse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDistanceCourse.Name = "txtDistanceCourse";
            this.txtDistanceCourse.Size = new System.Drawing.Size(119, 22);
            this.txtDistanceCourse.TabIndex = 12;
            // 
            // txtDistanceCyclisme
            // 
            this.txtDistanceCyclisme.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindSrcTypeTriathlon, "DistanceCyclisme", true));
            this.txtDistanceCyclisme.Location = new System.Drawing.Point(140, 202);
            this.txtDistanceCyclisme.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDistanceCyclisme.Name = "txtDistanceCyclisme";
            this.txtDistanceCyclisme.Size = new System.Drawing.Size(119, 22);
            this.txtDistanceCyclisme.TabIndex = 14;
            // 
            // txtDistanceNatation
            // 
            this.txtDistanceNatation.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindSrcTypeTriathlon, "DistanceNatation", true));
            this.txtDistanceNatation.Location = new System.Drawing.Point(140, 250);
            this.txtDistanceNatation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDistanceNatation.Name = "txtDistanceNatation";
            this.txtDistanceNatation.Size = new System.Drawing.Size(119, 22);
            this.txtDistanceNatation.TabIndex = 16;
            // 
            // txtNom
            // 
            this.txtNom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindSrcTypeTriathlon, "Nom", true));
            this.txtNom.Location = new System.Drawing.Point(68, 69);
            this.txtNom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(201, 22);
            this.txtNom.TabIndex = 18;
            // 
            // btSupprimer
            // 
            this.btSupprimer.BackColor = System.Drawing.Color.OrangeRed;
            this.btSupprimer.Location = new System.Drawing.Point(125, 356);
            this.btSupprimer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btSupprimer.Name = "btSupprimer";
            this.btSupprimer.Size = new System.Drawing.Size(109, 33);
            this.btSupprimer.TabIndex = 7;
            this.btSupprimer.Text = "Supprimer";
            this.btSupprimer.UseVisualStyleBackColor = false;
            this.btSupprimer.Click += new System.EventHandler(this.btSupprimer_Click);
            // 
            // btModifier
            // 
            this.btModifier.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btModifier.Location = new System.Drawing.Point(16, 356);
            this.btModifier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btModifier.Name = "btModifier";
            this.btModifier.Size = new System.Drawing.Size(104, 33);
            this.btModifier.TabIndex = 4;
            this.btModifier.Text = "Modifier";
            this.btModifier.UseVisualStyleBackColor = false;
            this.btModifier.Click += new System.EventHandler(this.btModifier_Click);
            // 
            // grpbxLesTypesTriath
            // 
            this.grpbxLesTypesTriath.Controls.Add(this.btNouveau);
            this.grpbxLesTypesTriath.Controls.Add(this.comboBxLesTypesTriath);
            this.grpbxLesTypesTriath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbxLesTypesTriath.Location = new System.Drawing.Point(15, 14);
            this.grpbxLesTypesTriath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpbxLesTypesTriath.Name = "grpbxLesTypesTriath";
            this.grpbxLesTypesTriath.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpbxLesTypesTriath.Size = new System.Drawing.Size(1037, 106);
            this.grpbxLesTypesTriath.TabIndex = 10;
            this.grpbxLesTypesTriath.TabStop = false;
            this.grpbxLesTypesTriath.Text = "Selectionner un type de triathlon dans la liste :";
            // 
            // btNouveau
            // 
            this.btNouveau.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btNouveau.Location = new System.Drawing.Point(611, 21);
            this.btNouveau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btNouveau.Name = "btNouveau";
            this.btNouveau.Size = new System.Drawing.Size(188, 49);
            this.btNouveau.TabIndex = 7;
            this.btNouveau.Text = "Nouveau type de triathlon";
            this.btNouveau.UseVisualStyleBackColor = false;
            // 
            // comboBxLesTypesTriath
            // 
            this.comboBxLesTypesTriath.DataSource = this.bindSrcTypeTriathlon;
            this.comboBxLesTypesTriath.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBxLesTypesTriath.FormattingEnabled = true;
            this.comboBxLesTypesTriath.Location = new System.Drawing.Point(57, 38);
            this.comboBxLesTypesTriath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBxLesTypesTriath.Name = "comboBxLesTypesTriath";
            this.comboBxLesTypesTriath.Size = new System.Drawing.Size(499, 24);
            this.comboBxLesTypesTriath.TabIndex = 0;
            // 
            // FrmTypeTriathlon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.grpbxLesTriathlons);
            this.Controls.Add(this.grpbxDetailTypeTriath);
            this.Controls.Add(this.grpbxLesTypesTriath);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmTypeTriathlon";
            this.Text = "Gestion des types de triathlon";
            this.Load += new System.EventHandler(this.FrmTypeTriathlon_Load);
            this.grpbxLesTriathlons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.triathlonDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindSrcTriathlon)).EndInit();
            this.grpbxDetailTypeTriath.ResumeLayout(false);
            this.grpbxDetailTypeTriath.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindSrcTypeTriathlon)).EndInit();
            this.grpbxLesTypesTriath.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbxLesTriathlons;
        private System.Windows.Forms.Button btSupprimerTriathlon;
        private System.Windows.Forms.GroupBox grpbxDetailTypeTriath;
        private System.Windows.Forms.Button btModifier;
        private System.Windows.Forms.GroupBox grpbxLesTypesTriath;
        private System.Windows.Forms.Button btNouveau;
        private System.Windows.Forms.ComboBox comboBxLesTypesTriath;
        private System.Windows.Forms.Button btSupprimer;
        private System.Windows.Forms.BindingSource bindSrcTypeTriathlon;
        private System.Windows.Forms.TextBox txtDesignation;
        private System.Windows.Forms.TextBox txtDistanceCourse;
        private System.Windows.Forms.TextBox txtDistanceCyclisme;
        private System.Windows.Forms.TextBox txtDistanceNatation;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.DataGridView triathlonDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.BindingSource bindSrcTriathlon;
        private System.Windows.Forms.Label lblCodeTypeT;
    }
}