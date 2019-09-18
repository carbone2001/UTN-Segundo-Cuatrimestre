using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clase06.Entidades;

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
            if(frm.DialogResult == DialogResult.OK)
            {
                this.lsbPaleta.Items.Clear();
                this.p += frm.MiTempera;
                for(int i=0;i<5;i++)
                this.lsbPaleta.Items.Add((string)this.p[i]);
            }
            
        }

        private void crearPaletaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.crearPaletaToolStripMenuItem.Enabled = false;
            this.grbPaleta.Visible = true;
            
        }

        private void btnSumarTempera_Click(object sender, EventArgs e)
        {
            crearTemperaToolStripMenuItem_Click(sender, e);
            /*frmTempera frm = new frmTempera();
            //frm.MdiParent = this;
            frm.StartPosition = FormStartPosition.CenterScreen;
            //frm.Show();
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                this.p += frm.MiTempera;
                this.lsbPaleta.Items.Add((string)this.p);
            }*/
        }

        private void btnRestarTempera_Click(object sender, EventArgs e)
        {
            frmTempera frm = new frmTempera();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                this.lsbPaleta.Items.Clear();
                this.p -= frm.MiTempera;
                for (int i = 0; i < 5; i++)
                    this.lsbPaleta.Items.Add((string)this.p[i]);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            frmTempera frm;
            int index;
            index = this.lsbPaleta.SelectedIndex;
            if(index != -1 && !Object.Equals(this.p[index],null))
            {
                frm = new frmTempera(p[index]);
                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.ShowDialog();
                if (frm.DialogResult == DialogResult.OK)
                {
                    this.lsbPaleta.Items.Clear();
                    this.p[index] = frm.MiTempera;
                    for (int i = 0; i < 5; i++)
                        this.lsbPaleta.Items.Add((string)this.p[i]);
                }
            }
            

        }
    }
}
