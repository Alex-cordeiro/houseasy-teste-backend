using HouseEasy.Domain.Entities.Base;
using HouseEasy.Domain.Entities.Usuarios;

namespace HouseEasy.Domain.Entities.Enderecos
{
    public class Endereco : BaseEntity
    {
        public string Logradouro { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Localidade { get; set; }
        public string UF { get; set; }
        public string CEP { get; set; }
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
    }
}
