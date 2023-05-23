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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btSupprime_Click(object sender, EventArgs e)
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

        private void bindSrcInscription_CurrentChanged(object sender, EventArgs e)
        {
            //bindSrcInscription.CancelEdit();
        }
    }
}
