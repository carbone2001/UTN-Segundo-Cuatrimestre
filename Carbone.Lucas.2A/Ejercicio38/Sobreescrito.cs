namespace Ejercicio38
{
    public class Sobreescrito
    {
        public override string ToString()
        {
            return "¡Este es mi método ToString sobreescrito!";
        }
        public override bool Equals(object obj)
        {
            if (obj is Sobreescrito)
                return true;
            return false;
        }
        public override int GetHashCode()
        {
            return 1142510187;
        }
    }
}
