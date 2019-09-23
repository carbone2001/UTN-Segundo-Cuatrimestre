using System;
using System.Windows.Forms;

namespace Clase10.WF
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            this.IsMdiContainer = true;
            InitializeComponent();
        }

        private void catedraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCatedra catedra = new FrmCatedra();
            catedra.MdiParent = this;
            catedra.Show();
        }
    }
}
