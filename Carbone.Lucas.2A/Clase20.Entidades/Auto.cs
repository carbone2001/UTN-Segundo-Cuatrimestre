using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
namespace Clase20.Entidades
{
    public class Auto:IXML
    {
        #region Campos
        public string marca;
        public double precio;
        #endregion
        #region Metodos
        public override string ToString()
        {
            return String.Format("{0} - {1}",this.marca,this.precio);
        }

        public bool Guardar(string path)
        {
            try
            {
                XmlSerializer xmlS = new XmlSerializer(typeof(Auto));
                TextWriter tw = new StreamWriter(path);
                xmlS.Serialize(tw, this);
                tw.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Leer(string path, out object obj)
        {
            try
            {
                XmlSerializer xmlS = new XmlSerializer(typeof(Auto));
                TextReader tr = new StreamReader(path);
                obj = (Auto)xmlS.Deserialize(tr);
                tr.Close();
                return true;
            }
            catch (Exception)
            {
                obj = null;
                return false;
            }
        }

        public Auto()
        {

        }
        public Auto(string marca, double precio):this()
        {
            this.marca = marca;
            this.precio = precio;
        }
        #endregion
    }
}
