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

        private void ajoutProdMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FrmAjoutProdDopant"] == null)
            {
                this.ActiveMdiChild?.Close();
                FrmAjoutProdDopant unFrmAjoutProdDopant = new FrmAjoutProdDopant();
                unFrmAjoutProdDopant.MdiParent = this;
                unFrmAjoutProdDopant.Show();
            } 
            else
            {
                Application.OpenForms["FrmAjoutProdDopant"].BringToFront();
            }
        }

        private void gérerProdDopantProdMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FrmProdDopant"] == null)
            {
                this.ActiveMdiChild?.Close();
                FrmProdDopant unFrmProdDopant = new FrmProdDopant();
                unFrmProdDopant.MdiParent = this;
                unFrmProdDopant.Show();
            }
            else
            {
                Application.OpenForms["FrmProdDopant"].BringToFront();
            }
        }

        private void ajoutTypeTriathlonsMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FrmAjoutTypeTriathlon"] == null)
            {
                this.ActiveMdiChild?.Close();
                FrmAjoutTypeTriathlon unFrmAjoutTypeTriathlon = new FrmAjoutTypeTriathlon();
                unFrmAjoutTypeTriathlon.MdiParent = this;
                unFrmAjoutTypeTriathlon.Show();
            }
            else
            {
                Application.OpenForms["FrmAjoutTypeTriathlon"].BringToFront();
            }
        }

        private void gérerTypeTriathlonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FrmTypeTriathlon"] == null)
            {
                this.ActiveMdiChild?.Close();
                FrmTypeTriathlon unFrmTypeTriathlon = new FrmTypeTriathlon();
                unFrmTypeTriathlon.MdiParent = this;
                unFrmTypeTriathlon.Show();
            }
            else
            {
                Application.OpenForms["FrmTypeTriathlon"].BringToFront();
            }
        }

        private void ajoutTriathletesMenuItem_Click(object sender, EventArgs e)
        { 
            if(Application.OpenForms["FrmAjoutTriathlete"] == null)
            {
                this.ActiveMdiChild?.Close();
                FrmAjoutTriathlete unFrmAjoutTriathlete = new FrmAjoutTriathlete();
                unFrmAjoutTriathlete.MdiParent = this;
                unFrmAjoutTriathlete.Show();
            }
            else
            {
                Application.OpenForms["FrmAjoutTriathlete"].BringToFront();
            }
        }

        private void gérerTriathletesMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FrmTriathlete"] == null)
            {
                this.ActiveMdiChild?.Close();
                FrmTriathlete unFrmTriathlete = new FrmTriathlete();
                unFrmTriathlete.MdiParent = this;
                unFrmTriathlete.Show();
            }
            else
            {
                Application.OpenForms["FrmTriathlete"].BringToFront();
            }
        }

        private void ajoutTriathlonsMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FrmAjoutTriathlon"] == null)
            {
                this.ActiveMdiChild?.Close();
                FrmAjoutTriathlon unFrmAjoutTriathlon = new FrmAjoutTriathlon();
                unFrmAjoutTriathlon.MdiParent = this;
                unFrmAjoutTriathlon.Show();
            }
            else
            {
                Application.OpenForms["FrmAjoutTriathlon"].BringToFront();
            }
        }

        private void gérerTriathlonsMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FrmTriathlon"] == null)
            {
                this.ActiveMdiChild?.Close();
                FrmTriathlon unFrmTriathlon = new FrmTriathlon();
                unFrmTriathlon.MdiParent = this;
                unFrmTriathlon.Show();
            }
            else
            {
                Application.OpenForms["FrmTriathlon"].BringToFront();
            }
        }

        private void classementMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FrmClassement"] == null)
            {
                this.ActiveMdiChild?.Close();
                FrmClassement unFrmClassement = new FrmClassement();
                unFrmClassement.MdiParent = this;
                unFrmClassement.Show();
            }
            else
            {
                Application.OpenForms["FrmClassement"].BringToFront();
            }
        }

        private void menuItemQUITTER_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
