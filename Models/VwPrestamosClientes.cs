using System;

namespace PrestaFacil.Models
{
    public class VwPrestamosClientes
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public int PrestamoId { get; set; }
        public string Nombre_cliente { get; set; }
        public DateTime Feccre { get; set; }
        public Decimal Monto_prestamo { get; set; }
        public Decimal tasa { get; set; }
        public int Cantidad_cuota { get; set; }
        public string estado { get; set; }
    }
}
