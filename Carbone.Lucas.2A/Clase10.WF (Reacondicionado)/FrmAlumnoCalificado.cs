using System.Windows.Forms;
using Clase10.Entidades;

namespace Clase10.WF
{
    public partial class FrmAlumnoCalificado : FrmAlumno
    {
        protected TextBox txtCalificacion;
        public AlumnoCalificado alumnoCalificado;
        public FrmAlumnoCalificado() : base()
        {
            InitializeComponent();
        }
        public FrmAlumnoCalificado(Alumno a) : this()
        {
            base.alumno = a;
            this.txtNombre.Text = a.Nombre;
            this.txtApellido.Text = a.Apellido;
            this.txtLegajo.Text = a.Legajo.ToString();
            this.cmbTipoDeExamen.SelectedItem = a.Examen;

            this.txtNombre.Enabled = false;
            this.txtApellido.Enabled = false;
            this.txtLegajo.Enabled = false;
            this.cmbTipoDeExamen.Enabled = false;
        }

        private void btnCancelar_Click(object sender, System.EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        protected override void btnAceptar_Click(object sender, System.EventArgs e)
        {
            this.alumnoCalificado = new AlumnoCalificado(base.alumno, double.Parse(this.txtNota.Text));
            this.DialogResult = DialogResult.OK;
        }

    }
}
