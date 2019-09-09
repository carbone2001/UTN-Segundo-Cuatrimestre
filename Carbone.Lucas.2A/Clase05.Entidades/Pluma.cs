using System;

namespace Clase05.Entidades
{
    public class Pluma
    {
        private string _marca;
        private Tinta _tinta;
        private int _cantidad;

        public Pluma()
        {
            this._marca = "Sin marca";
            this._tinta = null;
            this._cantidad = 0;
        }
        public Pluma(string marca) : this()
        {
            this._marca = marca;
        }
        public Pluma(string marca, Tinta t) : this(marca)
        {
            this._tinta = t;
        }
        public Pluma(string marca, Tinta t, int cantidad) : this(marca, t)
        {
            this._cantidad = cantidad;
        }
        private string Mostrar()
        {
            return "Marca: " + this._cantidad + " Cantidad: " + this._cantidad + Tinta.Mostrar(this._tinta) + "\n";
        }
        public static implicit operator string(Pluma p)
        {
            return p.Mostrar();
        }


        public static bool operator ==(Pluma x, Tinta y)
        {
            if (!Object.Equals(x, null) && !Object.Equals(y, null))
            {
                return (x._tinta == y);
            }
            else
            {
                return Object.Equals(x, y);
            }
        }
        public static bool operator !=(Pluma x, Tinta y)
        {
            return !(x == y);
        }
        public static Pluma operator +(Pluma p, Tinta t)
        {
            Pluma aux = p;
            if (aux == t)
                if (aux._cantidad < 100)
                    aux._cantidad++;
            return aux;
        }


    }
}
