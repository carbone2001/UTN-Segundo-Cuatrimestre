using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;


namespace Clase20.Entidades
{
    public class Persona:IXML
    {
        public string nombre;
        public string apellido;
        private int edad;
        private List<string> apodos;

        public int Edad { get { return this.edad; } set { this.edad = value; } }

        public Persona(string nombre,string apellido,int edad):this()
        {
            this.apellido = apellido;
            this.nombre = nombre;
            this.edad = edad;
        }
        public List<string> Apodos { get { return this.apodos; } set { this.apodos = value; } }
        public Persona() { this.Apodos = new List<string>(); }
        public override string ToString()
        {
            //Apodos
            StringBuilder apodos = new StringBuilder();
            foreach (string x in this.Apodos)
                apodos.Append(" "+x+",");

            return this.nombre + " - "+this.apellido + " - "+this.edad+" Apodos:"+apodos.ToString();
        }

        bool IXML.Guardar(string path)
        {
            try
            {
                XmlSerializer xmlS = new XmlSerializer(typeof(Persona));
                TextWriter tw = new StreamWriter(path);
                xmlS.Serialize(tw, this);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        bool IXML.Leer(string path, out object obj)
        {
            try
            {
                XmlSerializer xmlS = new XmlSerializer(typeof(Persona));
                TextReader tr = new StreamReader(path);
                obj = (Persona)xmlS.Deserialize(tr);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                obj = null;
                return false;
            }
        }
    }
}
