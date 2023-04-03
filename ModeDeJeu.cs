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
    public partial class ModeDeJeu : Form
    {
        public ModeDeJeu()
        {
            InitializeComponent();
        }

        private void btn1v1_Click(object sender, EventArgs e)
        {
            Parametrage frmPrm = new Parametrage();
            frmPrm.Show();
            this.Hide();
        }

        private void btnIa_Click(object sender, EventArgs e)
        {
            AI frmPrm = new AI();
            frmPrm.Show();
            this.Hide();
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            Accueil frmPrm = new Accueil();
            frmPrm.Show();
            this.Hide();
        }
    }
}
