using HouseEasy.Application.Contracts.Request.Enderecos;
using HouseEasy.Application.Contracts.Request.Ocupacoes;
using HouseEasy.Application.Contracts.Request.Telefones;
using System.ComponentModel.DataAnnotations;

namespace HouseEasy.Application.Contracts.Request.Usuarios
{
    public struct UsuarioUpdateRequest
    {
        [Required(ErrorMessage = "O Campo {0} é obrigatório")]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string UserName { get; set; }
        public int Idade { get; set; }
        public TelefoneUpdateRequest Telefone { get; set; }
        public List<OcupacaoUpdateRequest> Ocupacoes { get; set; }
        public EnderecoUpdateRequest Endereco { get; set; }
    }
}
