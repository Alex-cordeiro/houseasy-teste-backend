using System.ComponentModel.DataAnnotations;

namespace HouseEasy.Application.Contracts.Enderecos
{
    public struct EnderecoRequest
    {
        public int Id { get; set; }
        public string Complemento { get; set; }
        public string CEP { get; set; }
        [Required(ErrorMessage = "O Campo {0} é obrigatório")]
        public string Logradouro { get; set; }
        [Required(ErrorMessage = "O Campo {0} é obrigatório")]
        public string Bairro { get; set; }
        [Required(ErrorMessage = "O Campo {0} é obrigatório")]
        public string Localidade { get; set; }
        [Required(ErrorMessage = "O Campo {0} é obrigatório")]
        public string UF { get; set; }
        
    }
}
