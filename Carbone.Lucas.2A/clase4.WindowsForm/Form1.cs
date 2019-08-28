using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;

namespace clase4.WindowsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtEntero_TextChanged(object sender, EventArgs e)
        {
            //this.txtEntero.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cosa a = new Cosa(this.txtCadena.Text, DateTime.Parse(this.txtFecha.Text), int.Parse(this.txtEntero.Text));
            lstLista.Items.Add(a.Mostrar());
            MessageBox.Show(a.Mostrar());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }
    }
}
