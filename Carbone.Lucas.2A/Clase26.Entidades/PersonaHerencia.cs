using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Externa;
namespace Clase26.EntidadesTest
{
    public class PersonaHerencia : PersonaExterna
    {
        public PersonaHerencia(string nombre, string apellido, int edad, ESexo sexo) : base(nombre, apellido, edad, sexo)
        {
        }
        #region Propiedades
        public string Nombre { get { return this._nombre; } }
        public string Apellido { get { return this._apellido; } }
        public int Edad { get { return this._edad; }}
        public ESexo Sexo { get { return this._sexo; } }
        #endregion
        #region Metodos
        public string ObtenerInfo()
        {
            return this.Apellido+" - "+this.Nombre+" - "+this.Edad + " - "+this.Sexo.ToString();
        }
        #endregion
    }
}
