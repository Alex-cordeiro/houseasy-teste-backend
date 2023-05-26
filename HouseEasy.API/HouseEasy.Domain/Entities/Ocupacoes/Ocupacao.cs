using HouseEasy.Domain.Entities.Base;
using HouseEasy.Domain.Entities.Usuarios;

namespace HouseEasy.Domain.Entities.Ocupacoes
{
    public class Ocupacao : BaseEntity
    {
        public string Descricao { get; set; }
        public string Cargo { get; set; }
        public string CBO { get; set; }
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
    }
}
