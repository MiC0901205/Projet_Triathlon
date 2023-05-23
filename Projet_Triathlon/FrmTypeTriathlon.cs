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
    public partial class FrmTypeTriathlon : Form
    {
        public FrmTypeTriathlon()
        {
            InitializeComponent();
        }

        private void FrmTypeTriathlon_Load(object sender, EventArgs e)
        {
            try
            {
                //On charge la comboBox avec tous les produits de la base de données au chargement du formulaire
                bindSrcTypeTriathlon.DataSource = ClassePasserelle.GetLesTypesTriathlon();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bindSrcTypeTriathlon_CurrentChanged(object sender, EventArgs e)
        {
            bindSrcTriathlon.DataSource = ClassePasserelle.GetLesTriathlonsByType((TypeTriathlon)bindSrcTypeTriathlon.Current);
            //bindSrcTypeTriathlon.CancelEdit();
        }

        private void btSupprimerTriathlon_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous réellement supprimer ce triathlon ?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                {
                    ClassePasserelle.SupprimerTriathlon((Triathlon)bindSrcTriathlon.Current);
                    bindSrcTriathlon.RemoveCurrent();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btSupprimer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous réellement supprimer ce type de triathlon ?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                {
                    ClassePasserelle.SupprimerTypeTriahtlon((TypeTriathlon)bindSrcTypeTriathlon.Current);
                    bindSrcTypeTriathlon.RemoveCurrent();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btModifier_Click(object sender, EventArgs e)
        {
            try
            {
                bindSrcTypeTriathlon.EndEdit();
                ClassePasserelle.ModifierTypeTriathlon((TypeTriathlon)bindSrcTypeTriathlon.Current);

                MessageBox.Show("La modification a bien été effectuée !", "Réussie", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
