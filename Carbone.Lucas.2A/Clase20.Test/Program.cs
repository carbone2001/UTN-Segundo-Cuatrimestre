using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase20.Entidades;
using System.Xml.Serialization;
using System.Xml;
using System.IO;
using System.Data.SqlClient;
namespace Clase20.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Persona> listaPersonas = new List<Persona>();
            List<Persona> listaPersonasAux = new List<Persona>();
            Persona p1 = new Persona("nombre1", "apellido1", 20);
            Persona p2 = new Persona("nombre2", "apellido2", 30);
            Empleado e1 = new Empleado("nombreEmp1", "apellidoEmp1", 20,1,10000);
            Empleado e2 = new Empleado("nombreEmp2", "apellidoEmp2", 30,2,11000);
            Alumno a1 = new Alumno("nombreAlumno1", "apellidoAlumno1", 20,8);
            Alumno a2 = new Alumno("nombreAlumno2", "apellidoAlumno2", 30,10);
            listaPersonas.Add(p1);
            listaPersonas.Add(p2);
            listaPersonas.Add(e1);
            listaPersonas.Add(e2);
            listaPersonas.Add(a1);
            listaPersonas.Add(a2);

            //Serializadora.Serealizar(listaPersonas);
            XmlSerializer xmlS = new XmlSerializer(typeof(List<Persona>));
            TextWriter tw = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop)+"\\ListaPersonas.xml");
            xmlS.Serialize(tw, listaPersonas);
            tw.Close();

            TextReader tr = new StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\ListaPersonas.xml");
            listaPersonasAux = (List<Persona>)xmlS.Deserialize(tr);
            tr.Close();

            Console.ReadLine();

            SqlConnection sql = new SqlConnection(Properties.Settings.Default.conexionpc11);
            sql.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = sql;
            command.CommandType = System.Data.CommandType.Text;
            //command.CommandText = "SELECT TOP 1000 [id],[nombre],[apellido],[edad] FROM[personas_bd].[dbo].[personas]";
            command.CommandText = "SELECT * FROM Personas";


            SqlDataReader sqlReader = command.ExecuteReader();
            int i = 0;
            while(sqlReader.Read() != false)
            {
                //Persona a =sqlReader[i];
                //Console.WriteLine(a.ToString());
                i++;
            }
            sqlReader.Close();
            sql.Close();




            /*//Persona individual
            Persona p = new Persona("Juan", "Perez", 20);

            //Lista de personas
            List<Persona> listaPersonas = new List<Persona>();
            Persona p1 = new Persona("nombre1", "apellido1", 18);
            p1.Apodos.Add("Nombrecito1");
            listaPersonas.Add(p1);
            Persona p2 = new Persona("nombre2", "apellido2", 19);
            p2.Apodos.Add("Nombrecito2");
            listaPersonas.Add(p2);
            Persona p3 = new Persona("nombre3", "apellido3", 20);
            p3.Apodos.Add("Nombrecito3");
            listaPersonas.Add(p3);
            Persona p4 = new Persona("nombre4", "apellido4", 22);
            p4.Apodos.Add("Nombrecito4");
            listaPersonas.Add(p4);

            //Autos
            Auto a1 = new Auto("Peugeot", 340000);
            Auto a2 = new Auto("Chevrolet", 250000); 
            Object a3 = new Auto();
            //Auto a4 = new Auto();

            Console.WriteLine(p.ToString());
            //Serealizar
            try
            {
                XmlSerializer xml = new XmlSerializer(typeof(Persona));
                TextWriter xmlW = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Persona.xml");
                xml.Serialize(xmlW, p);
                xmlW.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            //Deserealizar
            try
            {
                XmlSerializer xmlR = new XmlSerializer(typeof(Persona));
                TextReader tr = new StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Persona.xml");
                Console.WriteLine("Persona leida: "+((Persona)xmlR.Deserialize(tr)).ToString());
                tr.Close();
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            try
            {
                XmlSerializer xmlS = new XmlSerializer(typeof(List<Persona>));
                TextWriter tw = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\listaPersonas.xml");
                xmlS.Serialize(tw, listaPersonas);
                tw.Close();
                TextReader tr = new StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\listaPersonas.xml");
                foreach (Persona x in (List<Persona>)xmlS.Deserialize(tr))
                    Console.WriteLine(x.ToString());


            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }

            //UTILIZACION DE LA CLASE SERIALIZADORA
            Serializadora.Serealizar(a1);
            //Serializadora.Serealizar(a2);
            Serializadora.Deserealizar(a1,out a3);
            Console.WriteLine("Deserializado: "+a3.ToString());
            //Serializadora.Deserealizar(a1,out a4);*/


        }
    }
}
