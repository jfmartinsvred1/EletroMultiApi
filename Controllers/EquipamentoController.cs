﻿using AutoMapper;
using EletroMultiAPI.Data;
using EletroMultiAPI.Data.DTOS.EquipamentoDTO;
using EletroMultiAPI.Data.DTOS.ServicosDTOS;
using EletroMultiAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EletroMultiAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EquipamentoController:ControllerBase
    {
        private EletroMultiContext _context;
        private IMapper _mapper;

        public EquipamentoController(EletroMultiContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult AdicionarEquipamento([FromBody] CreateEquipamentoDto equipamentoDto)
        {
            Equipamento equipamento = _mapper.Map<Equipamento>(equipamentoDto);
            _context.Equipamentos.Add(equipamento);
            _context.SaveChanges();
            return CreatedAtAction(nameof(BuscaEquipamentoPorId), new { id = equipamento.EquipamentoId }, equipamento);

        }
        [HttpGet]
        public IEnumerable<ReadEquipamentoDto> RecuperarEquipamento([FromQuery] int skip = 0, [FromQuery] int take = 10)
        {
            return _mapper.Map<List<ReadEquipamentoDto>>(_context.Equipamentos.Include(s=>s.Servico).Skip(skip).Take(take));
        }
        [HttpGet("{id}")]
        public IActionResult BuscaEquipamentoPorId(int id)
        {
            var equipamento = _context.Equipamentos.Include(o=>o.Servico).FirstOrDefault(equipamento => equipamento.EquipamentoId == id);
            if (equipamento == null) return NotFound($"O Equipamento com id:{id} não existe.");
            var equipamentoDto = _mapper.Map<ReadEquipamentoDto>(equipamento);
            return Ok(equipamentoDto);
        }
        [HttpGet("/Equipamento/servicos/{id}")]
        public IEnumerable<ReadEquipamentoDto> BuscaEquipamentosPorServicoId(int id)
        {
            return _mapper.Map<List<ReadEquipamentoDto>>(_context.Equipamentos.Where(s=>s.ServicoId==id));
        }
        [HttpPut("{id}")]
        public IActionResult AtualizarEquipamento(int id, [FromBody] UpdateEquipamentoDto equipamentoDto)
        {
            var equipamento = _context.Equipamentos.FirstOrDefault(eqp => eqp.EquipamentoId == id);
            if (equipamento == null) return NotFound($"O Cliente com id:{id} não existe.");
            _mapper.Map(equipamentoDto, equipamento);
            _context.SaveChanges();
            return NoContent();
        }

    }
}
