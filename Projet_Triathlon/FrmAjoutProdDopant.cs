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
    public partial class FrmAjoutProdDopant : Form
    {
        public FrmAjoutProdDopant()
        {
            InitializeComponent();
        }

        private void btAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btValider_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLibelle.Text) || string.IsNullOrWhiteSpace(txtTauxMax.Text))
            {
                MessageBox.Show("Vous devez remplir TOUS les champs !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    ProdDopant nouveauProduit = new ProdDopant(txtLibelle.Text, Convert.ToDouble(txtTauxMax.Text));

                    ClassePasserelle.AjouterProduitDop(nouveauProduit);

                    MessageBox.Show("L'ajout du produit a bien été effectuée !", "Réussie", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
