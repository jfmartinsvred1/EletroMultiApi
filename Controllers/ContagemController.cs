using AutoMapper;
using EletroMultiAPI.Data;
using Microsoft.AspNetCore.Mvc;

namespace EletroMultiAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContagemController:ControllerBase
    {
        private IMapper _mapper;
        private EletroMultiContext _context;

        public ContagemController(IMapper mapper, EletroMultiContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        [HttpGet("/Contador/Peritagem")]
        public IActionResult GetPeritagem() {
            var result=_context.Servicos.Where(p=>p.StatusId ==1).Count();
            return Ok(result);
        }
    }
}
