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
            this.menuItemProdDopant = new System.Windows.Forms.ToolStripMenuItem();
            this.ajoutProdMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gérerProdDopantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemTypesTriathlons = new System.Windows.Forms.ToolStripMenuItem();
            this.ajoutTypeTriathlonsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gérerTypeTriathlonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemTriathletes = new System.Windows.Forms.ToolStripMenuItem();
            this.ajoutTriathletesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gérerTriathletesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemTriathlon = new System.Windows.Forms.ToolStripMenuItem();
            this.ajoutTriathlonsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gérerTriathlonsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.classementMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemQUITTER = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuItemProdDopant
            // 
            this.menuItemProdDopant.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajoutProdMenuItem,
            this.gérerProdDopantToolStripMenuItem});
            this.menuItemProdDopant.Name = "menuItemProdDopant";
            this.menuItemProdDopant.Size = new System.Drawing.Size(104, 24);
            this.menuItemProdDopant.Text = "ProdDopant";
            // 
            // ajoutProdMenuItem
            // 
            this.ajoutProdMenuItem.Name = "ajoutProdMenuItem";
            this.ajoutProdMenuItem.Size = new System.Drawing.Size(160, 26);
            this.ajoutProdMenuItem.Text = "Nouveau...";
            this.ajoutProdMenuItem.Click += new System.EventHandler(this.ajoutProdMenuItem_Click);
            // 
            // gérerProdDopantToolStripMenuItem
            // 
            this.gérerProdDopantToolStripMenuItem.Name = "gérerProdDopantToolStripMenuItem";
            this.gérerProdDopantToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.gérerProdDopantToolStripMenuItem.Text = "Gérer";
            this.gérerProdDopantToolStripMenuItem.Click += new System.EventHandler(this.gérerProdDopantProdMenuItem_Click);
            // 
            // menuItemTypesTriathlons
            // 
            this.menuItemTypesTriathlons.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajoutTypeTriathlonsMenuItem,
            this.gérerTypeTriathlonToolStripMenuItem});
            this.menuItemTypesTriathlons.Name = "menuItemTypesTriathlons";
            this.menuItemTypesTriathlons.Size = new System.Drawing.Size(147, 24);
            this.menuItemTypesTriathlons.Text = "Types de triathlons";
            // 
            // ajoutTypeTriathlonsMenuItem
            // 
            this.ajoutTypeTriathlonsMenuItem.Name = "ajoutTypeTriathlonsMenuItem";
            this.ajoutTypeTriathlonsMenuItem.Size = new System.Drawing.Size(160, 26);
            this.ajoutTypeTriathlonsMenuItem.Text = "Nouveau...";
            this.ajoutTypeTriathlonsMenuItem.Click += new System.EventHandler(this.ajoutTypeTriathlonsMenuItem_Click);
            // 
            // gérerTypeTriathlonToolStripMenuItem
            // 
            this.gérerTypeTriathlonToolStripMenuItem.Name = "gérerTypeTriathlonToolStripMenuItem";
            this.gérerTypeTriathlonToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.gérerTypeTriathlonToolStripMenuItem.Text = "Gérer";
            this.gérerTypeTriathlonToolStripMenuItem.Click += new System.EventHandler(this.gérerTypeTriathlonToolStripMenuItem_Click);
            // 
            // menuItemTriathletes
            // 
            this.menuItemTriathletes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajoutTriathletesMenuItem,
            this.gérerTriathletesMenuItem});
            this.menuItemTriathletes.Name = "menuItemTriathletes";
            this.menuItemTriathletes.Size = new System.Drawing.Size(91, 24);
            this.menuItemTriathletes.Text = "Triathlètes";
            // 
            // ajoutTriathletesMenuItem
            // 
            this.ajoutTriathletesMenuItem.Name = "ajoutTriathletesMenuItem";
            this.ajoutTriathletesMenuItem.Size = new System.Drawing.Size(160, 26);
            this.ajoutTriathletesMenuItem.Text = "Nouveau...";
            this.ajoutTriathletesMenuItem.Click += new System.EventHandler(this.ajoutTriathletesMenuItem_Click);
            // 
            // gérerTriathletesMenuItem
            // 
            this.gérerTriathletesMenuItem.Name = "gérerTriathletesMenuItem";
            this.gérerTriathletesMenuItem.Size = new System.Drawing.Size(160, 26);
            this.gérerTriathletesMenuItem.Text = "Gérer";
            this.gérerTriathletesMenuItem.Click += new System.EventHandler(this.gérerTriathletesMenuItem_Click);
            // 
            // menuItemTriathlon
            // 
            this.menuItemTriathlon.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajoutTriathlonsMenuItem,
            this.gérerTriathlonsMenuItem,
            this.classementMenuItem});
            this.menuItemTriathlon.Name = "menuItemTriathlon";
            this.menuItemTriathlon.Size = new System.Drawing.Size(87, 24);
            this.menuItemTriathlon.Text = "Triathlons";
            // 
            // ajoutTriathlonsMenuItem
            // 
            this.ajoutTriathlonsMenuItem.Name = "ajoutTriathlonsMenuItem";
            this.ajoutTriathlonsMenuItem.Size = new System.Drawing.Size(224, 26);
            this.ajoutTriathlonsMenuItem.Text = "Nouveau...";
            this.ajoutTriathlonsMenuItem.Click += new System.EventHandler(this.ajoutTriathlonsMenuItem_Click);
            // 
            // gérerTriathlonsMenuItem
            // 
            this.gérerTriathlonsMenuItem.Name = "gérerTriathlonsMenuItem";
            this.gérerTriathlonsMenuItem.Size = new System.Drawing.Size(224, 26);
            this.gérerTriathlonsMenuItem.Text = "Gérer ";
            this.gérerTriathlonsMenuItem.Click += new System.EventHandler(this.gérerTriathlonsMenuItem_Click);
            // 
            // classementMenuItem
            // 
            this.classementMenuItem.Name = "classementMenuItem";
            this.classementMenuItem.Size = new System.Drawing.Size(224, 26);
            this.classementMenuItem.Text = "Classement";
            this.classementMenuItem.Click += new System.EventHandler(this.classementMenuItem_Click);
            // 
            // menuItemQUITTER
            // 
            this.menuItemQUITTER.Name = "menuItemQUITTER";
            this.menuItemQUITTER.Size = new System.Drawing.Size(81, 24);
            this.menuItemQUITTER.Text = "QUITTER";
            this.menuItemQUITTER.Click += new System.EventHandler(this.menuItemQUITTER_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemProdDopant,
            this.menuItemTypesTriathlons,
            this.menuItemTriathletes,
            this.menuItemTriathlon,
            this.menuItemQUITTER});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(1067, 28);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // FrmMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMDI";
            this.Text = "Projet - Gestion des triathlons";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem menuItemProdDopant;
        private System.Windows.Forms.ToolStripMenuItem menuItemTypesTriathlons;
        private System.Windows.Forms.ToolStripMenuItem menuItemTriathletes;
        private System.Windows.Forms.ToolStripMenuItem menuItemTriathlon;
        private System.Windows.Forms.ToolStripMenuItem menuItemQUITTER;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem ajoutProdMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gérerProdDopantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajoutTypeTriathlonsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gérerTypeTriathlonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajoutTriathletesMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gérerTriathletesMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajoutTriathlonsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gérerTriathlonsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem classementMenuItem;
    }
}