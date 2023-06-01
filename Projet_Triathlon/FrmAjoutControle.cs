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
    public partial class FrmAjoutControle : Form
    {
        public FrmAjoutControle()
        {
            InitializeComponent();
        }


        private void FrmAjoutControle_Load(object sender, EventArgs e)
        {
            try
            {
                // Récupérer tous les NumTriath distincts
                List<int> numTriathsDistincts = ClassePasserelle.GetLesControles()
                    .Select(controle => controle.NumTriath)
                    .Distinct()
                    .OrderBy(controle => controle)
                    .ToList();

                // Récupérer tous les NumDossard distincts
                List<int> numCodeDopDistincts = ClassePasserelle.GetLesControles()
                    .Select(controle => controle.CodeDop)
                    .Distinct()
                    .ToList();

                comboBxLesNumTriath.DataSource = numTriathsDistincts;

                comboBxLesCodeDop.DataSource = numCodeDopDistincts;

                comboBxLesNumTriath.SelectedIndex = -1;
                comboBxLesCodeDop.SelectedIndex = -1;
                comboBxLesNumDossard.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBxLesNumTriath_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBxLesNumTriath.SelectedItem != null)
            {
                int selectedNumTriath = (int)comboBxLesNumTriath.SelectedItem;

                // Filtrer les controles par le NumTriath sélectionné
                List<Inscription> controles = ClassePasserelle.GetLesInscriptions()
                    .Where(controle => controle.NumTriath == selectedNumTriath)
                    .ToList();

                comboBxLesNumDossard.DataSource = controles;
                comboBxLesNumDossard.DisplayMember = "NumDossard";
            }
        }

        private void btValider_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(comboBxLesCodeDop.Text) || string.IsNullOrWhiteSpace(comboBxLesNumTriath.Text) || string.IsNullOrWhiteSpace(comboBxLesNumDossard.Text) || string.IsNullOrWhiteSpace(txtMesureEtablie.Text))
            {
                MessageBox.Show("Vous devez remplir TOUS les champs !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    Controler nouveauControle = new Controler(Convert.ToInt32(comboBxLesNumTriath.Text), Convert.ToInt32(comboBxLesNumDossard.Text), Convert.ToInt32(comboBxLesCodeDop.Text), Convert.ToDouble(txtMesureEtablie.Text));

                    ClassePasserelle.AjouterControle(nouveauControle);

                    MessageBox.Show("L'ajout du contrôle a bien été effectuée !", "Réussie", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    bindSrcControler.DataSource = ClassePasserelle.GetLesControles();

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
