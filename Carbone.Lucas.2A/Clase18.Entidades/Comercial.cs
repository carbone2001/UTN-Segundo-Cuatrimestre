using System;
using System.Collections.Generic;
using System.Text;

namespace Clase18.Entidades
{
    public class Comercial:Avion,IARBA
    {
        #region Fields
        private int _capacidadPasajeros;
        #endregion
        #region Methods
        public Comercial(double precio, double velocidad, int pasajeros):base(precio,velocidad)
        {
            this._capacidadPasajeros = pasajeros;
        }
        double IARBA.CalcularImpuesto()
        {
            return this._precio * 0.25;
        }

        #endregion
    }
}
