using System;

namespace Clase06.Entidades
{
    public class Paleta
    {
        private Tempera[] colores;
        private int cantidadMaximaColores;

        //Constructores


        private Paleta(int param)
        {
            this.colores = new Tempera[param];
            this.cantidadMaximaColores = param;
        }
        private Paleta() : this(5)
        {
        }

        public static implicit operator Paleta(int i)
        {
            return new Paleta(i);
        }
        private string Mostrar()
        {
            string mensaje = "\nCantidad Maxima de colores: " + this.cantidadMaximaColores;

            for (int i = 0; i < this.cantidadMaximaColores; i++)
            {
                mensaje += (string)this.colores[i];
            }
            return mensaje;
        }
        public static explicit operator string(Paleta p)
        {
            return p.Mostrar();
        }

        public static bool operator ==(Paleta p, Tempera t)
        {
            if (!Object.Equals(p, null) && !Object.Equals(t, null))
            {
                for (int i = 0; i < p.cantidadMaximaColores; i++)
                {
                    if (p.colores[i] == t)
                    {
                        return true;
                    }
                }
            }
            else
            {
                return Object.Equals(p, t);
            }
            return false;
        }

        public static bool operator !=(Paleta p, Tempera t)
        {
            return !(p == t);
        }
        private int ObtenerLugarLibre()
        {
            for (int i = 0; i < this.cantidadMaximaColores; i++)
                if (this.colores[i] == null)
                    return i;
            return -1;
        }
        public static Paleta operator +(Paleta p, Tempera t)
        {

            if (p == t)
            {
                p.colores[p | t] += t;
            }
            else
            {
                if (p.ObtenerLugarLibre() != -1)
                    p.colores[p.ObtenerLugarLibre()] = t;
            }
            return p;
        }
        public static int operator |(Paleta p, Tempera t)
        {
            int index = -1;
            if (!Object.Equals(p, null) && !Object.Equals(t, null))
            {
                for (int i = 0; i < p.cantidadMaximaColores; i++)

                    if (p.colores[i] == t)
                    {
                        index = i;
                        break;
                    }
            }
            return index;
        }
        public static Paleta operator -(Paleta p, Tempera t)
        {
            if (p == t)
            {
                p.colores[p | t] -= t;
            }
            else
            {
                if (p.ObtenerLugarLibre() != -1)
                    p.colores[p.ObtenerLugarLibre()] = t;
            }
            return p;
        }
    }
}
