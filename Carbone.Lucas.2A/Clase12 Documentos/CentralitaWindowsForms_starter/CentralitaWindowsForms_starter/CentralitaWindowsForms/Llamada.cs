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
        public CentralitaPolimorfismo.Llamada llamada;
        public Llamada()
        {
            InitializeComponent();
            
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //llamada = new CentralitaPolimorfismo.Llamada(txtNumeroOrigen.Text,txtNumeroDestino,float.Parse(txtDuracion));
            //this.DialogResult = DialogResult.OK;
        }
    }
}
