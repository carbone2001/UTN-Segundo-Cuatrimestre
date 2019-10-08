using System;
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

        public frmTempera(Tempera input)
        {

            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            foreach (ConsoleColor c in Enum.GetValues(typeof(ConsoleColor)))
            {
                this.cmbColor.Items.Add(c);
            }
            txtMarca.Text = input.GetMarca;
            txtCantidad.Text = input.GetCantidad.ToString();
            cmbColor.SelectedItem = input.GetColor;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            t = new Tempera((ConsoleColor)this.cmbColor.SelectedItem, txtMarca.Text, int.Parse(txtCantidad.Text));
            MessageBox.Show(t);
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
