using AutoMapper;
using EletroMultiAPI.Data;
using EletroMultiAPI.Data.DTOS.ClienteDTOS;
using EletroMultiAPI.Data.DTOS.ServicosDTOS;
using EletroMultiAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
        public IEnumerable<ReadServicoDto> RecuperarServicos()
        {
            return _mapper.Map<List<ReadServicoDto>>(_context.Servicos.Include(c=>c.Equipamentos).Include(c=>c.Cliente));
        }
        [HttpGet("{id}")]
        public IActionResult BuscaServicoPorId(int id)
        {
            var servico = _context.Servicos.Include(e=>e.Equipamentos).FirstOrDefault(servico => servico.ServicoId == id);
            if (servico == null) return NotFound($"O Servico com id:{id} não existe.");
            var servicoDto = _mapper.Map<ReadServicoDto>(servico);
            return Ok(servicoDto);
        }

        [HttpPut("{id}")]
        public IActionResult AtualizarServico(int id, [FromBody] UpdateServicoDto servicoDto)
        {
            var servico = _context.Servicos.FirstOrDefault(Servico => Servico.ServicoId == id);
            if (servico == null) return NotFound($"O Servico com id: {id} não existe.");
            _mapper.Map(servicoDto, servico);
            _context.SaveChanges();
            return NoContent();
        }
        [HttpDelete("{id}")]
        public IActionResult DeletaServico(int id)
        {
            var servico = _context.Servicos.FirstOrDefault(s => s.ServicoId == id);
            if (servico == null) return NotFound($"O Cliente com id:{id} não existe.");
            _context.Servicos.Remove(servico);
            _context.SaveChanges();
            return NoContent();
        }

    }
}
