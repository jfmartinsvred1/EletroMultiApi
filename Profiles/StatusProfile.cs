using AutoMapper;
using EletroMultiAPI.Data.DTOS.StatusDto;
using EletroMultiAPI.Models;

namespace EletroMultiAPI.Profiles
{
    public class StatusProfile:Profile
    {
        public StatusProfile()
        {
            CreateMap<CreateStatusDto, Status>();
            CreateMap<Status,ReadStatusDto>();

        }
    }
}
