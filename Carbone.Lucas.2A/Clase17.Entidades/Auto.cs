using System;
using System.Collections.Generic;
using System.Text;

namespace Clase17.Entidades
{
    public class Auto
    {
        #region Campos
        private string _color;
        private string _marca;
        #endregion
        #region Propiedades
        public string Color { get { return this._color; } }
        public string Marca { get { return this._marca; } }
        #endregion
        #region Metodos
        public Auto(string color,string marca)
        {
            this._color = color;
            this._marca = marca;
        }
        public override bool Equals(object obj)
        {
            if (obj is Auto && (obj == this))
                return true;
            return false;
        }
        public static bool operator !=(Auto a, Auto b)
        {
            return !(a == b);
        }
        public static bool operator ==(Auto a, Auto b)
        {
            if (String.Compare(a.Marca, b.Marca) == 0 && String.Compare(b.Color, a.Color) == 0)
                return true;
            return false;
        }
        public override string ToString()
        {
            return String.Format("Marca: {0} - Color: {1}",this.Marca,this.Color);
        }
        #endregion
    }
}
