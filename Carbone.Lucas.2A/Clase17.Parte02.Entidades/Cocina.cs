using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase17.Parte02.Entidades
{
    public class Cocina
    {
        #region Campos
        private int _codigo;
        private bool _esIndustrial;
        private double _precio;
        #endregion
        #region Propiedades
        public int Codigo { get { return this._codigo; } }
        public bool EsIndustrial { get { return this._esIndustrial; } }
        public double Precio { get { return this._precio; } }
        #endregion
        #region Metodos
        public Cocina(int codigo,double precio,bool esIndustrial)
        {
            this._codigo = codigo;
            this._precio = precio;
            this._esIndustrial = esIndustrial;
        }
        public override bool Equals(object obj)
        {
            if (obj is Cocina && obj == this)
                return true;
            return false;
        }
        public static bool operator !=(Cocina a, Cocina b)
        {
            return !(a == b);
        }
        public static bool operator ==(Cocina a, Cocina b)
        {
            if (a.Codigo == b.Codigo)
                return true;
            return false;
        }
        public override string ToString()
        {
            return String.Format("Codigo: {0} - Precio: {1} - Es Industrial? {2}", this.Codigo, this.Precio, this.EsIndustrial);
        }
        #endregion
    }
}
