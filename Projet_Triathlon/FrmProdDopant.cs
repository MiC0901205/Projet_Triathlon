﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_Triathlon
{
    public partial class FrmProdDopant : Form
    {
        public FrmProdDopant()
        {
            InitializeComponent();
        }

        private void FrmProdDopant_Load(object sender, EventArgs e)
        {
            try
            {
                //On charge la comboBox avec tous les produits de la base de données au chargement du formulaire
                bindSrcProdDopant.DataSource = ClassePasserelle.GetLesProduitsDop();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void prodDopantDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tabControlProdDopant.SelectedIndex = 1;
        }
    }
}