using AutoMapper;
using EletroMultiAPI.Data.DTOS.ClienteDTOS;
using EletroMultiAPI.Models;

namespace EletroMultiAPI.Profiles
{
    public class ClienteProfile:Profile
    {
        public ClienteProfile()
        {
            CreateMap<CreateClienteDto, Cliente>();
            CreateMap<UpdateClienteDto, Cliente>();
            CreateMap<Cliente,UpdateClienteDto>();
            CreateMap<Cliente,ReadClienteDto>();
        }
    }
}
