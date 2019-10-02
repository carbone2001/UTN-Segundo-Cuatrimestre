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
    public partial class LlamadaLocal : Llamada
    {
        public LlamadaLocal():base()
        {
            InitializeComponent();
        }
        protected override void btnAceptar_Click(object sender, EventArgs e)
        {
            float duracion;
            float costo;
            if(float.TryParse(txtDuracion.Text,out duracion) && float.TryParse(txtCosto.Text,out costo))
            {
                laLlamada = new Local(txtNumeroOrigen.Text, txtNumeroDestino.Text, duracion,costo);
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Error al cargar la llamada","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                this.DialogResult = DialogResult.Abort;
            }
            
        }

    }
}
