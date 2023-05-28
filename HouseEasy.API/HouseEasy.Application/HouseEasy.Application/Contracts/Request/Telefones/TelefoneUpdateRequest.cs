using System.ComponentModel.DataAnnotations;

namespace HouseEasy.Application.Contracts.Request.Telefones
{
    public struct TelefoneUpdateRequest
    {
        [Required(ErrorMessage = "O Campo {0} é obrigatório")]
        public int Id { get; set; }
        public string Fixo { get; set; }
        public string Celular { get; set; }
        public bool IsWhatsApp { get; set; }
        [Required(ErrorMessage = "O Campo {0} é obrigatório")]
        public int UsuarioId { get; set; }
    }
}
