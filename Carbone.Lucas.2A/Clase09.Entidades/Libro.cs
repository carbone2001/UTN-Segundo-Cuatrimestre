using System;
using System.Collections.Generic;
using System.Text;

namespace Clase09.Entidades
{
    public class Libro
    {
        private string titulo;
        private string autor;
        private List<Capitulo> capitulos;
        public string Titulo
        {
            get
            {
                return this.titulo;
            }
        }
        public string Autor
        {
            get
            {
                return this.autor;
            }
        }
        public Libro(string titulo, string autor)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.capitulos = new List<Capitulo>();
        }
        public int CantidadPaginas
        {
            get
            {
                int sumaPaginas = 0;
                foreach(Capitulo c in this.capitulos)
                {
                    sumaPaginas += c.Paginas;
                }
                return sumaPaginas;
            }
        }
        //Indexador
        public Capitulo this[int i]
        {
            
            get
            {
                if (i < this.capitulos.Count && i>=0)
                {
                    return this.capitulos[i];
                }
                else
                {
                    return null;
                }
            }
            set
            {
                if (i < this.capitulos.Count && i >= 0)
                {
                    this.capitulos.Insert(i, value);
                }
                else if(i==this.capitulos.Count)
                {
                    this.capitulos.Add(value);
                }
            }
        }
        public int CantidadDeCapitulos
        {
            get
            {
                return this.capitulos.Count;
            }
        }
    }
}
