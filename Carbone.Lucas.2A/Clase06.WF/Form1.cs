using Clase06.Entidades;
using System;
using System.Windows.Forms;

namespace Clase06.WF
{
    public partial class Form1 : Form
    {
        Paleta p = 5;
        public Form1()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            this.WindowState = FormWindowState.Maximized;
            this.grbPaleta.Visible = false;
            //StartPosition = FormStartPosition.CenterScreen;
        }

        private void crearTemperaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTempera frm = new frmTempera();
            //frm.MdiParent = this;
            frm.StartPosition = FormStartPosition.CenterScreen;
            //frm.Show();
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                this.p += frm.MiTempera;
                this.lsbPaleta.Items.Add((string)this.p);
            }

        }

        private void crearPaletaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.crearPaletaToolStripMenuItem.Enabled = false;
            this.grbPaleta.Visible = true;

        }
    }
}
