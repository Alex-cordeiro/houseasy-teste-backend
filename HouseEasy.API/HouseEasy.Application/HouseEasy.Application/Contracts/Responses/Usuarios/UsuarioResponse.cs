using HouseEasy.Application.Contracts.Responses.Enderecos;
using HouseEasy.Application.Contracts.Responses.Ocupacoes;
using HouseEasy.Application.Contracts.Responses.Telefones;

namespace HouseEasy.Application.Contracts.Responses.Usuarios
{
    public class UsuarioResponse
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string UserName { get; set; }
        public int Idade { get; set; }
        public TelefoneResponse Telefone { get; set; }
        public EnderecoResponse Endereco { get; set; }
        public List<OcupacaoResponse> Ocupacoes { get; set; }
    }
}
