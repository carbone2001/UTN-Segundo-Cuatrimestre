using Clase25.Entidades;
public delegate void LimiteSueldoDelegado(double sueldo, Empleado emp);
public delegate void LimiteSueldoMejoradoDel(Empleado sender, EmpleadoEventArgs e);
public enum TipoManejador
{
    LimiteSueldo,
    LimiteSueldoMejorado,
    Todos,
}