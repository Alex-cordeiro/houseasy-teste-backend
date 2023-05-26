using System.ComponentModel.DataAnnotations;

namespace HouseEasy.Application.Contracts.Responses.Ocupacoes
{
    public class OcupacaoResponse
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public string Cargo { get; set; }
        public string CBO { get; set; }
    }
}
