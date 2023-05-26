using System.ComponentModel.DataAnnotations;

namespace HouseEasy.Application.Contracts.Request.Ocupacoes
{
    public struct OcupacaoUpdateRequest
    {
        [Required(ErrorMessage = "O Campo {0} é obrigatório")]
        public int Id { get; set; }
        public string Descricao { get; set; }
        public string Cargo { get; set; }
        public string CBO { get; set; }
    }
}
