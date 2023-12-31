﻿using AutoMapper;
using EletroMultiAPI.Data.DTOS.ClienteDTOS;
using EletroMultiAPI.Data.DTOS.EquipamentoDTO;
using EletroMultiAPI.Models;

namespace EletroMultiAPI.Profiles
{
    public class EquipamentoProfile:Profile
    {
        public EquipamentoProfile()
        {
            CreateMap<CreateEquipamentoDto, Equipamento>();
            CreateMap<Equipamento,ReadEquipamentoDto>();
            CreateMap<UpdateEquipamentoDto, Equipamento>();
            CreateMap<Equipamento, UpdateEquipamentoDto>();
        }
    }
}
