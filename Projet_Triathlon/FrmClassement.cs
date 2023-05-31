using System;
using System.Windows.Forms;

namespace Projet_Triathlon
{
    public partial class FrmClassement : Form
    { 
        public FrmClassement()
        {
            InitializeComponent();
        }

        private void FrmClassement_Load(object sender, EventArgs e)
        {
            try
            {
                //On charge la comboBox avec tous les produits de la base de données au chargement du formulaire
                bindSrcTriathlon.DataSource = ClassePasserelle.GetLesTriathlons();

                // Vérifier et mettre à jour l'état du bouton "Supprimer"
                btSupprimerChangedState();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btSupprimer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous réellement supprimer ces temps ?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                {
                    ClassePasserelle.SupprimerTemps((Inscription)bindSrcInscription.Current);
                    //bindSrcInscription.RemoveCurrent();
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
                bindSrcInscription.EndEdit();
                ClassePasserelle.ModifierTemps((Inscription)bindSrcInscription.Current);

                // Vérifier et mettre à jour l'état du bouton "Supprimer"
                btSupprimerChangedState();

                MessageBox.Show("La modification a bien été effectuée !", "Réussie", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bindSrcTriathlon_CurrentChanged(object sender, EventArgs e)
        {
            bindSrcInscription.CancelEdit();
            bindSrcInscription.DataSource = ClassePasserelle.GetClassement((Triathlon)bindSrcTriathlon.Current);
        }


        private void btSupprimerChangedState()
        {
            // Vérifier si les trois champs sont à zéro et désactiver le bouton "Supprimer" si c'est le cas
            int value1, value2, value3;
            bool isNumeric1 = int.TryParse(txtTempsNatation.Text, out value1);
            bool isNumeric2 = int.TryParse(txtTempsCyclisme.Text, out value2);
            bool isNumeric3 = int.TryParse(txtTempsCourse.Text, out value3);

            btSupprimer.Enabled = !(isNumeric1 && isNumeric2 && isNumeric3 && value1 == 0 && value2 == 0 && value3 == 0);
        }

        private void bindSrcInscription_CurrentItemChanged(object sender, EventArgs e)
        {
            bindSrcInscription.CancelEdit();
        }
    }
}
