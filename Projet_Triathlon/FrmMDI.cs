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
    public partial class FrmMDI : Form
    {
        public FrmMDI()
        {
            InitializeComponent();
        }

        private void menuItemProdDopant_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FrmProdDopant"] == null)
            {
                FrmProdDopant unFrmProdDopant = new FrmProdDopant();
                unFrmProdDopant.MdiParent = this;
                unFrmProdDopant.Show();
            }
            else
            {
                Application.OpenForms["FrmProdDopant"].BringToFront();
            }
        }

        private void menuItemQUITTER_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuItemTypesTriathlons_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FrmTypeTriathlon"] == null)
            {
                FrmTypeTriathlon unFrmTypeTriathlon = new FrmTypeTriathlon();
                unFrmTypeTriathlon.MdiParent = this;
                unFrmTypeTriathlon.Show();
            }
            else
            {
                Application.OpenForms["FrmTypeTriathlon"].BringToFront();
            }
        }

        private void menuItemTriathletes_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FrmTriathlete"] == null)
            {
                FrmTriathlete unFrmTriathlete = new FrmTriathlete();
                unFrmTriathlete.MdiParent = this;
                unFrmTriathlete.Show();
            }
            else
            {
                Application.OpenForms["FrmTriathlete"].BringToFront();
            }
        }

        private void menuItemTriathlon_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FrmTriathlon"] == null)
            {
                FrmTriathlon unFrmTriathlon = new FrmTriathlon();
                unFrmTriathlon.MdiParent = this;
                unFrmTriathlon.Show();
            }
            else
            {
                Application.OpenForms["FrmTriathlon"].BringToFront();
            }
        }

        private void menuItemInscription_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FrmInscription"] == null)
            {
                FrmInscription unFrmInscription = new FrmInscription();
                unFrmInscription.MdiParent = this;
                unFrmInscription.Show();
            }
            else
            {
                Application.OpenForms["FrmInscription"].BringToFront();
            }
        }

        private void menuItemControle_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FrmControle"] == null)
            {
                FrmControle unFrmControle = new FrmControle();
                unFrmControle.MdiParent = this;
                unFrmControle.Show();
            }
            else
            {
                Application.OpenForms["FrmControle"].BringToFront();
            }
        }

        private void menuItemClassement_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FrmClassement"] == null)
            {
                FrmClassement unFrmClassement = new FrmClassement();
                unFrmClassement.MdiParent = this;
                unFrmClassement.Show();
            }
            else
            {
                Application.OpenForms["FrmClassement"].BringToFront();
            }
        }
    }
}
