﻿using Clase10.Entidades;
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
            int count;
            FrmAlumno nuevoAlumno = new FrmAlumno();
            nuevoAlumno.ShowDialog();
            this.ActualizarListadoAlumnos();
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
            this.lsbAlumnos.Items.Clear();
        }

        private void CmbTipoOrden_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ActualizarListadoAlumnos();
            int count;
            switch (this.cmbTipoOrden.SelectedItem)
            {
                case ETipoOrdenamiento.ApellidoAscendente:
                    catedra.Alumnos.Sort(Alumno.OrdenarPorApellidoAsc);
                    break;
                case ETipoOrdenamiento.ApellidoDescendente:
                    catedra.Alumnos.Sort(Alumno.OrdenarPorApellidoDesc);
                    break;
                case ETipoOrdenamiento.LegajoAscendente:
                    catedra.Alumnos.Sort(Alumno.OrdenarPorLegajoAsc);
                    break;
                case ETipoOrdenamiento.LegajoDescendente:
                    catedra.Alumnos.Sort(Alumno.OrdenarPorLegajoDesc);
                    break;
                default:
                    break;
            }
            count = catedra.Alumnos.Count();
            for (int i = 0; i < count; i++)
            {
                this.lsbAlumnos.Items.Add(Alumno.Mostrar(catedra.Alumnos[i]));
            }
        }

        private void BtnCalificar_Click(object sender, EventArgs e)
        {
            //(Alumno)lsbAlumnos.SelectedItem;
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            /*FrmAlumno calificarAlumno = new FrmAlumno();
            calificarAlumno.alumno = new Alumno(lsbAlumnos.SelectedItem);
            calificarAlumno.ShowDialog();
            if (calificarAlumno.DialogResult == DialogResult.OK)
            {
                CmbTipoOrden_SelectedIndexChanged(sender, e);
            }*/
        }
    }
}
