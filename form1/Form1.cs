namespace Puissance4
{
    public partial class frmAccueil : Form
    {
        public frmAccueil()
        {
            InitializeComponent();
        }

        private void btnJouer_Click(object sender, EventArgs e)
        {
            ModeDeJeu frmPrm = new ModeDeJeu();
            frmPrm.Show();
            this.Hide();
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}