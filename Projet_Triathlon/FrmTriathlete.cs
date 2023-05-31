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
        Triathlete unTriathlete;

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

        private void btAjouter_Click(object sender, EventArgs e)
        {
            FrmAjoutTriathlete form = new FrmAjoutTriathlete();
            form.ShowDialog();
            tabControlTriathlete.SelectedIndex = 0;
            bindSrcTriathlete.DataSource = ClassePasserelle.GetLesTriathletes();
        }

        private void btEnregistrer_Click(object sender, EventArgs e)
        {
            try
            {
                bindSrcTriathlete.EndEdit();
                ClassePasserelle.ModifierTriathlete((Triathlete)bindSrcTriathlete.Current);

                MessageBox.Show("La modification a bien été effectuée !", "Réussie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tabControlTriathlete.SelectedIndex = 0;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btAnnuler_Click(object sender, EventArgs e)
        {
            Triathlete temp = (Triathlete)bindSrcTriathlete.Current;
            if (unTriathlete.Cp != temp.Cp)
            {
                temp.Cp = unTriathlete.Cp;
            }
            if (unTriathlete.Nom != temp.Nom)
            {
                temp.Nom = unTriathlete.Nom;
            }
            if (unTriathlete.Prenom != temp.Prenom)
            {
                temp.Prenom = unTriathlete.Prenom;
            }
            if (unTriathlete.Adresse != temp.Adresse)
            {
                temp.Adresse = unTriathlete.Adresse;
            }
            if (unTriathlete.Ville != temp.Ville)
            {
                temp.Ville = unTriathlete.Ville;
            }
            if (unTriathlete.DateNaissance != temp.DateNaissance)
            {
                temp.DateNaissance = unTriathlete.DateNaissance;
            }
            bindSrcTriathlete.CancelEdit();
            bindSrcTriathlete.ResetBindings(false);
            tabControlTriathlete.SelectedIndex = 0;
        }

        private void btSupprimer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous réellement supprimer ce triathlète ?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                {
                    ClassePasserelle.SupprimerTriathlete((Triathlete)bindSrcTriathlete.Current);
                    bindSrcTriathlete.RemoveCurrent();
                    MessageBox.Show("La suppression du triathlète a bien été effectuée !", "Réussie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tabControlTriathlete.SelectedIndex = 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tabControlTriathlete_SelectedIndexChanged(object sender, EventArgs e)
        {
            Triathlete temp = (Triathlete)bindSrcTriathlete.Current;
            unTriathlete = new Triathlete(temp.Cp, temp.Nom, temp.Prenom, temp.Adresse, temp.Ville, temp.DateNaissance);
        }
    }
}
