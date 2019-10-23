using System;
using System.Collections.Generic;
using System.Text;

namespace Clase18.Entidades
{
    public abstract class Auto:Vehiculo
    {
        #region Fields
        protected string _patente;
        #endregion
        #region Methods
        public Auto(double precio, string patente):base(precio)
        {
            this._patente = patente;
        }
        public void MostrarPatente() { }
        #endregion
    }
}
