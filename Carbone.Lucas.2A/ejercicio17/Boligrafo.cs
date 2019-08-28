using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio17
{
    class Boligrafo
    {
        const short cantidadTintaMaxima=100;
        private ConsoleColor color;
        private short tinta;

        public Boligrafo(short tinta, ConsoleColor color)
        {
            this.tinta = tinta;
            this.color = color;
        }
        public ConsoleColor GetColor()
        {
            return this.color;
        }
        public short GetTinta()
        {
            return this.tinta;
        }
        private void SetTinta(short tinta)
        {
            this.tinta += tinta;
            if(this.tinta < 0)
            {
                this.tinta = 0;
            }
            else if(this.tinta > cantidadTintaMaxima)
            {
                this.tinta = 100;
            }
        }
        public void Recargar()
        {
            SetTinta(100);
        }
        public bool Pintar(int gasto,out string dibujo)
        {
            bool respuesta;
            string aux="";
            SetTinta((short)gasto);
            if(this.tinta == 0)
            {
                respuesta = false;
            }
            else
            {
                respuesta = true;
            }
            for(int i=0;i<gasto;i++)
            {
                aux = aux + "*";
            }
            dibujo = aux;
            return respuesta;
            
        }



    }
}
