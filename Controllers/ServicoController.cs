using AutoMapper;
using EletroMultiAPI.Data;
using EletroMultiAPI.Data.DTOS.ServicosDTOS;
using EletroMultiAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace EletroMultiAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ServicoController:ControllerBase
    {
        private EletroMultiContext _context;
        private IMapper _mapper;

        public ServicoController(EletroMultiContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        [HttpPost]
        public IActionResult AdicionarServico([FromBody] CreateServicoDto servicoDto)
        {
            Servico servico = _mapper.Map<Servico>(servicoDto);
            _context.Servicos.Add(servico);
            _context.SaveChanges();
            return CreatedAtAction(nameof(BuscaServicoPorId), new { id = servico.ServicoId }, servico);

        }
        [HttpGet]
        public IEnumerable<ReadServicoDto> RecuperarServicos([FromQuery] int skip = 0, [FromQuery] int take = 10)
        {
            return _mapper.Map<List<ReadServicoDto>>(_context.Servicos.Skip(skip).Take(take));
        }
        [HttpGet("{id}")]
        public IActionResult BuscaServicoPorId(int id)
        {
            var servico = _context.Servicos.FirstOrDefault(servico => servico.ServicoId == id);
            if (servico == null) return NotFound($"O Servico com id:{id} não existe.");
            var servicoDto = _mapper.Map<ReadServicoDto>(servico);
            return Ok(servicoDto);
        }
    }
}
