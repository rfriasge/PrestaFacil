using System;
using System.ComponentModel.DataAnnotations;

namespace PrestaFacil.Models
{
    public class CalculoPrestamoPrev
    {
        [Range(1, 9999999999.00, ErrorMessage = "Obligatorio")]
        public double MontoPrestamo { get; set; }
        [Range(1, 9999999999.00, ErrorMessage = "Obligatorio")]
        public int CantidadMeses { get; set; }
        [Range(1, 9999999999.00, ErrorMessage = "Obligatorio")]
        public double Tasa { get; set; }
        public int TipoPrestamo { get; set; }
         public int ClienteId { get; set; }
        [Required(ErrorMessage = "Obligatorio")]
        public string NombreCliente { get; set; }
        [Range(1, 9999999999.00, ErrorMessage = "Obligatorio")]
        public double MontoCuota { get; set; }
    }
}
