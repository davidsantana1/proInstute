using proInstute.Domain.Base;

namespace proInstute.Domain.Entities
{
    public class Cliente : AuditEntity
    {
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
    }
}
