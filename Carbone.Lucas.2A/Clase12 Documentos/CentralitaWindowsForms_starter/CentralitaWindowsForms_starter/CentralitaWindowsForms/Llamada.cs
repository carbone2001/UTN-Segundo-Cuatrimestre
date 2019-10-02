using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CentralitaPolimorfismo;
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
