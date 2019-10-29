using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase20.Entidades
{
    public static class Serializadora
    {
        public static bool Serealizar(IXML xml)
        {
            return xml.Guardar(Environment.GetFolderPath(Environment.SpecialFolder.Desktop)+"\\archivoXML.xml");
        }
        
        public static bool Deserealizar(IXML xml, out object obj)
        {
            return xml.Leer(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\archivoXML.xml",out obj);
        }
    }
}
