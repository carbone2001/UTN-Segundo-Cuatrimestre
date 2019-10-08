using System;
using System.Windows.Forms;
using Billetes;

namespace ejercicio23_Windows_Form_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnConvertEuro_Click(object sender, EventArgs e)
        {
            Euro euro = new Euro(double.Parse(txtEuro.Text));
            this.txtEuroAEuro.Text = (euro.cantidad).ToString();
            this.txtEuroADolar.Text = (((Dolar)euro).cantidad).ToString();
            this.txtEuroAPesos.Text = (((Pesos)euro).cantidad).ToString();
        }

        private void BtnConvertDolar_Click(object sender, EventArgs e)
        {
            Dolar dolar = new Dolar(double.Parse(txtDolar.Text));
            this.txtDolarAEuro.Text = (((Euro)dolar).cantidad).ToString();
            this.txtDolarADolar.Text = (dolar.cantidad).ToString();
            this.txtDolarAPesos.Text = (((Pesos)dolar).cantidad).ToString();
        }

        private void BtnConvertPesos_Click(object sender, EventArgs e)
        {
            Pesos peso = new Pesos(double.Parse(txtPesos.Text));
            this.txtPesosAEuro.Text = (((Euro)peso).cantidad).ToString();
            this.txtPesosADolar.Text = (((Dolar)peso).cantidad).ToString();
            this.txtPesosAPesos.Text = (peso.cantidad).ToString();
        }
    }
}
