using System;
using System.Collections.Generic;
using System.Text;

namespace Clase18.Entidades
{
    public class Familiar:Auto
    {
        #region Fields
        private int _cantAsientos;
        #endregion
        #region Methods
        public Familiar(double precio,string patente,int cantidadAsientos):base(precio,patente)
        {
            this._cantAsientos = cantidadAsientos;
        }
        #endregion
    }
}
