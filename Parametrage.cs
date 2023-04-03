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
    public partial class Parametrage : Form
    {
        public Parametrage()
        {
            InitializeComponent();
            cmbTailleGrille.SelectedIndex = 0;
        }


        private void rdoJ1Rouge_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoJ1Rouge.Checked == true)
            {
                rdoJ2Jaune.Checked = true;
            }
        }

        private void rdoJ1Jaune_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoJ1Jaune.Checked == true)
            {
                rdoJ2Rouge.Checked = true;
            }
        }

        private void rdoJ2Rouge_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoJ2Rouge.Checked == true)
            {
                rdoJ1Jaune.Checked = true;
            }
        }

        private void rdoJ2Jaune_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoJ2Jaune.Checked == true)
            {
                rdoJ1Rouge.Checked = true;
            }
        }

        private void btnCommencer_Click(object sender, EventArgs e)
        {
            if (txtInputJ1.Text.Length > 0 && txtInputJ2.Text.Length > 0 && (rdoJ1Jaune.Checked || rdoJ1Rouge.Checked) && cmbTailleGrille.SelectedIndex >= 0 && (rdoJ1.Checked || rdoJ2.Checked) && txtInputJ1.Text != txtInputJ2.Text)
            {
                Jeu frmPrm = new Jeu();
                frmPrm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Veuillez verifier vos parametre \nEt vous assurer que les noms des joueurs son differents.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            ModeDeJeu frmPrm = new ModeDeJeu();
            frmPrm.Show();
            this.Hide();
        }
    }
}
