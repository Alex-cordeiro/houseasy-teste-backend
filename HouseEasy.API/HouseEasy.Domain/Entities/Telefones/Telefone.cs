
using HouseEasy.Domain.Entities.Base;

namespace HouseEasy.Domain.Entities.Telefones
{
    public class Telefone : BaseEntity
    {
        public string Fixo { get; set; }
        public string Celular { get; set; }
        public bool IsWhatsApp { get; set; }
    }
}
