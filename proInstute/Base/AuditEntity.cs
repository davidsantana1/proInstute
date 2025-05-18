using proInstute.Domain.Base;

namespace proInstute.Domain.Base
{
    public abstract class AuditEntity : BaseEntity
    {
        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public string UsuarioCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
    }
}
