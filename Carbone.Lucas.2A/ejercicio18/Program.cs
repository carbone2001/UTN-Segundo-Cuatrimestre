namespace ejercicio18
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
namespace Geometria
{
    public class Punto
    {
        private int x;
        private int y;
        public int GetX()
        {
            return this.x;
        }
        public int GetY()
        {
            return this.y;
        }
        public Punto(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
    public class Rectangulo
    {
        float Area;
        float Perimetro;
        Punto vertice1;
        Punto vertice2;
        Punto vertice3;
        Punto vertice4;
        public float GetArea()
        {
            if (this.Area == 0)
            {

            }

            return 0;
        }
        public float GetPerimetro()
        {
            if (this.Perimetro == 0)
            {

            }
            return 0;
        }
        public Rectangulo(Punto vertice1, Punto vertice3)
        {
            /*int altura;
            int Base;
            altura = Math.Abs(vertice1.GetY());
            Base = Math.Abs(vertice3.GetX());*/
            this.vertice1 = vertice1;
            this.vertice3 = vertice3;
        }

    }
}
