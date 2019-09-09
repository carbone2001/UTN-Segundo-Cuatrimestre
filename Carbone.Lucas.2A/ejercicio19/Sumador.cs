namespace ejercicio19
{
    public class Sumador
    {
        public int cantidadSumas;
        public static explicit operator int(Sumador s)
        {
            return s.cantidadSumas;
        }
        public static bool operator |(Sumador s1, Sumador s2)
        {
            bool respuesta = false;
            if (s1.cantidadSumas == s2.cantidadSumas)
                respuesta = true;

            return respuesta;
        }
        public static long operator +(Sumador s1, Sumador s2)
        {
            long resultado;
            resultado = (long)s1.cantidadSumas + s2.cantidadSumas;
            return resultado;
        }
        public Sumador()
        {
            this.cantidadSumas = 0;
        }
        public Sumador(int cantidadSumas) : this()
        {
            this.cantidadSumas = cantidadSumas;
        }
        public long Sumar(long a, long b)
        {
            long resultado;
            this.cantidadSumas++;
            resultado = a + b;
            return resultado;
        }
        public string Sumar(string a, string b)
        {
            long resultado;
            this.cantidadSumas++;
            resultado = long.Parse(a) + long.Parse(b);
            return resultado.ToString();
        }


    }
}
