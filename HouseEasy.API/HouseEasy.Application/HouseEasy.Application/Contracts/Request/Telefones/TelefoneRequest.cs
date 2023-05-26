using System.ComponentModel.DataAnnotations;

namespace HouseEasy.Application.Contracts.Request.Telefones
{
    public struct TelefoneRequest
    {
        [Required(ErrorMessage = "O Campo {0} é obrigatório")]
        public string Fixo { get; set; }
        [Required(ErrorMessage = "O Campo {0} é obrigatório")]
        public string Celular { get; set; }
        [Required(ErrorMessage = "O Campo {0} é obrigatório")]
        public bool IsWhatsApp { get; set; }
        public int? UsuarioId { get; set; }
    }
}
