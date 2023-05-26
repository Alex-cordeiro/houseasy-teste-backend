using System.ComponentModel.DataAnnotations;

namespace HouseEasy.Application.Contracts.Responses.Telefones
{
    public class TelefoneResponse
    {
        public int Id { get; set; }
        public string Fixo { get; set; }
        public string Celular { get; set; }
        public bool IsWhatsApp { get; set; }
    }
}
