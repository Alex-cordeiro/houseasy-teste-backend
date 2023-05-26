using System.ComponentModel.DataAnnotations;

namespace HouseEasy.Application.Contracts.Request.Usuarios
{
    public struct UsuarioRequest
    {
        [Required(ErrorMessage = "O Campo {0} é obrigatório")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "O Campo {0} é obrigatório")]
        public string Sobrenome { get; set; }
        [Required(ErrorMessage = "O Campo {0} é obrigatório")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "O Campo {0} é obrigatório")]
        public int Idade { get; set; }
    }
}
