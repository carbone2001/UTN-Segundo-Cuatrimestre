using System;

namespace Ejercicio21
{
    public class Fahrenheit
    {
        public double temperatura;
        public Fahrenheit() : this(0)
        {
        }
        public Fahrenheit(double t)
        {
            this.temperatura = t;
        }
        public static Fahrenheit operator +(Fahrenheit f, double d)
        {
            f.temperatura += d;
            return f;
        }
        public static Fahrenheit operator -(Fahrenheit f, double d)
        {
            f.temperatura -= d;
            return f;
        }
        public static Fahrenheit operator *(Fahrenheit f, double d)
        {
            f.temperatura = f.temperatura * d;
            return f;
        }
        public static Fahrenheit operator /(Fahrenheit f, double d)
        {
            f.temperatura = f.temperatura / d;
            return f;
        }
        public static explicit operator Celsius(Fahrenheit f)
        {
            Celsius c = new Celsius();
            c.temperatura = ((f.temperatura - 32) * 5 / 9);
            return c;
        }
        public static explicit operator Kelvin(Fahrenheit f)
        {
            Kelvin k = new Kelvin();
            k.temperatura = ((f.temperatura + 459.67) * 5 / 9);
            return k;
        }
        public static explicit operator Fahrenheit(double d)
        {
            Fahrenheit f = new Fahrenheit();
            f.temperatura = d;
            return f;
        }
        public static implicit operator String(Fahrenheit x)
        {
            return x.temperatura.ToString();
        }

    }
}
