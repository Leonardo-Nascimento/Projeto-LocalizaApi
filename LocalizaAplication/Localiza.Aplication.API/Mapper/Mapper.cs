using AutoMapper;
using Localiza.Domain.Models;
using Localiza.WebAPI.Dtos;

namespace Localiza.WebAPI.Mapper
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<ClienteDTO, Cliente>()
                .ForMember(x => x.Endereco, opt => opt.Ignore());

            CreateMap<EnderecoDTO, Endereco>();
            CreateMap<FabricanteDTO, Fabricante>();
            CreateMap<ModeloDTO, Modelo>();

            CreateMap<ReservaDTO, Reserva>();
            CreateMap<Reserva, ReservaDTO>();

            CreateMap<VeiculoDTO, Veiculo>();

            CreateMap<Veiculo, VeiculoDTO>()
                .ForMember(x => x.Status, opt => opt.MapFrom( x => x.Status.ToString()));

        }
    }
}


