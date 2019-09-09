using System;

namespace Clase03
{
    class Persona
    {
        public string nombre;
        public string apellido;
        public int dni;
        public string Mostrar()
        {
            return this.nombre + " " + this.apellido + " " + this.dni.ToString() + '\n';
        }
        public Persona(String nombre, String apellido, int dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
        }

    }
}
