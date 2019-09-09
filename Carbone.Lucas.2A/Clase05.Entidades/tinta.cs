using System;

namespace Clase05.Entidades
{
    public class Tinta
    {
        private ConsoleColor _color;
        private ETipoTinta _tipo;

        public Tinta()
        {
            this._color = ConsoleColor.Blue;
            this._tipo = ETipoTinta.Comun;
        }
        public Tinta(ConsoleColor color) : this()
        {
            this._color = color;
        }
        public Tinta(ConsoleColor color, ETipoTinta tipo) : this(color)
        {
            this._tipo = tipo;
        }

        //Metodos
        private string Mostrar()//De instancia
        {
            string respuesta;
            respuesta = "Color: " + this._color + " Tipo de tinta: " + this._tipo + "\n";
            return respuesta;
        }
        public static string Mostrar(Tinta t)//De clase
        {
            return t.Mostrar();
        }

        //Sobrecarga de operadores
        public static bool operator ==(Tinta x, Tinta y)
        {
            if (!Object.Equals(x, null) && !Object.Equals(y, null))
            {
                if (x._color == y._color && x._tipo == y._tipo)
                    return true;
                else
                    return false;
            }
            else
            {
                return Object.Equals(x, y);
            }
        }
        public static bool operator !=(Tinta x, Tinta y)
        {
            return !(x == y);
        }

        public static bool operator ==(Tinta x, ConsoleColor Color)
        {
            bool r = false;
            if (x._color == Color)
                r = true;
            return r;
        }
        public static bool operator !=(Tinta x, ConsoleColor Color)
        {
            return !(x == Color);
        }
        public static explicit operator String(Tinta t)
        {
            return t.Mostrar();
        }
    }
}
