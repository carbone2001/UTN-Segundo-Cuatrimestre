using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaPolimorfismo
{
    class Local:Llamada
    {
        #region Atributos
        protected float _costo;
        #endregion
        
        #region Propiedades
        protected override float CostoLlamada
        {
            get
            {
                return this._costo;
            }
        }
        #endregion

        #region Metodos
        public Local(string origen, string destino, float duracion, float costo) : base(origen, destino, duracion)
        {
            this._costo = costo;
        }
        public Local(Llamada unaLlamada, float costo) : this(unaLlamada.NroOrigen, unaLlamada.NroDestino, unaLlamada.Duracion, costo)
        {
        }
        public override bool Equals(object obj)
        {
            if (obj is Local)
                return true;
            return false;
        }
        protected override string Mostrar()
        {
            StringBuilder retorno = new StringBuilder(base.Mostrar() + "Costo: " + this.CostoLlamada);
            return retorno.ToString();
        }
        public override string ToString()
        {
            return this.Mostrar();
        }
        private float CalcularCosto()
        {
            return this.Duracion * this.CostoLlamada;
        }
           
        #endregion
    }
}
