using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace PrestaFacil.Models
{
    public class Prestamo_Detalle
    {
        public int Id { get; set; }
        public int PrestamoId { get; set; }
        public int Tipo_transaccionId { get; set; }
        public int NoCuota { get; set; }
        public decimal MontoCuota { get; set; }
        public decimal CapitalCuota { get; set; }
        public decimal InteresCuota { get; set; }
        
        public DateTime FechaCuota { get; set; }
        public decimal CapitalPendiente { get; set; }
        public decimal CapitalAcumulado { get; set; }
        public decimal InteresAcumulado { get; set; }
        public int Estatus { get; set; }
    }
}
