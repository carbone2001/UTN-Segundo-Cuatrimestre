using Clase10.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

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
            foreach (ETipoOrdenamiento t in ETipoOrdenamiento.GetValues(typeof(ETipoOrdenamiento)))
            {
                this.cmbTipoOrden.Items.Add(t);
            }
            this.cmbTipoOrden.SelectedItem = ETipoOrdenamiento.LegajoAscendente;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmAlumno nuevoAlumno = new FrmAlumno();
            nuevoAlumno.ShowDialog();
            if (DialogResult.OK == nuevoAlumno.DialogResult)
            {

                if ((catedra + nuevoAlumno.GetAlumno) == false)
                {
                    MessageBox.Show("Error al agregar alumno!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            CmbTipoOrden_SelectedIndexChanged(sender, e);
        }

        private void ActualizarListadoAlumnos()
        {
            int count;
            this.lsbAlumnos.Items.Clear();
            
            count = catedra.Alumnos.Count();
            for (int i = 0; i < count; i++)
            {
                this.lsbAlumnos.Items.Add(Alumno.Mostrar(this.catedra.Alumnos[i]));
            }
            
        }
        private void ActualizarListadoAlumnosCalificados()
        {
            int count;
            count = this.alumnosCalificados.Count();
            this.lsbAlumnosCalificados.Items.Clear();
            for (int i = 0; i < count; i++)
            {
                this.lsbAlumnosCalificados.Items.Add(this.alumnosCalificados[i]);
            }
        }

        private void CmbTipoOrden_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            int count;
            switch (this.cmbTipoOrden.SelectedItem)
            {
                case ETipoOrdenamiento.ApellidoAscendente:
                    catedra.Alumnos.Sort(Alumno.OrdenarPorApellidoAsc);
                    this.alumnosCalificados.Sort(Alumno.OrdenarPorApellidoAsc);
                    break;
                case ETipoOrdenamiento.ApellidoDescendente:
                    catedra.Alumnos.Sort(Alumno.OrdenarPorApellidoDesc);
                    this.alumnosCalificados.Sort(Alumno.OrdenarPorApellidoDesc);
                    break;
                case ETipoOrdenamiento.LegajoAscendente:
                    catedra.Alumnos.Sort(Alumno.OrdenarPorLegajoAsc);
                    this.alumnosCalificados.Sort(Alumno.OrdenarPorLegajoAsc);
                    break;
                case ETipoOrdenamiento.LegajoDescendente:
                    catedra.Alumnos.Sort(Alumno.OrdenarPorLegajoDesc);
                    this.alumnosCalificados.Sort(Alumno.OrdenarPorLegajoDesc);
                    break;
                default:
                    break;
            }
            this.ActualizarListadoAlumnos();
            this.ActualizarListadoAlumnosCalificados();

            
        }

        private void BtnCalificar_Click(object sender, EventArgs e)
        {
            if(lsbAlumnos.SelectedIndex >= 0 && lsbAlumnos.SelectedIndex < this.catedra.Alumnos.Count)
            {
                Alumno calificarAlumno = this.catedra.Alumnos[lsbAlumnos.SelectedIndex];
                FrmAlumnoCalificado frmAlumnoCalificado = new FrmAlumnoCalificado(calificarAlumno);
                frmAlumnoCalificado.ShowDialog();
                if (frmAlumnoCalificado.DialogResult == DialogResult.OK)
                {
                    this.alumnosCalificados.Add(frmAlumnoCalificado.alumnoCalificado);
                }
                CmbTipoOrden_SelectedIndexChanged(sender, e);
            }
            this.ActualizarListadoAlumnosCalificados();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            int index = lsbAlumnos.SelectedIndex;
            if (index >= 0 && index < this.catedra.Alumnos.Count)
            {
                FrmAlumno alumnoModificado = new FrmAlumno(this.catedra.Alumnos[lsbAlumnos.SelectedIndex]);
                alumnoModificado.ShowDialog();
                this.ActualizarListadoAlumnos();
                if (DialogResult.OK == alumnoModificado.DialogResult)
                {
                    this.catedra.Alumnos[index] = alumnoModificado.GetAlumno;
                }
                CmbTipoOrden_SelectedIndexChanged(sender, e);
            }
        }

        public override string ToString()
        {
            string alumnosCalificados="";
            foreach(AlumnoCalificado a in this.alumnosCalificados)
            {
                alumnosCalificados += a.Mostrar();
            }
            return alumnosCalificados;
        }
    }
}
