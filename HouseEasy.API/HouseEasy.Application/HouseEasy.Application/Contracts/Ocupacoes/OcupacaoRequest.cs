using System.ComponentModel.DataAnnotations;

namespace HouseEasy.Application.Contracts.Ocupacoes
{
    public struct OcupacaoRequest
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "O Campo {0} é obrigatório")]
        public string Descricao { get; set; }
        [Required(ErrorMessage = "O Campo {0} é obrigatório")]
        public string Cargo { get; set; }
        [Required(ErrorMessage = "O Campo {0} é obrigatório")]
        public string CBO { get; set; }
    }
}
