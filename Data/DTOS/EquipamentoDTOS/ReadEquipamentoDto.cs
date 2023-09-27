using EletroMultiAPI.Models;
using System.ComponentModel.DataAnnotations;

namespace EletroMultiAPI.Data.DTOS.EquipamentoDTOS
{
    public class ReadEquipamentoDto
    {
        [Required]
        public int ServicoId { get; set; }
        public virtual Servico Servico { get; set; }
        [Required]
        public int MarcaId { get; set; }
        public virtual Marca Marca { get; set; }
        [Required]
        public string Modelo { get; set; }
        public int NumSerie { get; set; }
        public int NumPatrimonio { get; set; }
        public bool Garantia { get; set; }
    }
}
