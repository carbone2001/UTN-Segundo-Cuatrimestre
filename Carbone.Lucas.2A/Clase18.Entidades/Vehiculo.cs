using System;

namespace Clase18.Entidades
{
    public abstract class Vehiculo
    {
        #region Fields
        protected double _precio;
        #endregion
        //#region Propiedades
        //public double Precio { get { return this._precio; } }
        //#endregion
        #region Methods
        public virtual void mostrarPrecio() { }
        public Vehiculo(double precio)
        {
            this._precio = precio; 
        }
        #endregion

    }
}
