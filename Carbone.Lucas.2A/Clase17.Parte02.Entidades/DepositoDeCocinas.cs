using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase17.Parte02.Entidades
{
    public class DepositoDeCocinas
    {
        #region Campos
        private int _capacidadMaxima;
        private List<Cocina> _lista;
        #endregion
        #region Metodos
        public bool Agregar(Cocina c)
        {
            return (this + c);
        }
        public DepositoDeCocinas(int capacidad)
        {
            this._capacidadMaxima = capacidad;
            this._lista = new List<Cocina>();
        }
        private int GetIndice(Cocina c)
        {
            int indice = 0;
            foreach (Cocina x in this._lista)
            {
                if (x == c)
                    return indice;
                indice++;
            }
            return -1;
        }
        public static bool operator +(DepositoDeCocinas d, Cocina c)
        {
            if (d._lista.Count < d._capacidadMaxima)
            {
                d._lista.Add(c);
                return true;
            }
            return false;
        }
        public static bool operator -(DepositoDeCocinas d, Cocina c)
        {
            if (d.GetIndice(c) != -1)
            {
                d._lista.RemoveAt(d.GetIndice(c));
                return true;
            }
            return false;
        }
        public bool Remover(Cocina c)
        {
            return (this - c);
        }
        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.AppendLine("Capacidad Maxima: " + this._capacidadMaxima);
            str.AppendLine("Listado De Cocinas:");
            foreach (Cocina x in this._lista)
                str.AppendLine(x.ToString());
            return str.ToString();
        }
        #endregion
    }
}
