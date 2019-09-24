using Clase10.Entidades;
using System;
using System.Windows.Forms;
using Clase10.Entidades;
namespace Clase10.WF
{
    public partial class FrmAlumno : Form
    {
        protected Alumno alumno;


        public FrmAlumno()
        {
            InitializeComponent();
            foreach (ETipoExamen t in ETipoExamen.GetValues(typeof(ETipoExamen)))
            {
                this.cmbTipoDeExamen.Items.Add(t);
            }
            this.cmbTipoDeExamen.SelectedItem = ETipoExamen.Final;
            if(alumno != null)
            {
                txtLegajo.Enabled = false;
            }
        }
        public FrmAlumno(Alumno a)
        {
            this.txtNombre.Text = a.Nombre;
            this.txtApellido.Text = a.Apellido;
            this.txtLegajo.Text = a.Legajo.ToString();
            this.txtLegajo.Enabled = false;

        }
        
        public Alumno GetAlumno
        {
            get
            {
                return this.alumno;
            }
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            alumno = new Alumno(txtNombre.Text, txtApellido.Text, int.Parse(txtLegajo.Text), (ETipoExamen)cmbTipoDeExamen.SelectedItem);
            this.DialogResult = DialogResult.OK;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
