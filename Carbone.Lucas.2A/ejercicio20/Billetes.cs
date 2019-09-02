using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Pesos
    {
        public double cantidad;
        public float cotizRespectoDolar;
        public Pesos()
        {
            this.cantidad=0;
            this.cotizRespectoDolar= (float)0.026;
        }
        public Pesos(double cantidad):this()
        {
            this.cantidad = cantidad;
        }
        public Pesos(double cantidad, float cotizacion):this(cantidad)
        {
            this.cotizRespectoDolar = cotizacion;
        }
        public double GetCantidad()
        {
            return this.cantidad;
        }
        public float GetCotizacion()
        {
            return this.cotizRespectoDolar;
        }
        public static explicit operator Euro(Pesos d)
        {
            Euro e = new Euro();
            e.cantidad = e.cotizRespectoDolar * d.cantidad / d.cotizRespectoDolar;
            return e;
        }
        public static explicit operator Dolar(Pesos d)
        {
            Dolar e = new Dolar();
            e.cantidad = e.cotizRespectoDolar * d.cantidad / d.cotizRespectoDolar;
            return e;
        }
        public static implicit operator Pesos(double d)
        {
            Pesos pes = new Pesos(d);
            return pes;
        }




    }
    public class Euro
    {
        public double cantidad;
        public float cotizRespectoDolar;
        public Euro()
        {
            this.cantidad = 0;
            this.cotizRespectoDolar = (float)1.16;
        }
        public Euro(double cantidad) : this()
        {
            this.cantidad = cantidad;
        }
        public Euro(double cantidad, float cotizacion):this(cantidad)
        {
            this.cotizRespectoDolar = cotizacion;
        }
        public double GetCantidad()
        {
            return this.cantidad;
        }
        public float GetCotizacion()
        {
            return this.cotizRespectoDolar;
        }
        public static explicit operator Dolar(Euro d)
        {
            Dolar e = new Dolar();
            e.cantidad = e.cotizRespectoDolar * d.cantidad/d.cotizRespectoDolar;
            return e;
        }
        public static explicit operator Pesos(Euro d)
        {
            Pesos e = new Pesos();
            e.cantidad = e.cotizRespectoDolar * d.cantidad/d.cotizRespectoDolar;
            return e;
        }
        public static implicit operator Euro(double d)
        {
            Euro eur = new Euro(d);
            return eur;
        }


    }
    public class Dolar
    {
        public double cantidad;
        public float cotizRespectoDolar;
        public Dolar()
        {
            this.cantidad = 0;
            this.cotizRespectoDolar = 1;
        }
        public Dolar(double cantidad):this()
        {
            this.cantidad = cantidad;
        }
        public Dolar(double cantidad, float cotizacion):this(cantidad)
        {
            this.cotizRespectoDolar = cotizacion;
        }
        public double GetCantidad()
        {
            return this.cantidad;
        }
        public float GetCotizacion()
        {
            return this.cotizRespectoDolar;
        }
        public static bool operator !=(Dolar d, Euro e)
        {
            bool rta = false;
            if (d.cantidad != ((double)(e.cotizRespectoDolar * e.cantidad)))
                rta = true;
            return rta;

        }
        public static bool operator == (Dolar d, Euro e)
        {
            bool rta=false;
            if (d.cantidad == (double)(e.cotizRespectoDolar * e.cantidad))
                rta = true;
            return rta;
        }

        public static explicit operator Euro(Dolar d)
        {
            Euro e = new Euro();
            e.cantidad = e.cotizRespectoDolar * d.cantidad;
            return e;
        }
        public static explicit operator Pesos(Dolar d)
        {
            Pesos e = new Pesos();
            e.cantidad = e.cotizRespectoDolar * d.cantidad;
            return e;
        }
        public static implicit operator Dolar(double d)
        {
            Dolar dol = new Dolar(d);
            return dol;
        }
    }
}
