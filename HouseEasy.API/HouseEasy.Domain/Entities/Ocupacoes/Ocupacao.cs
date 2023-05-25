using HouseEasy.Domain.Entities.Base;

namespace HouseEasy.Domain.Entities.Ocupacao
{
    public class Ocupacao : BaseEntity
    {
        public string Descricao { get; set; }
        public string Cargo { get; set; }
        public string CBO { get; set; }
    }
}
