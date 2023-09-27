using AutoMapper;
using EletroMultiAPI.Data.DTOS.MarcaDto;
using EletroMultiAPI.Models;

namespace EletroMultiAPI.Profiles
{
    public class MarcaProfile:Profile
    {
        public MarcaProfile()
        {
            CreateMap<CreateMarcaDto, Marca>();
            CreateMap<Marca, ReadMarcaDto>();
        }
    }
}
