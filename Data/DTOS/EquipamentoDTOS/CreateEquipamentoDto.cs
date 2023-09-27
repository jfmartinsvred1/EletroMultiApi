using EletroMultiAPI.Models;
using System.ComponentModel.DataAnnotations;

namespace EletroMultiAPI.Data.DTOS.EquipamentoDTOS
{
    public class CreateEquipamentoDto
    {
        [Required]
        public int ServicoId { get; set; }
        [Required]
        public int MarcaId { get; set; }
        [Required]
        public string Modelo { get; set; }
        public int NumSerie { get; set; }
        public int NumPatrimonio { get; set; }
        public bool Garantia { get; set; }
    }
}
