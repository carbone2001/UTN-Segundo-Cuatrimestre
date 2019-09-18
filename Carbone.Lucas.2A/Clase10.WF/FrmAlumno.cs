using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clase10.Entidades;
namespace Clase10.WF
{
    public partial class FrmAlumno : Form
    {
        public Alumno alumno;
        public FrmAlumno()
        {
            InitializeComponent();
            foreach(ETipoExamen t in ETipoExamen.GetValues(typeof(ETipoExamen)))
            {
                this.cmbTipoDeExamen.Items.Add(t);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            alumno = new Alumno(txtNombre.Text, txtApellido.Text, int.Parse(txtLegajo.Text), (ETipoExamen)cmbTipoDeExamen.SelectedItem);
        }
    }
}
