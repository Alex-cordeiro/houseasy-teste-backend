using HouseEasy.Domain.Entities.Base;

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
    }
}
