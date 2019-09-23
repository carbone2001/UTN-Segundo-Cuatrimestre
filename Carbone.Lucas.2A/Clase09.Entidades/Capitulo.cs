using System;

namespace Clase09.Entidades
{
    public class Capitulo
    {
        private int numero;
        private string titulo;
        private int paginas;
        private static Random generadorDeNumeros;
        private static Random generadorDePaginas;

        public int Numero
        {
            get
            {
                return this.numero;
            }
        }
        public string Titulo
        {
            get
            {
                return this.titulo;
            }
        }
        public int Paginas
        {
            get
            {
                return this.paginas;
            }
        }
        static Capitulo()
        {
            Capitulo.generadorDeNumeros = new Random();
            Capitulo.generadorDePaginas = new Random();
        }
        private Capitulo(int numero, string titulo, int pagina)
        {
            this.titulo = titulo;
            this.numero = numero;
            this.paginas = pagina;

        }
        public static implicit operator Capitulo(string s)
        {

            Capitulo c = new Capitulo(Capitulo.generadorDeNumeros.Next(1, 66), s, Capitulo.generadorDePaginas.Next(15, 234));
            return c;
        }

        public static bool operator ==(Capitulo x, Capitulo y)
        {
            if (x.Numero == y.Numero && x.Titulo == y.Titulo)
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Capitulo x, Capitulo y)
        {
            return !(x == y);
        }
    }
}
