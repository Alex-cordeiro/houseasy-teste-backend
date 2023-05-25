using HouseEasy.Domain.Entities.Base;

namespace HouseEasy.Domain.Entities.Usuarios
{
    public class Usuario : BaseEntity
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string UserName { get; set; }
        public int Idade { get; set; }
    }
}
