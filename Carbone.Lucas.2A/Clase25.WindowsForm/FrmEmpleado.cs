using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clase25.Entidades;

namespace Clase25.WindowsForm
{
    public partial class FrmEmpleado : Form
    {
        private Empleado emp;
        public FrmEmpleado()
        {
            InitializeComponent();
            foreach(TipoManejador x in TipoManejador.GetValues(typeof(TipoManejador)))
            {
                this.cmbManejador.Items.Add(x);
            }
            this.cmbManejador.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbManejador.SelectedIndex = 0;
        }

        public void Manejador_LimiteSueldo(double sueldo,Empleado emp)
        {
            MessageBox.Show("El empleado\n"+emp.ToString()+"\nExcedio limite de sueldo: "+sueldo);
        }
        public void Manejador_LimiteSueldoMejorado(Empleado emp,EmpleadoEventArgs e)
        {
            MessageBox.Show("El empleado\n" + emp.ToString() + "\nExcedio limite de sueldo mejorado: " + e.SueldoAsignar);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                this.emp = new Empleado(this.txtNombre.Text, this.txtApellido.Text, int.Parse(this.txtLegajo.Text));
                switch(this.cmbManejador.SelectedItem)
                {
                    case TipoManejador.LimiteSueldo:
                        this.emp.limiteSueldo -= new LimiteSueldoDelegado(Manejador_LimiteSueldo);
                        this.emp.limiteSueldo += new LimiteSueldoDelegado(Manejador_LimiteSueldo);
                        break;
                    case TipoManejador.LimiteSueldoMejorado:
                        this.emp.limiteSueldoMejorado -= new LimiteSueldoMejoradoDel(Manejador_LimiteSueldoMejorado);
                        this.emp.limiteSueldoMejorado += new LimiteSueldoMejoradoDel(Manejador_LimiteSueldoMejorado);
                        break;
                    case TipoManejador.Todos:
                        this.emp.limiteSueldoMejorado -= new LimiteSueldoMejoradoDel(Manejador_LimiteSueldoMejorado);
                        this.emp.limiteSueldoMejorado += new LimiteSueldoMejoradoDel(Manejador_LimiteSueldoMejorado);
                        this.emp.limiteSueldo -= new LimiteSueldoDelegado(Manejador_LimiteSueldo);
                        this.emp.limiteSueldo += new LimiteSueldoDelegado(Manejador_LimiteSueldo);
                        break;
                }
                
                this.emp.Sueldo = double.Parse(this.txtSueldo.Text);
            }
            catch (Exception)
            {
                //MessageBox.Show(x.Message);
            }
            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtApellido.Text = "";
            this.txtLegajo.Text = "";
            this.txtNombre.Text = "";
            this.txtSueldo.Text = "";
        }
    }
}
