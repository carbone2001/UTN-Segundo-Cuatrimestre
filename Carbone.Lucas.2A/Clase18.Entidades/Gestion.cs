using System;
using System.Collections.Generic;
using System.Text;

namespace Clase18.Entidades
{
    public static class Gestion
    {
        #region Methods
        public static double MostrarImpuestoNacional(IAFIP bienPunible)
        {
            return bienPunible.CalcularImpuesto();
        }
        public static double MostrarImpuestoProvincial(IARBA bienPunible)
        {
            return bienPunible.CalcularImpuesto();
        }
        #endregion
    }
}
