using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaPolimorfismo
{
    public abstract class Llamada
    {
        #region atributos
        protected float _duracion;
        protected string _nroDestino;
        protected string _nroOrigen;
        #endregion

        #region Propiedades
        public abstract float CostoLlamada {get;}
        public float Duracion
        {
            get { return this._duracion; }
        }
        public string NroDestino
        {
            get
            {
                return this._nroDestino;
            }
        }
        public string NroOrigen
        {
            get
            {
                return this._nroOrigen;
            }
        }
        #endregion

        #region Metodos
        public Llamada(string origen,string destino,float duracion)
        {
            this._duracion = duracion;
            this._nroDestino = destino;
            this._nroOrigen = origen;
        }
        protected virtual string Mostrar()
        {
            StringBuilder retorno = new StringBuilder("Duracion: " + _duracion.ToString() + " Nro. Destino: " + _nroDestino + " Nro. Origen: " + _nroOrigen + "\n");
            return retorno.ToString();
        }
        public static bool operator ==(Llamada uno, Llamada dos)
        {
            if ((!Object.Equals(uno, null) && !Object.Equals(dos, null)))
            {
                if(uno.NroDestino == dos.NroDestino && uno.NroOrigen == dos.NroOrigen)
                    return true;
                return false;
            }
            else
            {
                return Object.Equals(uno, dos);
            }
        }

        public static bool operator != (Llamada uno,Llamada dos)
        {
            return !(uno == dos);
        }
        public static int OrdenarPorDuracion(Llamada uno,Llamada dos)
        {
            if(uno.Duracion > dos.Duracion)
            {
                return -1;
            }
            else if(uno.Duracion == dos.Duracion)
            {
                return 0;
            }
            return 1;
        }
        #endregion
    }
}
