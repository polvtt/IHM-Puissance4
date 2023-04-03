using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Puissance4
{
    public partial class AI : Form
    {
        public AI()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ParametrageIA frmPrm = new ParametrageIA();
            frmPrm.Show();
            this.Hide();
        }

        private void btnIAIntermediaire_Click(object sender, EventArgs e)
        {
            ParametrageIA frmPrm = new ParametrageIA();
            frmPrm.Show();
            this.Hide();
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            ModeDeJeu frmPrm = new ModeDeJeu();
            frmPrm.Show();
            this.Hide();
        }
    }
}
