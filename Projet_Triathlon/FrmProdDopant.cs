using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace Projet_Triathlon
{
    public partial class FrmProdDopant : Form
    {
        ProdDopant unProduit;
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

        private void btAjouter_Click(object sender, EventArgs e)
        {
            FrmAjoutProdDopant form = new FrmAjoutProdDopant();
            form.ShowDialog();
            tabControlProdDopant.SelectedIndex = 0;
            bindSrcProdDopant.DataSource = ClassePasserelle.GetLesProduitsDop();
        }

        private void btEnregistrer_Click(object sender, EventArgs e)
        {
            try
            {
                bindSrcProdDopant.EndEdit();
                ClassePasserelle.ModifierProduitsDop((ProdDopant)bindSrcProdDopant.Current);

                MessageBox.Show("La modification a bien été effectuée !", "Réussie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tabControlProdDopant.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btAnnuler_Click(object sender, EventArgs e)
        {
            ProdDopant temp = (ProdDopant)bindSrcProdDopant.Current;
            if (unProduit.CodeDop != temp.CodeDop)
            {
                temp.CodeDop = unProduit.CodeDop;
            } 
            if (unProduit.Libelle != temp.Libelle)
            {
                temp.Libelle = unProduit.Libelle;
            }
            if (unProduit.TauxMax != temp.TauxMax)
            {
                temp.TauxMax = unProduit.TauxMax;
            }
            bindSrcProdDopant.CancelEdit();
            bindSrcProdDopant.ResetBindings(false);
            tabControlProdDopant.SelectedIndex = 0;
        }

        private void btSupprimer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous réellement supprimer ce produit ?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                {
                    ClassePasserelle.SupprimerProduitDop((ProdDopant)bindSrcProdDopant.Current);
                    bindSrcProdDopant.RemoveCurrent();
                    MessageBox.Show("La suppression du produit a bien été effectuée !", "Réussie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tabControlProdDopant.SelectedIndex = 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tabControlProdDopant_SelectedIndexChanged(object sender, EventArgs e)
        {
            bindSrcProdDopant.CancelEdit();
            bindSrcProdDopant.ResetBindings(false);
            ProdDopant temp = (ProdDopant)bindSrcProdDopant.Current;
            unProduit = new ProdDopant(temp.CodeDop, temp.Libelle, temp.TauxMax);
        }
    }
}