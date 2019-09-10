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
    public partial class frmTempera : Form
    {
        Tempera t;
        public Tempera MiTempera
        {
            get
            {
                return this.t;
            }
        }

        public frmTempera()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            foreach (ConsoleColor c in Enum.GetValues(typeof(ConsoleColor)))
            {
                this.cmbColor.Items.Add(c);
            }
            cmbColor.SelectedItem = ConsoleColor.Magenta;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            t = new Tempera((ConsoleColor)this.cmbColor.SelectedItem,txtMarca.Text,int.Parse(txtCantidad.Text));
            MessageBox.Show(t);
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
