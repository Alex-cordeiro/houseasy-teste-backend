using System.ComponentModel.DataAnnotations;

namespace HouseEasy.Application.Contracts.Request.Enderecos
{
    public struct EnderecoRequest
    {
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
        public int? UsuarioId { get; set; }
    }
}
