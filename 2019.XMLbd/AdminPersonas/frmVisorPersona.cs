using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
namespace AdminPersonas
{
    public partial class frmVisorPersona : Form
    {
        private List<Persona> listaPersonas;
        public frmVisorPersona()
        {
            InitializeComponent();
            this.listaPersonas = new List<Persona>();
        }
        public frmVisorPersona(List<Persona> lp):this()
        {
            this.listaPersonas = lp;
            this.ActualizarLista();
            
        }
        public List<Persona> ListaDePersonas
        {
            get { return this.listaPersonas; }
            set { this.listaPersonas = value; }
        }
        public void ActualizarLista()
        {
            this.lstVisor.Items.Clear();
            foreach (Persona x in this.listaPersonas)
                this.lstVisor.Items.Add(x);
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmPersona frm = new frmPersona();
            frm.StartPosition = FormStartPosition.CenterScreen;

            //implementar
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                this.listaPersonas.Add(frm.Persona);
                this.lstVisor.Items.Add(frm.Persona);
            }

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if(!Object.Equals(this.lstVisor.SelectedItem, null))
            {
                frmPersona frm = new frmPersona((Persona)this.lstVisor.SelectedItem);
                frm.StartPosition = FormStartPosition.CenterScreen;

                //implementar
                frm.ShowDialog();
                if (frm.DialogResult == DialogResult.OK)
                {
                    this.lstVisor.SelectedItem = frm.Persona;
                    //this.ListaDePersonas.
                }
                this.ActualizarLista();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            frmPersona frm = new frmPersona();
            frm.StartPosition = FormStartPosition.CenterScreen;

            //implementar
            this.listaPersonas.Remove((Persona)this.lstVisor.SelectedItem);
            this.ActualizarLista();
        }

        private void frmVisorPersona_Load(object sender, EventArgs e)
        {

        }
    }
}
