using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Clase16.WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            foreach(Environment.SpecialFolder p in Environment.SpecialFolder.GetValues(typeof(Environment.SpecialFolder)))
            {
                this.cmbRutas.Items.Add(p);
            }
            this.cmbRutas.SelectedItem = Environment.SpecialFolder.Desktop;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamWriter archivo = new StreamWriter(Environment.GetFolderPath((Environment.SpecialFolder)this.cmbRutas.SelectedItem)+"\\"+this.txtNombreDeArchivo.Text))
                {
                    archivo.WriteLine(this.rtxtTexto.Text);
                    MessageBox.Show(String.Format("El archivo {0} ha sido guardado con exito!", this.txtNombreDeArchivo.Text));
                }
                
            }
            catch(ArgumentOutOfRangeException x)
            {
                MessageBox.Show(x.Message);
            }
            catch(ArgumentException x)
            {
                MessageBox.Show(x.Message);
            }
            catch(DirectoryNotFoundException x)
            {
                MessageBox.Show(x.Message);
            }
            catch(PathTooLongException x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
