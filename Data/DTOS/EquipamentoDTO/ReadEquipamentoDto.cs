using EletroMultiAPI.Data.DTOS.ServicosDTOS;
using EletroMultiAPI.Models;
using System.ComponentModel.DataAnnotations;

namespace EletroMultiAPI.Data.DTOS.EquipamentoDTO
{
    public class ReadEquipamentoDto
    {
        public int EquipamentoId { get; set; }
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
