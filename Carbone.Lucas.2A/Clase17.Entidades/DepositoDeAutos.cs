using System;
using System.Collections.Generic;
using System.Text;

namespace Clase17.Entidades
{
    public class DepositoDeAutos
    {
        #region Campos
        private int _capacidadMaxima;
        private List<Auto> _lista;
        #endregion
        #region Metodos
        public bool Agregar(Auto a)
        {
            return (this+a);
        }
        public DepositoDeAutos(int capacidad)
        {
            this._capacidadMaxima = capacidad;
            this._lista = new List<Auto>();
        }
        private int GetIndice(Auto a)
        {
            int indice = 0;
            foreach(Auto x in this._lista)
            {
                if (x == a)
                    return indice;
                indice++;
            }
            return -1;
        }
        public static bool operator +(DepositoDeAutos d, Auto a)
        {
            if (d._lista.Count < d._capacidadMaxima)
            {
                d._lista.Add(a);
                return true;
            }
            return false;
        }
        public static bool operator -(DepositoDeAutos d, Auto a)
        {
            if (d.GetIndice(a) != -1)
            {
                d._lista.RemoveAt(d.GetIndice(a));
                return true;
            }
            return false;
        }
        public bool Remover(Auto a)
        {
            return (this-a);
        }
        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.AppendLine("Capacidad Maxima: " + this._capacidadMaxima);
            str.AppendLine("Listado De Autos:");
            foreach(Auto x in this._lista)
                str.AppendLine(x.ToString());
            return str.ToString();
        }
        #endregion
    }
}
