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
    public partial class FrmAjoutInscription : Form
    {
        public FrmAjoutInscription()
        {
            InitializeComponent();
        }

        private void FrmAjoutInscription_Load(object sender, EventArgs e)
        {
            try
            {
                // Récupérer tous les NumTriath distincts
                List<int> numTriathsDistincts = ClassePasserelle.GetLesInscriptions()
                    .Select(controle => controle.NumTriath)
                    .Distinct()
                    .OrderBy(controle => controle)
                    .ToList();

                // Récupérer tous les NumDossard distincts
                List<int> numLicenceDistincts = ClassePasserelle.GetLesInscriptions()
                    .Select(controle => controle.NumLicence)
                    .Distinct()
                    .OrderBy(controle => controle)
                    .ToList();

                comboBxLesNumTriath.DataSource = numTriathsDistincts;

                comboBxLesNumLicence.DataSource = numLicenceDistincts;

                comboBxLesNumTriath.SelectedIndex = -1;
                comboBxLesNumLicence.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btValider_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(comboBxLesNumTriath.Text) || string.IsNullOrWhiteSpace(comboBxLesNumLicence.Text))
            {
                MessageBox.Show("Vous devez remplir TOUS les champs !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    DateTime dateInscription = DateTime.Now;

                    Inscription nouvelleInscription = new Inscription(Convert.ToInt32(comboBxLesNumTriath.Text), Convert.ToInt32(comboBxLesNumLicence.Text), dateInscription);

                    ClassePasserelle.AjouterInscription(nouvelleInscription);

                    MessageBox.Show("L'ajout du produit a bien été effectuée !", "Réussie", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
