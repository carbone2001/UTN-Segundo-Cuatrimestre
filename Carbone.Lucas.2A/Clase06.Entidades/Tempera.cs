﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Clase06.Entidades
{
    public class Tempera
    {
        private ConsoleColor color;
        private string marca;
        private int cantidad;

        //Constructores
        public Tempera(ConsoleColor color,string marca,int cantidad)
        {
            this.color = color;
            this.marca = marca;
            this.cantidad = cantidad;
        }
        private string Mostrar()
        {
            return "\nColor: " + this.color + " Marca: " + this.marca + " Cantidad: " +this.cantidad;
        }
        public static implicit operator string(Tempera t)
        {
            if(!Object.Equals(t,null))
                return t.Mostrar();
            return "\nnull";
        }
        public static bool operator ==(Tempera x,Tempera y)
        {
            if ((!Object.Equals(x,null)) && !Object.Equals(y, null) )
            {
                if (x.marca == y.marca && x.color == y.color)
                {
                    return true;
                }
                return false;
            }
            else
            {
                return (Object.Equals(x, y));
            }
        }
        public static bool operator !=(Tempera x, Tempera y)
        {
            return !(x == y);
        }
        public static Tempera operator +(Tempera x,int y)
        {
            if(!Object.Equals(x, null))
            x.cantidad += y;
            return x;
        }
        public static Tempera operator +(Tempera x, Tempera y)
        {
            if (x == y && (!Object.Equals(x, null) && !Object.Equals(y, null)))
                return x + y.cantidad;
            return x;

        }

    }
}