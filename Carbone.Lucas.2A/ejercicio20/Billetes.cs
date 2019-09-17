namespace Billetes
{
    public class Pesos
    {
        public double cantidad;
        public float cotizRespectoDolar;
        public Pesos()
        {
            this.cantidad = 0;
            this.cotizRespectoDolar = (float)38.33;
        }
        public Pesos(double cantidad) : this()
        {
            this.cantidad = cantidad;
        }
        public Pesos(double cantidad, float cotizacion) : this(cantidad)
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
            e.cantidad = (d.cantidad / d.cotizRespectoDolar) / e.cotizRespectoDolar;
            return e;
        }
        public static explicit operator Dolar(Pesos d)
        {
            Dolar e = new Dolar();
            e.cantidad = d.cantidad / d.cotizRespectoDolar;
            return e;
        }
        public static implicit operator Pesos(double d)
        {
            Pesos pes = new Pesos(d);
            return pes;
        }


        public static Pesos operator +(Pesos d, Dolar e)
        {
            d = d.cantidad + ((Dolar)e).cantidad;
            return d;
        }
        public static Pesos operator +(Pesos d, Euro e)
        {
            d = d.cantidad + ((Dolar)e).cantidad;
            return d;
        }
        public static Pesos operator -(Pesos d, Dolar e)
        {
            d = d.cantidad - ((Dolar)e).cantidad;
            return d;
        }
        public static Pesos operator -(Pesos d, Euro e)
        {
            d = d.cantidad - ((Dolar)e).cantidad;
            return d;
        }



        public static bool operator ==(Pesos d, Euro e)
        {
            bool rta = false;
            if (d.cantidad == e.cantidad)
                rta = true;
            return rta;

        }
        public static bool operator ==(Pesos d, Pesos e)
        {

            return d == e;

        }
        public static bool operator ==(Pesos d, Dolar e)
        {
            return d == e;

        }
        public static bool operator !=(Pesos d, Euro e)
        {
            return !(d == e);
        }

        public static bool operator !=(Pesos d, Pesos e)
        {
            return !(d == e);

        }
        public static bool operator !=(Pesos d, Dolar e)
        {

            return !(d == e);

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
        public Euro(double cantidad, float cotizacion) : this(cantidad)
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
            e.cantidad = d.cantidad*d.cotizRespectoDolar;
            return e;
        }
        public static explicit operator Pesos(Euro d)
        {
            Pesos e = new Pesos();
            e.cantidad = ((Dolar)d).cantidad*e.cotizRespectoDolar;
            return e;
        }
        public static implicit operator Euro(double d)
        {
            Euro eur = new Euro(d);
            return eur;
        }

        public static Euro operator +(Euro d, Dolar e)
        {
            d = d.cantidad + ((Dolar)e).cantidad;
            return d;
        }
        public static Euro operator +(Euro d, Pesos e)
        {
            d = d.cantidad + ((Dolar)e).cantidad;
            return d;
        }
        public static Euro operator -(Euro d, Dolar e)
        {
            d = d.cantidad - ((Dolar)e).cantidad;
            return d;
        }
        public static Euro operator -(Euro d, Pesos e)
        {
            d = d.cantidad - ((Dolar)e).cantidad;
            return d;
        }

        public static bool operator ==(Euro d, Euro e)
        {
            
            return (d.cantidad == e.cantidad);

        }
        public static bool operator ==(Euro d, Pesos e)
        {

            return (d.cantidad == e.cantidad);

        }
        public static bool operator ==(Euro d, Dolar e)
        {
            return (d.cantidad == e.cantidad);

        }
        public static bool operator !=(Euro d, Euro e)
        {
            return !(d == e);
        }

        public static bool operator !=(Euro d, Pesos e)
        {
            return !(d == e);

        }
        public static bool operator !=(Euro d, Dolar e)
        {

            return !(d == e);

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
        public Dolar(double cantidad) : this()
        {
            this.cantidad = cantidad;
        }
        public Dolar(double cantidad, float cotizacion) : this(cantidad)
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
        public static bool operator ==(Dolar d, Euro e)
        {
            bool rta = false;
            if (d.cantidad == e.cantidad)
                rta = true;
            return rta;

        }
        public static bool operator ==(Dolar d, Pesos e)
        {
            bool rta = false;
            if (d.cantidad == e.cantidad)
                rta = true;
            return rta;

        }
        public static bool operator ==(Dolar d, Dolar e)
        {
            return d==e;

        }
        public static bool operator !=(Dolar d, Euro e)
        {
            return !(d==e);
        }

        public static bool operator !=(Dolar d, Pesos e)
        {
            return !(d==e);

        }
        public static bool operator !=(Dolar d, Dolar e)
        {
            
            return !(d==e);

        }

        public static Dolar operator +(Dolar d,Euro e)
        {
            d = d.cantidad + ((Dolar)e).cantidad;
            return d;
        }
        public static Dolar operator +(Dolar d, Pesos e)
        {
            d = d.cantidad + ((Dolar)e).cantidad;
            return d;
        }
        public static Dolar operator -(Dolar d, Pesos e)
        {
            d = d.cantidad - ((Dolar)e).cantidad;
            return d;
        }
        public static Dolar operator -(Dolar d, Euro e)
        {
            d = d.cantidad - ((Dolar)e).cantidad;
            return d;
        }

        public static explicit operator Euro(Dolar d)
        {
            Euro e = new Euro();
            e.cantidad = d.cantidad / e.cotizRespectoDolar ;
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
