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
                bindSrcTypeTriathlon.DataSource = ClassePasserelle.GetLesTypesTriathlon();
                bindSrcTriathlon.DataSource = ClassePasserelle.GetLesTriathlons();
                bindSrcInscription.DataSource = ClassePasserelle.GetLesInscriptionsByTriathlon((Triathlon)bindSrcTriathlon.Current);


                foreach (Triathlon unT in this.bindSrcTriathlon)
                {
                    int i = 0;
                    while (((TypeTriathlon)this.bindSrcTypeTriathlon[i]).CodeTypeT != unT.CodeTypeT)
                    {
                        i++;
                    }
                    unT.UnTypeTriathlon = (TypeTriathlon)this.bindSrcTypeTriathlon[i];

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void bindSrcTriathlon_CurrentChanged(object sender, EventArgs e)
        {
            bindSrcInscription.DataSource = ClassePasserelle.GetLesInscriptionsByTriathlon((Triathlon)bindSrcTriathlon.Current);
        }

        private void gridInscriptions_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmControle frmC  = new FrmControle();
            frmC.ShowDialog();
        }
    }
}
