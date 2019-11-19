using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Externa.Sellada;
using System.Data.SqlClient;
using System;
using System.Data;
using System.IO;
namespace Clase26.EntidadesTest
{
    public static class Extensora
    {
        
        public static string ObtenerInfo(this PersonaExternaSellada p)
        {
            return p.Apellido+" - "+p.Nombre + " - "+p.Edad+" - "+p.Sexo.ToString();
        }
        public static bool EsNulo(this object obj)
        {
            return (obj == null);
        }
        public static List<Persona> ObtenerListadoBD(this Persona p)
        {
            List<Persona> list = new List<Persona>();
            try
            {
                DataTable dtPersonas = new DataTable();
                SqlConnection conexion = new SqlConnection(Entidades.Properties.Settings.Default.Conexion);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT TOP 1000 [id],[nombre],[apellido],[edad]FROM[personas_bd].[dbo].[personas]";
                
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read() != false)
                {
                    string nombre = reader["nombre"].ToString();
                    string apellido = reader["apellido"].ToString();
                    int edad = int.Parse(reader["edad"].ToString());
                    list.Add(new Persona(nombre,apellido,edad));
                }
                reader.Close();
                conexion.Close();
                return list;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
        }
    }
}
