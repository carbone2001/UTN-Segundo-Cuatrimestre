using System;
using System.Collections.Generic;
using System.Text;

namespace Clase18.Entidades
{
    #region Methods
    public class Carreta:Vehiculo,IARBA
    {
        public Carreta(double precio) : base(precio){}

        double IARBA.CalcularImpuesto()
        {
            return this._precio*0.18;
        }
    }
    #endregion
}
