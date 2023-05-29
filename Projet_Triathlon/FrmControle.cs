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
    public partial class FrmControle : Form
    {
        Inscription lInscription;
        public FrmControle(Inscription uneInscription)
        {
            InitializeComponent();
            this.lInscription = uneInscription;
        }

        private void FrmControle_Load(object sender, EventArgs e)
        {
            try
            {
                //On charge la liste avec toutes les inscriptions de la base de données au chargement du formulaire
                bindSrcInscription.DataSource = ClassePasserelle.GetLesInscriptions();

                int i = 0;
                while (((Inscription)bindSrcInscription[i]).NumDossard != this.lInscription.NumDossard || ((Inscription)bindSrcInscription[i]).NumTriath != this.lInscription.NumTriath)
                { i++; }
                bindSrcInscription.Position = i;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btNouveau_Click(object sender, EventArgs e)
        {
            FrmAjoutInscription frmNewI = new FrmAjoutInscription();
            frmNewI.ShowDialog();
        }

        private void btSupprimer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous réellement supprimer cette inscription ?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                {
                    ClassePasserelle.SupprimerInscription((Inscription)bindSrcInscription.Current);
                    bindSrcInscription.RemoveCurrent();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btAjouterControle_Click(object sender, EventArgs e)
        {
            FrmAjoutControle frmNewC = new FrmAjoutControle();
            frmNewC.ShowDialog();
        }

        private void btSupprimerControle_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous réellement supprimer ce controle ?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                {
                    ClassePasserelle.SupprimerControle((Controler)bindSrcControler.Current);
                    bindSrcControler.RemoveCurrent();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void bindSrcControler_CurrentChanged(object sender, EventArgs e)
        {
            
        }

        private void bindSrcInscription_CurrentChanged(object sender, EventArgs e)
        {
            bindSrcControler.DataSource = ClassePasserelle.GetLesControlesByInscription((Inscription)bindSrcInscription.Current);
        }
    }
}
