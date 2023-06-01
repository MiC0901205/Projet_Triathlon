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
    public partial class FrmAjoutTypeTriathlon : Form
    {
        public FrmAjoutTypeTriathlon()
        {
            InitializeComponent();
        }

        private void btAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btValider_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDesignation.Text) || string.IsNullOrWhiteSpace(txtNom.Text) || string.IsNullOrWhiteSpace(txtDistanceCourse.Text) || string.IsNullOrWhiteSpace(txtDistanceCyclisme.Text) || string.IsNullOrWhiteSpace(txtDistanceNatation.Text))
            {
                MessageBox.Show("Vous devez remplir TOUS les champs !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    TypeTriathlon nouveauType = new TypeTriathlon(txtDesignation.Text, txtNom.Text, Convert.ToInt32(txtDistanceCyclisme.Text), Convert.ToInt32(txtDistanceNatation.Text), Convert.ToInt32(txtDistanceCourse.Text));

                    ClassePasserelle.AjouterTypeTriathlon(nouveauType);

                    MessageBox.Show("L'ajout du type de triathlon a bien été effectuée !", "Réussie", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
