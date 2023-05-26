using System.ComponentModel.DataAnnotations;

namespace HouseEasy.Application.Contracts.Request.Enderecos
{
    public struct EnderecoUpdateRequest
    {
        [Required(ErrorMessage = "O Campo {0} é obrigatório")]
        public int Id { get; set; }
        public string Complemento { get; set; }
        public string CEP { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string Localidade { get; set; }
        public string UF { get; set; }
    }
}
