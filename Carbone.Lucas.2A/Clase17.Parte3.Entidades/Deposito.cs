using System;
using System.Collections.Generic;
using System.Text;

namespace Clase17.Parte3.Entidades
{
    public class Deposito<T>
    {
        #region Campos
        private int _capacidadMaxima;
        private List<T> _lista;
        #endregion
        #region Metodos
        public bool Agregar(T c)
        {
            return (this + c);
        }
        public Deposito(int capacidad)
        {
            this._capacidadMaxima = capacidad;
            this._lista = new List<T>();
        }
        private int GetIndice(T c)
        {
            int indice = 0;
            foreach (T x in this._lista)
            {
                if (x.Equals(c))
                    return indice;
                indice++;
            }
            return -1;
        }
        public static bool operator +(Deposito<T> d, T c)
        {
            if (d._lista.Count < d._capacidadMaxima)
            {
                d._lista.Add(c);
                return true;
            }
            return false;
        }
        public static bool operator -(Deposito<T> d, T c)
        {
            if (d.GetIndice(c) != -1)
            {
                d._lista.RemoveAt(d.GetIndice(c));
                return true;
            }
            return false;
        }
        public bool Remover(T c)
        {
            return (this - c);
        }
        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.AppendLine("Capacidad Maxima: " + this._capacidadMaxima);
            str.AppendLine("Listado De Deposito:");
            foreach (T x in this._lista)
                str.AppendLine(x.ToString());
            return str.ToString();
        }
        #endregion
    }
}
