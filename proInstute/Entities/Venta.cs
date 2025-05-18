using proInstute.Domain.Base;

namespace proInstute.Domain.Entities
{
    public class Venta : AuditEntity
    {
        public DateTime FechaVenta { get; set; }
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public decimal Total { get; set; }
        public ICollection<DetalleVenta> Detalles { get; set; }
    }
}
