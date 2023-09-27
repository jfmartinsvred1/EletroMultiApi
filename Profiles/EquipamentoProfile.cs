using AutoMapper;
using EletroMultiAPI.Data.DTOS.EquipamentoDTOS;
using EletroMultiAPI.Models;

namespace EletroMultiAPI.Profiles
{
    public class EquipamentoProfile:Profile
    {
        public EquipamentoProfile()
        {
            CreateMap<CreateEquipamentoDto, Equipamento>();
            CreateMap<Equipamento,ReadEquipamentoDto>();
        }
    }
}
