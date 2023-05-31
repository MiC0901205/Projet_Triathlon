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
    public partial class FrmAjoutTriathlete : Form
    {
        public FrmAjoutTriathlete()
        {
            InitializeComponent();
        }

        private void btValider_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNom.Text) || string.IsNullOrWhiteSpace(txtPrenom.Text) || string.IsNullOrWhiteSpace(txtCodePostal.Text) || string.IsNullOrWhiteSpace(txtVille.Text) || string.IsNullOrWhiteSpace(txtAdresse.Text) || string.IsNullOrWhiteSpace(dateTimeNaissance.Text))
            {
                MessageBox.Show("Vous devez remplir TOUS les champs !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    Triathlete nouveauTriathlete = new Triathlete(Convert.ToInt32(txtCodePostal.Text), txtNom.Text, txtPrenom.Text, txtAdresse.Text, txtVille.Text, Convert.ToDateTime(dateTimeNaissance.Text));

                    ClassePasserelle.AjouterTriathlete(nouveauTriathlete);

                    MessageBox.Show("L'ajout du triathlète a bien été effectuée !", "Réussie", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
