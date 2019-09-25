using System;

namespace Clase12.Entidades
{
    public abstract class Llamada
    {
        #region atributos
        protected float _duracion;
        protected string _nroDestino;
        protected string _nroOrigen;
        #endregion

        #region Propiedades
        protected abstract float CostoLlamada();
        #endregion

        #region
        protected virtual string Mostrar()
        {
            return "Duracion: " + _duracion.ToString() + " Nro. Destino: " + _nroDestino + " Nro. Origen: " + _nroOrigen + "\n";
        }
        #endregion




    }
}
