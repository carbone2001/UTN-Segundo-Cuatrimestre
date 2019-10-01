using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaPolimorfismo
{
    class Provincial:Local
    {
        #region Atributos
        protected Franja _franjaHoraria;
        #endregion

        #region Propiedades
        public override float CostoLlamada
        {
            get
            {
                return this._costo;
            }
        }
        #endregion

        #region Metodos
        private float CalcularCosto()
        {
            return base.Duracion*this.CostoLlamada;
        }
        public override bool Equals(object obj)
        {
            if (obj is Provincial)
                return true;
            return false;
        }
        public Provincial(Franja miFranja,Llamada unallamada):this(unallamada.NroOrigen,miFranja,unallamada.Duracion,unallamada.NroDestino)
        {
        }
        public Provincial(string origen, Franja miFranja ,float duracion,string destino) : base(origen, destino, duracion, 0)
        {
            switch(miFranja)
            {
                case Franja.Franja_1:
                    this._costo = 1.99f;
                    break;
                case Franja.Franja_2:
                    this._costo = 1.25f;
                    break;
                case Franja.Franja_3:
                    this._costo = 1.66f;
                    break;
                default:
                    break;
            }
        }
        protected override string Mostrar()
        {
            StringBuilder show = new StringBuilder(base.Mostrar() + " Franja: " + this._franjaHoraria);
            return show.ToString();
        }
        public override string ToString()
        {
            return this.Mostrar();
        }
        #endregion
    }
}
