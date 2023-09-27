using AutoMapper;
using EletroMultiAPI.Data.DTOS.ServicosDTOS;
using EletroMultiAPI.Models;

namespace EletroMultiAPI.Profiles
{
    public class ServicoProfile:Profile
    {
        public ServicoProfile()
        {
            CreateMap<CreateServicoDto, Servico>();
            CreateMap<Servico,ReadServicoDto>();
        }
    }
}
