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
    public partial class FrmAjoutTriathlon : Form
    {
        public FrmAjoutTriathlon()
        {
            InitializeComponent();
        }

        private void btValider_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNom.Text) || string.IsNullOrWhiteSpace(txtLieu.Text) || string.IsNullOrWhiteSpace(dateTimeCompet.Text) || string.IsNullOrWhiteSpace(comboBxLesTypesTriath.Text))
            {
                MessageBox.Show("Vous devez remplir TOUS les champs !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    Triathlon nouveauTriathlon = new Triathlon(txtNom.Text, txtLieu.Text, Convert.ToDateTime(dateTimeCompet.Text), Convert.ToInt32(comboBxLesTypesTriath.Text));

                    ClassePasserelle.AjouterTriathlon(nouveauTriathlon);

                    MessageBox.Show("L'ajout du triathlon a bien été effectuée !", "Réussie", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
