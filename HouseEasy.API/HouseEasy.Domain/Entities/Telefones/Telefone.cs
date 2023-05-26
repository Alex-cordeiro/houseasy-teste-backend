
using HouseEasy.Domain.Entities.Base;
using HouseEasy.Domain.Entities.Usuarios;

namespace HouseEasy.Domain.Entities.Telefones
{
    public class Telefone : BaseEntity
    {
        public string Fixo { get; set; }
        public string Celular { get; set; }
        public bool IsWhatsApp { get; set; }
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
    }
}
