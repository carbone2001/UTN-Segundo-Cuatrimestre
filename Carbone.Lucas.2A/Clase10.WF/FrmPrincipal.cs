using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
