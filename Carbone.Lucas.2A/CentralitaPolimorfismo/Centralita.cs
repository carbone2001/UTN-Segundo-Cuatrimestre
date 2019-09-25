using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaPolimorfismo
{
    class Centralita
    {
        #region Atributos
        private List<Llamada> _listaDeLlamadas;
        protected string _razonSocial;
        #endregion

        #region Propiedades
        public float GananciaPorLocal
        {
            get
            {
                return 0;
            }
        }
        public float GananciaPorProvincial
        {
            get
            {
                return 0;
            }
        }
        public float GananciaTotal
        {
            get
            {
                return 0;
            }
        }
        public List<Llamada> Llamadas
        {
            get
            {
                return this._listaDeLlamadas;
            }
        }
        #endregion

        #region Metodos
        public static bool operator ==(Centralita central, Llamada nuevaLlamada)
        {
            if(!Object.Equals(central,null) && !Object.Equals(nuevaLlamada,null))
            {
                for(int i=0; i<central.Llamadas.Count; i++)
                {
                    if(central.Llamadas[i] == nuevaLlamada)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public static bool operator !=(Centralita central, Llamada nuevaLlamada)
        {
            return !(central == nuevaLlamada);
        }

        public static Centralita operator +(Centralita central, Llamada nuevaLlamada)
        {
            if (central != nuevaLlamada)
            {
                central.Llamadas.Add(nuevaLlamada);
                return central;
            }
            else
            {
                Console.WriteLine("Ya existe el objeto");
                return central;
            }
                
        }


        private void AgregarLlamada(Llamada nuevaLlamada)
        {
            if(this != nuevaLlamada)
                this.Llamadas.Add(nuevaLlamada);
        }
        private float CalcularGanancia(TipoLlamada tipo)
        {
            return 0;
        }
        public Centralita()
        {
            _listaDeLlamadas = new List<Llamada>();
        }
        public Centralita(string nombreEmpresa): this()
        {
            this._razonSocial = nombreEmpresa;
        }

        public void OrdenarLlamadas()
        {
            this.Llamadas.Sort(Llamada.OrdenarPorDuracion);
        }
        #endregion
    }
}
