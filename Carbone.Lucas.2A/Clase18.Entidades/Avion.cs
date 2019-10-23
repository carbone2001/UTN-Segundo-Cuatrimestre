using System;
using System.Collections.Generic;
using System.Text;

namespace Clase18.Entidades
{
    public class Avion : Vehiculo, IAFIP, IARBA
    {
        #region Fields
        protected double _velocidadMaxima;
        #endregion
        #region Methods
        public Avion(double precio,double velMax):base(precio)
        {
            this._velocidadMaxima = velMax;
        }

        double IARBA.CalcularImpuesto()
        {
            return this._precio * 0.27;
        }

        double IAFIP.CalcularImpuesto()
        {
            return  this._precio*0.33;
        }

        #endregion
    }
}
