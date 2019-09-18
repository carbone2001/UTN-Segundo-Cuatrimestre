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
    public partial class FrmCatedra : Form
    {
        private Catedra catedra;
        private List<AlumnoCalificado> alumnosCalificados;

        public FrmCatedra()
        {
            InitializeComponent();
            this.catedra = new Catedra();
            this.alumnosCalificados = new List<AlumnoCalificado>();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmAlumno nuevoAlumno = new FrmAlumno();
            nuevoAlumno.ShowDialog();
            if(DialogResult.OK == nuevoAlumno.DialogResult)
            {
                this.lsbAlumnos.Items.Add(nuevoAlumno.alumno);
            }
        }
    }
}
