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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label lblTempsCourse;
            System.Windows.Forms.Label lblTempsCyclisme;
            System.Windows.Forms.Label lblTempsNatation;
            this.grpbxLesTriathlonsCla = new System.Windows.Forms.GroupBox();
            this.comboBxLesTriathlonsCla = new System.Windows.Forms.ComboBox();
            this.bindSrcTriathlon = new System.Windows.Forms.BindingSource(this.components);
            this.grpbxLeClassement = new System.Windows.Forms.GroupBox();
            this.gridClassement = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TempsTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindSrcInscription = new System.Windows.Forms.BindingSource(this.components);
            this.grpbxTemps = new System.Windows.Forms.GroupBox();
            this.txtTempsCourse = new System.Windows.Forms.TextBox();
            this.txtTempsCyclisme = new System.Windows.Forms.TextBox();
            this.txtTempsNatation = new System.Windows.Forms.TextBox();
            this.btSupprimer = new System.Windows.Forms.Button();
            this.btModifier = new System.Windows.Forms.Button();
            lblTempsCourse = new System.Windows.Forms.Label();
            lblTempsCyclisme = new System.Windows.Forms.Label();
            lblTempsNatation = new System.Windows.Forms.Label();
            this.grpbxLesTriathlonsCla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindSrcTriathlon)).BeginInit();
            this.grpbxLeClassement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridClassement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindSrcInscription)).BeginInit();
            this.grpbxTemps.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTempsCourse
            // 
            lblTempsCourse.AutoSize = true;
            lblTempsCourse.Location = new System.Drawing.Point(1, 134);
            lblTempsCourse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblTempsCourse.Name = "lblTempsCourse";
            lblTempsCourse.Size = new System.Drawing.Size(99, 16);
            lblTempsCourse.TabIndex = 15;
            lblTempsCourse.Text = "Temps Course:";
            // 
            // lblTempsCyclisme
            // 
            lblTempsCyclisme.AutoSize = true;
            lblTempsCyclisme.Location = new System.Drawing.Point(1, 180);
            lblTempsCyclisme.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblTempsCyclisme.Name = "lblTempsCyclisme";
            lblTempsCyclisme.Size = new System.Drawing.Size(111, 16);
            lblTempsCyclisme.TabIndex = 17;
            lblTempsCyclisme.Text = "Temps Cyclisme:";
            // 
            // lblTempsNatation
            // 
            lblTempsNatation.AutoSize = true;
            lblTempsNatation.Location = new System.Drawing.Point(1, 90);
            lblTempsNatation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblTempsNatation.Name = "lblTempsNatation";
            lblTempsNatation.Size = new System.Drawing.Size(106, 16);
            lblTempsNatation.TabIndex = 19;
            lblTempsNatation.Text = "Temps Natation:";
            // 
            // grpbxLesTriathlonsCla
            // 
            this.grpbxLesTriathlonsCla.Controls.Add(this.comboBxLesTriathlonsCla);
            this.grpbxLesTriathlonsCla.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbxLesTriathlonsCla.Location = new System.Drawing.Point(15, 14);
            this.grpbxLesTriathlonsCla.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpbxLesTriathlonsCla.Name = "grpbxLesTriathlonsCla";
            this.grpbxLesTriathlonsCla.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpbxLesTriathlonsCla.Size = new System.Drawing.Size(1032, 106);
            this.grpbxLesTriathlonsCla.TabIndex = 8;
            this.grpbxLesTriathlonsCla.TabStop = false;
            this.grpbxLesTriathlonsCla.Text = "Selectionner un triathlon dans la liste :";
            // 
            // comboBxLesTriathlonsCla
            // 
            this.comboBxLesTriathlonsCla.DataSource = this.bindSrcTriathlon;
            this.comboBxLesTriathlonsCla.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBxLesTriathlonsCla.FormattingEnabled = true;
            this.comboBxLesTriathlonsCla.Location = new System.Drawing.Point(57, 38);
            this.comboBxLesTriathlonsCla.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBxLesTriathlonsCla.Name = "comboBxLesTriathlonsCla";
            this.comboBxLesTriathlonsCla.Size = new System.Drawing.Size(499, 24);
            this.comboBxLesTriathlonsCla.TabIndex = 0;
            // 
            // bindSrcTriathlon
            // 
            this.bindSrcTriathlon.DataSource = typeof(Projet_Triathlon.Triathlon);
            this.bindSrcTriathlon.CurrentChanged += new System.EventHandler(this.bindSrcTriathlon_CurrentChanged);
            // 
            // grpbxLeClassement
            // 
            this.grpbxLeClassement.Controls.Add(this.gridClassement);
            this.grpbxLeClassement.Location = new System.Drawing.Point(15, 124);
            this.grpbxLeClassement.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpbxLeClassement.Name = "grpbxLeClassement";
            this.grpbxLeClassement.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpbxLeClassement.Size = new System.Drawing.Size(761, 405);
            this.grpbxLeClassement.TabIndex = 10;
            this.grpbxLeClassement.TabStop = false;
            this.grpbxLeClassement.Text = "Le classement";
            // 
            // gridClassement
            // 
            this.gridClassement.AllowUserToAddRows = false;
            this.gridClassement.AllowUserToDeleteRows = false;
            this.gridClassement.AutoGenerateColumns = false;
            this.gridClassement.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridClassement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridClassement.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.TempsTotal});
            this.gridClassement.DataSource = this.bindSrcInscription;
            this.gridClassement.Location = new System.Drawing.Point(7, 22);
            this.gridClassement.Margin = new System.Windows.Forms.Padding(4);
            this.gridClassement.Name = "gridClassement";
            this.gridClassement.ReadOnly = true;
            this.gridClassement.RowHeadersWidth = 51;
            this.gridClassement.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridClassement.Size = new System.Drawing.Size(729, 377);
            this.gridClassement.TabIndex = 0;
            this.gridClassement.SelectionChanged += new System.EventHandler(this.gridClassement_SelectionChanged);
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
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NumDossard";
            this.dataGridViewTextBoxColumn2.HeaderText = "NumDossard";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 116;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "NumLicence";
            this.dataGridViewTextBoxColumn3.HeaderText = "NumLicence";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 111;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "TempsNatation";
            this.dataGridViewTextBoxColumn5.HeaderText = "TempsNatation";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 129;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "TempsCourse";
            this.dataGridViewTextBoxColumn6.HeaderText = "TempsCourse";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 122;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "TempsCyclisme";
            this.dataGridViewTextBoxColumn7.HeaderText = "TempsCyclisme";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 134;
            // 
            // TempsTotal
            // 
            this.TempsTotal.DataPropertyName = "TempsTotal";
            this.TempsTotal.HeaderText = "TempsTotal";
            this.TempsTotal.MinimumWidth = 6;
            this.TempsTotal.Name = "TempsTotal";
            this.TempsTotal.ReadOnly = true;
            this.TempsTotal.Width = 110;
            // 
            // bindSrcInscription
            // 
            this.bindSrcInscription.DataSource = typeof(Projet_Triathlon.Inscription);
            // 
            // grpbxTemps
            // 
            this.grpbxTemps.Controls.Add(lblTempsCourse);
            this.grpbxTemps.Controls.Add(this.txtTempsCourse);
            this.grpbxTemps.Controls.Add(lblTempsCyclisme);
            this.grpbxTemps.Controls.Add(this.txtTempsCyclisme);
            this.grpbxTemps.Controls.Add(lblTempsNatation);
            this.grpbxTemps.Controls.Add(this.txtTempsNatation);
            this.grpbxTemps.Controls.Add(this.btSupprimer);
            this.grpbxTemps.Controls.Add(this.btModifier);
            this.grpbxTemps.Location = new System.Drawing.Point(781, 124);
            this.grpbxTemps.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpbxTemps.Name = "grpbxTemps";
            this.grpbxTemps.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpbxTemps.Size = new System.Drawing.Size(311, 405);
            this.grpbxTemps.TabIndex = 12;
            this.grpbxTemps.TabStop = false;
            this.grpbxTemps.Text = "Temps";
            // 
            // txtTempsCourse
            // 
            this.txtTempsCourse.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindSrcInscription, "TempsCourse", true));
            this.txtTempsCourse.Location = new System.Drawing.Point(124, 126);
            this.txtTempsCourse.Margin = new System.Windows.Forms.Padding(4);
            this.txtTempsCourse.Name = "txtTempsCourse";
            this.txtTempsCourse.Size = new System.Drawing.Size(140, 22);
            this.txtTempsCourse.TabIndex = 16;
            // 
            // txtTempsCyclisme
            // 
            this.txtTempsCyclisme.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindSrcInscription, "TempsCyclisme", true));
            this.txtTempsCyclisme.Location = new System.Drawing.Point(124, 172);
            this.txtTempsCyclisme.Margin = new System.Windows.Forms.Padding(4);
            this.txtTempsCyclisme.Name = "txtTempsCyclisme";
            this.txtTempsCyclisme.Size = new System.Drawing.Size(140, 22);
            this.txtTempsCyclisme.TabIndex = 18;
            // 
            // txtTempsNatation
            // 
            this.txtTempsNatation.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindSrcInscription, "TempsNatation", true));
            this.txtTempsNatation.Location = new System.Drawing.Point(124, 84);
            this.txtTempsNatation.Margin = new System.Windows.Forms.Padding(4);
            this.txtTempsNatation.Name = "txtTempsNatation";
            this.txtTempsNatation.Size = new System.Drawing.Size(140, 22);
            this.txtTempsNatation.TabIndex = 20;
            // 
            // btSupprimer
            // 
            this.btSupprimer.BackColor = System.Drawing.Color.OrangeRed;
            this.btSupprimer.Location = new System.Drawing.Point(24, 247);
            this.btSupprimer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btSupprimer.Name = "btSupprimer";
            this.btSupprimer.Size = new System.Drawing.Size(113, 33);
            this.btSupprimer.TabIndex = 7;
            this.btSupprimer.Text = "Supprimer";
            this.btSupprimer.UseVisualStyleBackColor = false;
            this.btSupprimer.Click += new System.EventHandler(this.btSupprimer_Click);
            // 
            // btModifier
            // 
            this.btModifier.BackColor = System.Drawing.Color.Silver;
            this.btModifier.Location = new System.Drawing.Point(161, 247);
            this.btModifier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btModifier.Name = "btModifier";
            this.btModifier.Size = new System.Drawing.Size(104, 33);
            this.btModifier.TabIndex = 4;
            this.btModifier.Text = "Enregistrer";
            this.btModifier.UseVisualStyleBackColor = false;
            this.btModifier.Click += new System.EventHandler(this.btModifier_Click);
            // 
            // FrmClassement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(1107, 554);
            this.Controls.Add(this.grpbxTemps);
            this.Controls.Add(this.grpbxLeClassement);
            this.Controls.Add(this.grpbxLesTriathlonsCla);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmClassement";
            this.Text = "Classement";
            this.Load += new System.EventHandler(this.FrmClassement_Load);
            this.grpbxLesTriathlonsCla.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindSrcTriathlon)).EndInit();
            this.grpbxLeClassement.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridClassement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindSrcInscription)).EndInit();
            this.grpbxTemps.ResumeLayout(false);
            this.grpbxTemps.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbxLesTriathlonsCla;
        private System.Windows.Forms.ComboBox comboBxLesTriathlonsCla;
        private System.Windows.Forms.GroupBox grpbxLeClassement;
        private System.Windows.Forms.GroupBox grpbxTemps;
        private System.Windows.Forms.Button btModifier;
        private System.Windows.Forms.Button btSupprimer;
        private System.Windows.Forms.DataGridView gridClassement;
        private System.Windows.Forms.BindingSource bindSrcInscription;
        private System.Windows.Forms.BindingSource bindSrcTriathlon;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn TempsTotal;
        private System.Windows.Forms.TextBox txtTempsCourse;
        private System.Windows.Forms.TextBox txtTempsCyclisme;
        private System.Windows.Forms.TextBox txtTempsNatation;
    }
}