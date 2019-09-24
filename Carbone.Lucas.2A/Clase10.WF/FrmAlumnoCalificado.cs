using System.Windows.Forms;
using Clase10.Entidades;

namespace Clase10.WF
{
    public partial class FrmAlumnoCalificado : FrmAlumno
    {
        public AlumnoCalificado alumnoCalificado;
        public FrmAlumnoCalificado()
        {
            InitializeComponent();
            foreach(ETipoExamen e in ETipoExamen.GetValues(typeof(ETipoExamen)))
            {
                cmbTipoDeExamen.Items.Add(e);
            }
        }
        public FrmAlumnoCalificado(Alumno a): this()
        {
            this.txtNombre.Text = a.Nombre;
            this.txtApellido.Text = a.Apellido;
            this.txtLegajo.Text = a.Legajo.ToString();
            this.cmbTipoDeExamen.SelectedItem = a.Examen;

            this.txtNombre.Enabled = false;
            this.txtApellido.Enabled = false;
            this.txtLegajo.Enabled = false;
            this.cmbTipoDeExamen.Enabled = false;
        }

        private void btnAceptar_Click(object sender, System.EventArgs e)
        {
            this.alumnoCalificado = new AlumnoCalificado(txtNombre.Text, txtApellido.Text, int.Parse(txtLegajo.Text), (ETipoExamen)cmbTipoDeExamen.SelectedItem, double.Parse(txtNota.Text));
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, System.EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void FrmAlumnoCalificado_Load(object sender, System.EventArgs e)
        {

        }
    }
}
