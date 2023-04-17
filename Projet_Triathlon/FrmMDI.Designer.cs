namespace Projet_Triathlon
{
    partial class FrmMDI
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuItemProdDopant = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemTypesTriathlons = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemTriathletes = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemTriathlon = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemInscription = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemControle = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemClassement = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemQUITTER = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemProdDopant,
            this.menuItemTypesTriathlons,
            this.menuItemTriathletes,
            this.menuItemTriathlon,
            this.menuItemInscription,
            this.menuItemControle,
            this.menuItemClassement,
            this.menuItemQUITTER});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1067, 30);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuItemProdDopant
            // 
            this.menuItemProdDopant.Name = "menuItemProdDopant";
            this.menuItemProdDopant.Size = new System.Drawing.Size(104, 26);
            this.menuItemProdDopant.Text = "ProdDopant";
            this.menuItemProdDopant.Click += new System.EventHandler(this.menuItemProdDopant_Click);
            // 
            // menuItemTypesTriathlons
            // 
            this.menuItemTypesTriathlons.Name = "menuItemTypesTriathlons";
            this.menuItemTypesTriathlons.Size = new System.Drawing.Size(147, 26);
            this.menuItemTypesTriathlons.Text = "Types de triathlons";
            this.menuItemTypesTriathlons.Click += new System.EventHandler(this.menuItemTypesTriathlons_Click);
            // 
            // menuItemTriathletes
            // 
            this.menuItemTriathletes.Name = "menuItemTriathletes";
            this.menuItemTriathletes.Size = new System.Drawing.Size(91, 26);
            this.menuItemTriathletes.Text = "Triathlètes";
            this.menuItemTriathletes.Click += new System.EventHandler(this.menuItemTriathletes_Click);
            // 
            // menuItemTriathlon
            // 
            this.menuItemTriathlon.Name = "menuItemTriathlon";
            this.menuItemTriathlon.Size = new System.Drawing.Size(87, 26);
            this.menuItemTriathlon.Text = "Triathlons";
            this.menuItemTriathlon.Click += new System.EventHandler(this.menuItemTriathlon_Click);
            // 
            // menuItemInscription
            // 
            this.menuItemInscription.Name = "menuItemInscription";
            this.menuItemInscription.Size = new System.Drawing.Size(98, 26);
            this.menuItemInscription.Text = "Inscriptions";
            this.menuItemInscription.Click += new System.EventHandler(this.menuItemInscription_Click);
            // 
            // menuItemControle
            // 
            this.menuItemControle.Name = "menuItemControle";
            this.menuItemControle.Size = new System.Drawing.Size(86, 26);
            this.menuItemControle.Text = "Contrôles";
            this.menuItemControle.Click += new System.EventHandler(this.menuItemControle_Click);
            // 
            // menuItemClassement
            // 
            this.menuItemClassement.Name = "menuItemClassement";
            this.menuItemClassement.Size = new System.Drawing.Size(98, 26);
            this.menuItemClassement.Text = "Classement";
            this.menuItemClassement.Click += new System.EventHandler(this.menuItemClassement_Click);
            // 
            // menuItemQUITTER
            // 
            this.menuItemQUITTER.Name = "menuItemQUITTER";
            this.menuItemQUITTER.Size = new System.Drawing.Size(81, 26);
            this.menuItemQUITTER.Text = "QUITTER";
            this.menuItemQUITTER.Click += new System.EventHandler(this.menuItemQUITTER_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 32);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1067, 530);
            this.dataGridView1.TabIndex = 2;
            // 
            // FrmMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmMDI";
            this.Text = "Projet - Gestion des triathlons";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuItemProdDopant;
        private System.Windows.Forms.ToolStripMenuItem menuItemTypesTriathlons;
        private System.Windows.Forms.ToolStripMenuItem menuItemTriathletes;
        private System.Windows.Forms.ToolStripMenuItem menuItemTriathlon;
        private System.Windows.Forms.ToolStripMenuItem menuItemQUITTER;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem menuItemInscription;
        private System.Windows.Forms.ToolStripMenuItem menuItemControle;
        private System.Windows.Forms.ToolStripMenuItem menuItemClassement;
    }
}