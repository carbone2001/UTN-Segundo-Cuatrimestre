using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio28
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            string palabras = this.rtbPalabras.Text;
            int countDiccionario;
            Dictionary<string,int> Diccionario  = new Dictionary<string,int>();
            string nuevaPalabra = "";
            List<string> primerosPuestosString = new List<string>();
            List<int> primerosPuestosInt = new List<int>();

            for (int i=0;i<palabras.Length;i++)
            {
                if(palabras[i] != '\n')
                {
                    nuevaPalabra += palabras[i];
                }
                else
                {
                    countDiccionario = Diccionario.Count;
                    for(int j=0;j<countDiccionario;j++)
                    {
                        if((Diccionario[nuevaPalabra])==0)
                        {
                            Diccionario.Add(nuevaPalabra, 1);
                            
                        }
                        else
                        {
                            Diccionario[nuevaPalabra]++;
                        }

                        if (Diccionario[nuevaPalabra] > primerosPuestosInt[0])
                        {
                            primerosPuestosInt[0] = Diccionario[nuevaPalabra];
                            primerosPuestosString[0] = nuevaPalabra;
                        }
                        else if (Diccionario[nuevaPalabra] >= primerosPuestosInt[1] && Diccionario[nuevaPalabra] < primerosPuestosInt[0])
                        {
                            primerosPuestosInt[2] = primerosPuestosInt[1];
                            primerosPuestosString[2] = primerosPuestosString[1];
                            primerosPuestosInt[1] = Diccionario[nuevaPalabra];
                            primerosPuestosString[1] = nuevaPalabra;
                        }
                        else if (Diccionario[nuevaPalabra] >= primerosPuestosInt[2] && Diccionario[nuevaPalabra] < primerosPuestosInt[1])
                        {
                            primerosPuestosInt[2] = Diccionario[nuevaPalabra];
                            primerosPuestosString[2] = nuevaPalabra;
                        }
                    }
                }
                MessageBox.Show(primerosPuestosString[0]+" - Aparecio: "+primerosPuestosInt[0]+"\n"+ primerosPuestosString[1] + " - Aparecio: " + primerosPuestosInt[1] + "\n" + primerosPuestosString[2] + " - Aparecio: " + primerosPuestosInt[2] + "\n");
            }
            
        }
    }
}
