using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;
using System.Data.SqlClient;
using Entidades;

namespace AdminPersonas
{
    public partial class FrmPrincipal : Form
    {
        private List<Persona> lista;

        public FrmPrincipal()
        {
            InitializeComponent();

            this.IsMdiContainer = true;
            this.WindowState = FormWindowState.Maximized;
            this.lista = new List<Persona>();
        }

        private void cargarArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //implementar...
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.ShowDialog();
                XmlSerializer xmlSer = new XmlSerializer(typeof(List<Persona>));
                TextReader tr = new StreamReader(ofd.FileName);
                this.lista = (List<Persona>)xmlSer.Deserialize(tr);
                tr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void guardarEnArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //implementar...
            try
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.FileName = "listaDePersonasWinForm.xml";
                sfd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                sfd.ShowDialog();
                XmlSerializer xmlSer = new XmlSerializer(typeof(List<Persona>));
                TextWriter tw = new StreamWriter(sfd.FileName);
                xmlSer.Serialize(tw, this.lista);
                tw.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void visualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVisorPersona frm = new frmVisorPersona(this.lista);

            frm.StartPosition = FormStartPosition.CenterScreen;

            //implementar
            frm.Show();
            this.lista = frm.ListaDePersonas;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //implementar
            this.Close();
        }

        private void conectarToolStripMenuItem_Click(object sender, EventArgs e)//IPIMENTACION DE SQL !!!!!!!!!!!!!!!!!!!
        {
            try
            {
                SqlConnection sql = new SqlConnection(Properties.Settings.Default.Conexion);
                sql.Open();
                MessageBox.Show("Se pudo abrir el sql");
                //sql.Close();
                SqlCommand sqlCom = new SqlCommand();
                sqlCom.Connection = sql;
                sqlCom.CommandType = CommandType.Text;
                sqlCom.CommandText = "SELECT TOP 1000 [id],[nombre],[apellido],[edad]FROM[personas_bd].[dbo].[personas]";
                SqlDataReader sqlDataReader = sqlCom.ExecuteReader();
                int i = 0;
                while (sqlDataReader.Read() != false);
                {
                    Object p = sqlDataReader[i];
                    MessageBox.Show(p.ToString());
                    i++;
                }
                sqlDataReader.Close();
                sqlCom.Clone();
                 

            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }
    }
}
