namespace PrestaFacil.Models
{
    public class Cobro_detalle
    {
        public int Id { get; set; }
        public int Cobro_cabeceraId { get; set; }
        public int Tipo_transaccionId { get; set; }
        public int PrestamoId { get; set; }
        public virtual string des_tipo_transaccion { get; set; }
        public int NoCuota { get; set; }
        public decimal Cuota { get; set; }

    }
}
