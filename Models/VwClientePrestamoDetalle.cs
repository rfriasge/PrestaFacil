using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrestaFacil.Models
{
    public partial class VwClientePrestamoDetalle
    {
        public int? ClienteId { get; set; }
        public decimal? MontoPrestamo { get; set; }
        public decimal? Tasa { get; set; }
        public int? CantidadCuota { get; set; }
        public int Id { get; set; }
        public int PrestamoId { get; set; }
        public int Tipo_transaccionId { get; set; }
        public int NoCuota { get; set; }
        public decimal? MontoCuota { get; set; }
        public decimal? CapitalCuota { get; set; }
        public decimal? InteresCuota { get; set; }
        public DateTime? FechaCuota { get; set; }
        public decimal? CapitalPendiente { get; set; }
        public decimal? CapitalAcumulado { get; set; }
        public decimal? InteresAcumulado { get; set; }
        public int Estatus { get; set; }
        public string DesEstado { get; set; }
    }
}
