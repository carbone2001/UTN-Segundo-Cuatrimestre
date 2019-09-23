using System;

namespace Ejercicio21
{
    public class Kelvin
    {
        public double temperatura;
        public Kelvin() : this(0)
        {
        }
        public Kelvin(double t)
        {
            this.temperatura = t;
        }
        public static Kelvin operator +(Kelvin f, double d)
        {
            f.temperatura += d;
            return f;
        }
        public static Kelvin operator -(Kelvin f, double d)
        {
            f.temperatura -= d;
            return f;
        }
        public static Kelvin operator *(Kelvin f, double d)
        {
            f.temperatura = f.temperatura * d;
            return f;
        }
        public static Kelvin operator /(Kelvin f, double d)
        {
            f.temperatura = f.temperatura / d;
            return f;
        }
        public static explicit operator Fahrenheit(Kelvin k)
        {
            Fahrenheit f = new Fahrenheit();
            f = (Fahrenheit)(k.temperatura * 9 / 5 - 459.67);
            return f;
        }
        public static explicit operator Celsius(Kelvin k)
        {
            Celsius c = new Celsius();
            c = (Celsius)((Fahrenheit)k);
            return c;
        }
        public static implicit operator Kelvin(double k)
        {
            Kelvin r = new Kelvin(k);
            return r;
        }
        public static implicit operator String(Kelvin x)
        {
            return x.temperatura.ToString();
        }
    }
}
