using System;
using System.Collections.Generic;
using System.Text;

namespace Clase18.Entidades
{
    public class Deportivo : Auto, IAFIP, IARBA
    {
        #region Fields
        private int _caballosFuerza;
        #endregion
        #region Methods
        public Deportivo(double precio,string patente,int hp):base(precio,patente)
        {
            this._caballosFuerza = hp;
        }
        #endregion
        double IAFIP.CalcularImpuesto()
        {
            return this._precio * 0.28;
        }

        double IARBA.CalcularImpuesto()
        {
            return this._precio * 0.23;
        }
    }
}
