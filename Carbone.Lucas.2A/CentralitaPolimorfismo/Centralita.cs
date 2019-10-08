using System;
using System.Collections.Generic;

namespace CentralitaPolimorfismo
{
    public class Centralita
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
                return this.CalcularGanancia(TipoLlamada.Local);
            }
        }
        public float GananciaPorProvincial
        {
            get
            {
                return this.CalcularGanancia(TipoLlamada.Provincial);
            }
        }
        public float GananciaTotal
        {
            get
            {
                return this.CalcularGanancia(TipoLlamada.Todas);
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
            if (!Object.Equals(central, null) && !Object.Equals(nuevaLlamada, null))
            {
                for (int i = 0; i < central.Llamadas.Count; i++)
                {
                    if (central.Llamadas[i] == nuevaLlamada)
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
            if (this != nuevaLlamada)
                this.Llamadas.Add(nuevaLlamada);
        }
        private float CalcularGanancia(TipoLlamada tipo)
        {
            float resultado = 0;
            switch (tipo)
            {
                case TipoLlamada.Local:
                    foreach (Llamada llamada in this._listaDeLlamadas)
                    {
                        if (llamada is Local)
                        {
                            resultado += llamada.CostoLlamada;
                        }
                    }
                    break;
                case TipoLlamada.Provincial:
                    foreach (Llamada llamada in this._listaDeLlamadas)
                    {
                        if (llamada is Local)
                        {
                            resultado += llamada.CostoLlamada;
                        }
                    }
                    break;
                case TipoLlamada.Todas:
                    foreach (Llamada llamada in this._listaDeLlamadas)
                    {
                        if (llamada is Local)
                        {
                            resultado += llamada.CostoLlamada;
                        }
                    }
                    break;
            }


            return resultado;
        }
        public Centralita()
        {
            _listaDeLlamadas = new List<Llamada>();
        }
        public Centralita(string nombreEmpresa) : this()
        {
            this._razonSocial = nombreEmpresa;
        }

        public void OrdenarLlamadas(byte i)
        {
            if (i == 1)
                this.Llamadas.Sort(Llamada.OrdenarPorDuracionAsc);
            else
                this.Llamadas.Sort(Llamada.OrdenarPorDuracionDesc);

        }
        #endregion
    }
}
