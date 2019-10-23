using System;
using System.Collections.Generic;
using System.Text;

namespace Clase18.Entidades
{
    public class Privado:Avion
    {
        #region Fields
        private int _valoracionServicioDeAbordo;
        #endregion
        #region Methods
        public Privado(double precio, double velocidad,int valoracion):base(precio,velocidad)
        {
            this._valoracionServicioDeAbordo = valoracion;
        }
        #endregion
    }
}
