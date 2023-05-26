using System.ComponentModel.DataAnnotations;

namespace HouseEasy.Application.Contracts.Telefones
{
    public struct TelefoneRequest
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "O Campo {0} é obrigatório")]
        public string Fixo { get; set; }
        [Required(ErrorMessage = "O Campo {0} é obrigatório")]
        public string Celular { get; set; }
        [Required(ErrorMessage = "O Campo {0} é obrigatório")]
        public bool IsWhatsApp { get; set; }
    }
}
