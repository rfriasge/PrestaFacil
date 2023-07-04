using System;

namespace PrestaFacil.Models
{
    public class TablaAmortizacion
    {
        public int Id { get; set; }
        public int NoCuota { get; set; }
        public double MontoCuota { get; set; }
        public double CapitalCuota { get; set; }
        public double InteresCuota { get; set; }
        public DateTime FechaCuota { get; set; }
        public double CapitalPendiente { get; set; }
        public double CapitalAcumulado { get; set; }
        public double InteresAcumulado { get; set; }

    }
}
