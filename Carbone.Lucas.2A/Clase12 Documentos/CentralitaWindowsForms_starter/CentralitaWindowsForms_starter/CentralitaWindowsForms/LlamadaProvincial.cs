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
    public partial class LlamadaProvincial : Llamada
    {
        public LlamadaProvincial() : base()
        {
            InitializeComponent();
            foreach(Franja f in Franja.GetValues(typeof(Franja)))
            {
                cmbFranja.Items.Add(f);
            }
            cmbFranja.SelectedIndex = 0;
        }
        protected override void btnAceptar_Click(object sender, EventArgs e)
        {
            float duracion;
            if (float.TryParse(txtDuracion.Text, out duracion))
            {
                laLlamada = new Provincial(txtNumeroOrigen.Text, (Franja)cmbFranja.SelectedItem, float.Parse(txtDuracion.Text), txtNumeroDestino.Text);
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Error al cargar la llamada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.Abort;
            }
        }

    }
}
