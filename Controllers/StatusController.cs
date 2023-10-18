using AutoMapper;
using EletroMultiAPI.Data;
using EletroMultiAPI.Data.DTOS.ServicosDTOS;
using EletroMultiAPI.Data.DTOS.StatusDto;
using EletroMultiAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EletroMultiAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StatusController:ControllerBase
    {
        private EletroMultiContext _context;
        private IMapper _mapper;

        public StatusController(EletroMultiContext context,IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public IEnumerable<ReadStatusDto> RecuperarServicos()
        {
            return _mapper.Map<List<ReadStatusDto>>(_context.Status);
        }
    }
}
