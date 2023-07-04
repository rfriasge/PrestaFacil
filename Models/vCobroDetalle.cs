namespace PrestaFacil.Models
{
    public class vCobroDetalle
    {
        public int Id { get; set; }
        public int CobroId { get; set; }
        public int Tipo_transaccionId { get; set; }
        public int PrestamoId { get; set; }
        public int NoCuota { get; set; }
        public double Cuota { get; set; }
    }
}
