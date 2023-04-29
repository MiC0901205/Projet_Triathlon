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
    public partial class FrmProdDopant : Form
    {
        public FrmProdDopant()
        {
            InitializeComponent();
        }

        private void FrmProdDopant_Load(object sender, EventArgs e)
        {
            try
            {
                //On charge la comboBox avec tous les produits de la base de données au chargement du formulaire
                comboBxLesProdsDop.DataSource = ClassePasserelle.GetLesProduitsDop();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //this.Close();
            }
        }

        private void comboBxLesProdsDop_SelectedIndexChanged(object sender, EventArgs e)
        {
            //A chaque changement d'index dans la comboBox, on récupère le produit selectionné
            ProdDopant produitSelectionne = (ProdDopant)comboBxLesProdsDop.SelectedItem;
            if (produitSelectionne != null)
            {
                //On affiche son détail dans les TextBox
                AfficheDetailVoyage(produitSelectionne);
                //On modifie l'accessibilité les boutons (afin d'éviter les erreurs !)
                btModifier.Enabled = btNouveauProdDop.Enabled = true;
            }
            else
            {
                btModifier.Enabled = btNouveauProdDop.Enabled = false;
            }
        }

        /// <summary>
        /// Méthode qui se charge d'affecter aux différents composants graphique les données du produit passé en paramètre.
        /// </summary>
        /// <param name="unProduit">Objet que l'on souhaite afficher</param>
        private void AfficheDetailVoyage(ProdDopant unProduit)
        {
            //On affiche dans les différents composants les données de l'objet produit passé en paramètre
            txtLibelle.Text = unProduit.Libelle;
            txtTauxMax.Text = unProduit.TauxMax.ToString();

            //On affiche la liste des clients
            #region 3.1.4. Compléter les commentaires
            gridProdDop.Rows.Clear(); // Efface les lignes actuelles du dataGrid
            btSupprimer.Enabled = false; // Rend innacessible le bouton "Supprimer"
            #endregion
        }

        private void btModifier_Click(object sender, EventArgs e)
        {
            ProdDopant produitSelectionne = (ProdDopant)comboBxLesProdsDop.SelectedItem;
            if (string.IsNullOrWhiteSpace(txtLibelle.Text) || string.IsNullOrWhiteSpace(txtTauxMax.Text))
            {
                MessageBox.Show("Vous devez remplir TOUS les champs !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (double.Parse(txtTauxMax.Text) < 0)
            {
                MessageBox.Show("Le nouveau taux max du produit ne peut pas être inférieur à 0.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //On demande à l'utilisateur de confirmer la modification
                if (MessageBox.Show("Etes-vous sûr de vouloir modifier le voyage ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        //L'utilisateur confirme la modification des valeurs
                        ClassePasserelle.ModifierProduitsDop(produitSelectionne.CodDop, txtLibelle.Text, double.Parse(txtTauxMax.Text));

                        #region 3.2.2. Compléter les commentaires
                        //On actualise la comboBox
                        int index = comboBxLesProdsDop.SelectedIndex; // On mémorise l'indice actuellement sélectionné de la comboBox
                        //Cela permet de se souvenir du voyage que l'utilisateur vient de modifier
                        comboBxLesProdsDop.DataSource = ClassePasserelle.GetLesProduitsDop(); // On charge la comboBox avec tous les produits de la base de données au chargement du formulaire
                        comboBxLesProdsDop.SelectedIndex = index; //On sectionne l'indice sur lequel était l'utilisateur
                        //Afin d'afficher le produit que l'utilisateur vient de modifier et de rendre transparent la réinitialisation
                        #endregion
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    //On affiche à nouveau le détail du produit
                    txtLibelle.Text = produitSelectionne.Libelle;
                    txtTauxMax.Text = produitSelectionne.TauxMax.ToString();
                }
            }
        }

        private void btSupprimer_Click(object sender, EventArgs e)
        {
            //On récupère le code du produit
            int codeProd = Convert.ToInt32(gridProdDop.SelectedRows[0].Cells[0].Value);
            string libelle = gridProdDop.SelectedRows[0].Cells[1].Value.ToString();
            string tauxMax = gridProdDop.SelectedRows[0].Cells[2].Value.ToString();
            string msg = "Etes-vous sûr de vouloir supprimer le produit : " + libelle + " ?";
            //On demande à l'utilisateur de confirmer la suppression
            if (MessageBox.Show(msg, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    ClassePasserelle.SupprimerProduitDop(codeProd);

                    //On enlève le client du DataGrid
                    gridProdDop.Rows.Remove(gridProdDop.SelectedRows[0]);
                    if (gridProdDop.Rows.Count == 0)
                    {
                        btSupprimer.Enabled = false;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btNouveauProdDop_Click(object sender, EventArgs e)
        {
            //On instancie le formulaire de saisie d'un nouveau produit
            FrmAjoutProdDopant unFrmAjoutProdDop = new FrmAjoutProdDopant();
            unFrmAjoutProdDop.ShowDialog();

            comboBxLesProdsDop.DataSource = ClassePasserelle.GetLesProduitsDop(); // On charge la comboBox avec tous les produits de la base de données dès l'appui du boutton nouveau produit
            comboBxLesProdsDop.SelectedIndex = comboBxLesProdsDop.Items.Count - 1; // Sélectionne un index dans la combobox
        }

    }
}