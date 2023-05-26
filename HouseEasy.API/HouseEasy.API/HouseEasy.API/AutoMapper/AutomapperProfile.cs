using AutoMapper;
using HouseEasy.Application.Contracts.Enderecos;
using HouseEasy.Application.Contracts.Usuarios;
using HouseEasy.Domain.Entities.Enderecos;
using HouseEasy.Domain.Entities.Usuarios;

namespace HouseEasy.API.Profiles
{
    public class AutomapperProfile : Profile
    {
        public AutomapperProfile() 
        {
            CreateMap<UsuarioRequest, Usuario>().ReverseMap();
            CreateMap<EnderecoRequest, Endereco>().ReverseMap();
        }
    }
}
