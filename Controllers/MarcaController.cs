using AutoMapper;
using EletroMultiAPI.Data;
using EletroMultiAPI.Data.DTOS.ClienteDTOS;
using EletroMultiAPI.Data.DTOS.MarcaDto;
using EletroMultiAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace EletroMultiAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MarcaController:ControllerBase
    {
        private EletroMultiContext _context;
        private IMapper _mapper;

        public MarcaController(EletroMultiContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        [HttpPost]
        public IActionResult AdicionarMarca([FromBody] CreateMarcaDto marcaDto) 
        {
            Marca marca=_mapper.Map<Marca>(marcaDto);
            _context.Marcas.Add(marca);
            _context.SaveChanges();
            return CreatedAtAction(nameof(BuscaMarcaPorId) ,new {id= marca.MarcaId}, marca);
            
        }
        [HttpGet]
        public IEnumerable<ReadMarcaDto> RecuperarMarcas([FromQuery] int skip = 0, [FromQuery] int take = 10)
        {
            return _mapper.Map<List<ReadMarcaDto>>(_context.Marcas.Skip(skip).Take(take));
        }
        [HttpGet("{id}")]
        public IActionResult BuscaMarcaPorId(int id)
        {
            var marca = _context.Marcas.FirstOrDefault(marca => marca.MarcaId == id);
            if (marca == null) return NotFound($"O Cliente com id:{id} não existe.");
            var marcaDto = _mapper.Map<ReadMarcaDto>(marca);
            return Ok(marcaDto);
        }
    }
}
