using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio21
{
    public class Celsius
    {
        public double temperatura;
        public Celsius() : this(0)
        {
        }
        public Celsius(double t)
        {
            this.temperatura = t;
        }
        public static Celsius operator +(Celsius f, double d)
        {
            f.temperatura += d;
            return f;
        }
        public static Celsius operator -(Celsius f, double d)
        {
            f.temperatura -= d;
            return f;
        }
        public static Celsius operator *(Celsius f, double d)
        {
            f.temperatura = f.temperatura * d;
            return f;
        }
        public static Celsius operator /(Celsius f, double d)
        {
            f.temperatura = f.temperatura / d;
            return f;
        }
        public static explicit operator Fahrenheit(Celsius c)
        {
            Fahrenheit f = new Fahrenheit();
            f.temperatura = c.temperatura * (9 / 5) + 32;
            return f;
        }
        public static explicit operator Kelvin(Celsius c)
        {
            Kelvin k = new Kelvin();
            k = (Kelvin)((Fahrenheit)c);
            return k;
        }
        public static implicit operator Celsius(double d)
        {
            Celsius c = new Celsius();
            c.temperatura = d;
            return c;
        }
        public static implicit operator String(Celsius x)
        {
            return x.temperatura.ToString();
        }

    }
}
