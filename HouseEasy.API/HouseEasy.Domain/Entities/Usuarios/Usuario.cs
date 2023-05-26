using HouseEasy.Domain.Entities.Base;
using HouseEasy.Domain.Entities.Enderecos;
using HouseEasy.Domain.Entities.Ocupacoes;
using HouseEasy.Domain.Entities.Telefones;

namespace HouseEasy.Domain.Entities.Usuarios
{
    public class Usuario : BaseEntity
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string UserName { get; set; }
        public int Idade { get; set; }

        public Endereco Endereco { get; set; }
        public Telefone Telefone { get; set; }
        public List<Ocupacao> Ocupacoes { get; set; }
    }
}
