﻿using System.ComponentModel.DataAnnotations;

namespace EletroMultiAPI.Data.DTOS.EquipamentoDTO
{
    public class UpdateEquipamentoDto
    {

        [Required]
        public int ServicoId { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Modelo { get; set; }
        [Required]
        public string Marca { get; set; }
        [Required]
        public string NumSerie { get; set; }
        [Required]
        public bool Garantia { get; set; }
    }
}
