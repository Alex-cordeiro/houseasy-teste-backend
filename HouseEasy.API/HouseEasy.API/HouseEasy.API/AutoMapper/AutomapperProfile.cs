using AutoMapper;
using HouseEasy.Application.Contracts.Request.Enderecos;
using HouseEasy.Application.Contracts.Request.Ocupacoes;
using HouseEasy.Application.Contracts.Request.Telefones;
using HouseEasy.Application.Contracts.Request.Usuarios;
using HouseEasy.Application.Contracts.Responses.Enderecos;
using HouseEasy.Application.Contracts.Responses.Ocupacoes;
using HouseEasy.Application.Contracts.Responses.Telefones;
using HouseEasy.Application.Contracts.Responses.Usuarios;
using HouseEasy.Domain.Entities.Enderecos;
using HouseEasy.Domain.Entities.Ocupacoes;
using HouseEasy.Domain.Entities.Telefones;
using HouseEasy.Domain.Entities.Usuarios;

namespace HouseEasy.API.Profiles
{
    public class AutomapperProfile : Profile
    {
        public AutomapperProfile() 
        {
            CreateMap<UsuarioRequest, Usuario>().ReverseMap();
            CreateMap<UsuarioResponse, Usuario>()
                    .ForMember(x => x.Telefone, opt => opt.MapFrom(src => src.Telefone))
                    .ForMember(x => x.Ocupacoes, opt => opt.MapFrom(src => src.Ocupacoes)).ReverseMap();

            CreateMap<UsuarioUpdateRequest, Usuario>().ReverseMap();

            CreateMap<EnderecoRequest, Endereco>().ReverseMap();
            CreateMap<EnderecoUpdateRequest, Endereco>().ReverseMap();
            CreateMap<EnderecoResponse, Endereco>().ReverseMap();
            CreateMap<TelefoneRequest, Telefone>().ReverseMap();
            CreateMap<TelefoneUpdateRequest, Telefone>().ReverseMap();
            CreateMap<TelefoneResponse, Telefone>().ReverseMap();
            CreateMap<OcupacaoRequest, Ocupacao>().ReverseMap();
            CreateMap<OcupacaoUpdateRequest, Ocupacao>().ReverseMap();
            CreateMap<OcupacaoResponse, Ocupacao>().ReverseMap();
        }
    }
}
