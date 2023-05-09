using System;
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
    public partial class FrmTriathlete : Form
    {
        public FrmTriathlete()
        {
            InitializeComponent();
        }

        private void FrmTriathlete_Load(object sender, EventArgs e)
        {
            try
            {
                //On charge la comboBox avec tous les produits de la base de données au chargement du formulaire
                bindSrcTriathlete.DataSource = ClassePasserelle.GetLesTriathletes(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void triathleteDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tabControlTriathlete.SelectedIndex = 1;
        }
    }
}
