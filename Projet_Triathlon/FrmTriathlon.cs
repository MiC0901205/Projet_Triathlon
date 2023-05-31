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
    public partial class FrmTriathlon : Form
    {
        public FrmTriathlon()
        {
            InitializeComponent();
        }

        private void FrmTriathlon_Load(object sender, EventArgs e)
        {
            try
            {
                List<Triathlon> lesTriath = ClassePasserelle.GetLesTriathlons();
                bindSrcTypeTriathlon.DataSource = ClassePasserelle.GetLesTypesTriathlon();


                foreach (Triathlon unT in lesTriath)
                {
                    int i = 0;
                    while (((TypeTriathlon)this.bindSrcTypeTriathlon[i]).CodeTypeT != unT.CodeTypeT)
                    {
                        i++;
                    }
                    unT.UnTypeTriathlon = (TypeTriathlon)this.bindSrcTypeTriathlon[i];

                }

                bindSrcTriathlon.DataSource = lesTriath;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void bindSrcTriathlon_CurrentChanged(object sender, EventArgs e)
        {
            bindSrcInscription.DataSource = ClassePasserelle.GetLesInscriptionsByTriathlon((Triathlon)bindSrcTriathlon.Current);
            //bindSrcTriathlon.CancelEdit();
        }

        private void gridInscriptions_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmControle frmC  = new FrmControle((Inscription)bindSrcInscription.Current);
            frmC.ShowDialog();
        }

        private void btNouveauTriathlon_Click(object sender, EventArgs e)
        {
            FrmAjoutTriathlon frmNewT = new FrmAjoutTriathlon();
            frmNewT.ShowDialog();
        }

        private void btModifier_Click(object sender, EventArgs e)
        {
            try
            {
                bindSrcTriathlon.EndEdit();
                ClassePasserelle.ModifierTriathlon((Triathlon)bindSrcTriathlon.Current);

                MessageBox.Show("La modification a bien été effectuée !", "Réussie", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void btNouvelleInscription_Click(object sender, EventArgs e)
        {
            FrmAjoutInscription frmNewI = new FrmAjoutInscription();
            frmNewI.ShowDialog();
        }

        private void btSupprimerInscription_Click(object sender, EventArgs e)
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
    }
}
