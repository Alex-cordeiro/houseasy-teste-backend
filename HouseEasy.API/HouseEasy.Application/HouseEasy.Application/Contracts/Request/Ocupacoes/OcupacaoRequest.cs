using System.ComponentModel.DataAnnotations;

namespace HouseEasy.Application.Contracts.Request.Ocupacoes
{
    public struct OcupacaoRequest
    {
        [Required(ErrorMessage = "O Campo {0} é obrigatório")]
        public string Descricao { get; set; }
        [Required(ErrorMessage = "O Campo {0} é obrigatório")]
        public string Cargo { get; set; }
        [Required(ErrorMessage = "O Campo {0} é obrigatório")]
        public string CBO { get; set; }
        public int? UsuarioId { get; set; }
    }
}
