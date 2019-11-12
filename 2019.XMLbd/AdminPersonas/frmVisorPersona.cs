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
using System.Data.SqlClient;
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
        protected virtual void ActualizarLista()
        {
            this.lstVisor.Items.Clear();
            foreach (Persona x in this.listaPersonas)
                this.lstVisor.Items.Add(x);
        }
        protected virtual void btnAgregar_Click(object sender, EventArgs e)
        {
            frmPersona frm = new frmPersona();
            frm.StartPosition = FormStartPosition.CenterScreen;

            //implementar
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                StringBuilder str = new StringBuilder();
                SqlCommand cmd = new SqlCommand();
                SqlConnection conexion = new SqlConnection(Properties.Settings.Default.Conexion);
                conexion.Open();
                this.listaPersonas.Add(frm.Persona);
                this.lstVisor.Items.Add(frm.Persona);
                try
                {
                    str.AppendFormat("insert into Personas(nombre,apellido,edad) values ('{0}','{1}','{2}')",frm.Persona.nombre,frm.Persona.apellido,frm.Persona.edad);
                    cmd.Connection = conexion;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = str.ToString();
                    cmd.ExecuteNonQuery();
                    conexion.Close();
                }
                catch (Exception x)
                {
                    conexion.Close();
                    MessageBox.Show(x.Message);
                }
            }

        }

        protected virtual void btnModificar_Click(object sender, EventArgs e)
        {
            if(!Object.Equals(this.lstVisor.SelectedItem, null))
            {
                StringBuilder str = new StringBuilder();
                SqlCommand cmd = new SqlCommand();
                SqlConnection conexion = new SqlConnection(Properties.Settings.Default.Conexion);
                conexion.Open();

                frmPersona frm = new frmPersona((Persona)this.lstVisor.SelectedItem);
                frm.StartPosition = FormStartPosition.CenterScreen;

                //implementar
                frm.ShowDialog();
                if (frm.DialogResult == DialogResult.OK)
                {
                    this.lstVisor.SelectedItem = frm.Persona;
                    //this.ListaDePersonas.

                    try
                    {
                        str.AppendFormat("update Personas set nombre='{0}',apellido='{1}',edad={2} where id={3}", frm.Persona.nombre, frm.Persona.apellido, frm.Persona.edad, this.lstVisor.SelectedIndex + 1);
                        cmd.Connection = conexion;
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = str.ToString();
                        cmd.ExecuteNonQuery();
                        conexion.Close();
                    }
                    catch (Exception x)
                    {
                        conexion.Close();
                        MessageBox.Show(x.Message);
                    }
                }



                this.ActualizarLista();
            }
        }

        protected virtual void btnEliminar_Click(object sender, EventArgs e)
        {
            StringBuilder str = new StringBuilder();
            SqlCommand cmd = new SqlCommand();
            SqlConnection conexion = new SqlConnection(Properties.Settings.Default.Conexion);
            conexion.Open();

            frmPersona frm = new frmPersona();
            frm.StartPosition = FormStartPosition.CenterScreen;

            //implementar
            
            try
            {
                this.listaPersonas.Remove((Persona)this.lstVisor.SelectedItem);
                str.AppendFormat("delete from Personas where id={0}",this.lstVisor.SelectedIndex + 1);
                cmd.Connection = conexion;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = str.ToString();
                cmd.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception x)
            {
                conexion.Close();
                MessageBox.Show(x.Message);
            }
            this.ActualizarLista();
        }

        private void frmVisorPersona_Load(object sender, EventArgs e)
        {
            this.btnAgregar.Click += new EventHandler(btnAgregar_Click);
        }

        private void lstVisor_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Quita el modificador si existe
            this.btnModificar.Click -= new EventHandler(btnModificar_Click);
            this.btnEliminar.Click -= new EventHandler(btnEliminar_Click);

            //los agrega
            this.btnModificar.Click += new EventHandler(btnModificar_Click);
            this.btnEliminar.Click += new EventHandler(btnEliminar_Click);
        }
    }
}
