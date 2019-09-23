using Ejercicio21;
using System;
using System.Windows.Forms;
namespace ejercicio24__Windows_Form_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnConvertFahrenheit_Click(object sender, EventArgs e)
        {
            string input = txtFahrenheit.Text;
            Fahrenheit f = new Fahrenheit(double.Parse(input));
            txtFahrenheitACelsius.Text = ((Celsius)f);
            txtFahrenheitAKelvin.Text = ((Kelvin)f);
            txtFahrenheitAFahrenheit.Text = f;
        }

        private void BtnConverCelsius_Click(object sender, EventArgs e)
        {
            string input = txtFahrenheit.Text;
            Celsius t = new Celsius(double.Parse(input));
            txtCelsiusACelsius.Text = t;
            txtCelsiusAKelvin.Text = ((Kelvin)t);
            txtCelsiusAFahrenheit.Text = (Fahrenheit)t;
        }

        private void BtnConvertKelvin_Click(object sender, EventArgs e)
        {
            string input = txtFahrenheit.Text;
            Kelvin t = new Kelvin(double.Parse(input));
            txtKelvinACelsius.Text = ((Celsius)t);
            txtKelvinAKelvin.Text = t;
            txtKelvinAFahrenheit.Text = (Fahrenheit)t;
        }
    }
}
