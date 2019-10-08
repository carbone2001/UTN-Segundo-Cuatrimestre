using System;
using System.Windows.Forms;
namespace CentralitaWindowsForms
{
    public partial class Llamada : Form
    {
        protected CentralitaPolimorfismo.Llamada laLlamada;

        public Llamada()
        {
            InitializeComponent();
        }

        public CentralitaPolimorfismo.Llamada GetLlamada
        {
            get
            {
                return this.laLlamada;
            }
        }

        protected virtual void btnAceptar_Click(object sender, EventArgs e) { }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
