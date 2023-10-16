using AutoMapper;
using EletroMultiAPI.Data;
using EletroMultiAPI.Data.DTOS.ClienteDTOS;
using EletroMultiAPI.Data.DTOS.ServicosDTOS;
using EletroMultiAPI.Models;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EletroMultiAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClienteController:ControllerBase
    {
        private EletroMultiContext _context;
        private IMapper _mapper;

        public ClienteController(EletroMultiContext context,IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        [HttpPost]
        public IActionResult AdicionaCliente([FromBody] CreateClienteDto clienteDo)
        {
            Cliente cliente=_mapper.Map<Cliente>(clienteDo);
            _context.Clientes.Add(cliente);
            _context.SaveChanges();
            return CreatedAtAction(nameof(BuscaClientePorId), new { id = cliente.ClienteId }, cliente);
        }
        [HttpGet]
        public IEnumerable<ReadClienteDto> RecuperarClientes()
        {
            return _mapper.Map<List<ReadClienteDto>>(_context.Clientes);
        }
        [HttpGet("{id}")]
        public IActionResult BuscaClientePorId(int id)
        {
            var cliente=_context.Clientes.FirstOrDefault(cliente => cliente.ClienteId==id);
            if (cliente == null) return NotFound($"O Cliente com id:{id} não existe.");
            var clienteDto=_mapper.Map<ReadClienteDto>(cliente);
            return Ok(clienteDto);
        }
        [HttpPut("{id}")]
        public IActionResult AtualizarCliente(int id, [FromBody] UpdateClienteDto clienteDto)
        {
            var cliente=_context.Clientes.FirstOrDefault(cliente=> cliente.ClienteId==id);
            if (cliente == null) return NotFound($"O Cliente com id:{id} não existe.");
            _mapper.Map(clienteDto, cliente);
            _context.SaveChanges();
            return NoContent();
        }
        [HttpPatch("{id}")]
        public IActionResult AtualizarClientePath(int id, JsonPatchDocument<UpdateClienteDto> patch)
        {
            var cliente = _context.Clientes.FirstOrDefault(cliente => cliente.ClienteId == id);
            if (cliente == null) return NotFound($"O Cliente com id:{id} não existe.");
            var clienteAtt = _mapper.Map<UpdateClienteDto>(cliente);
            patch.ApplyTo(clienteAtt, ModelState);
            if (!TryValidateModel(clienteAtt))
            {
                return ValidationProblem(ModelState);
            }

            _mapper.Map(clienteAtt, cliente);
            _context.SaveChanges();
            return NoContent();
        }
        [HttpDelete("{id}")]
        public IActionResult DeletaCliente(int id)
        {
            var cliente = _context.Clientes.FirstOrDefault(cliente => cliente.ClienteId == id);
            if (cliente == null) return NotFound($"O Cliente com id:{id} não existe.");
            _context.Clientes.Remove(cliente);
            _context.SaveChanges();
            return NoContent();
        }
        [HttpGet("/Cliente/servicos/{id}")]
        public IEnumerable<ReadServicoDto> RecuperarServicosPorCliente(int id)
        {        
            return _mapper.Map<List<ReadServicoDto>>(_context.Servicos.Include(p=>p.Cliente).Include(p=>p.Equipamentos).Where(i=>i.ClienteId==id));
        }
    }
}
