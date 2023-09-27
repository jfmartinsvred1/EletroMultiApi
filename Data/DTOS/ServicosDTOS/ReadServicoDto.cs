using EletroMultiAPI.Models;
using System.ComponentModel.DataAnnotations;

namespace EletroMultiAPI.Data.DTOS.ServicosDTOS
{
    public class ReadServicoDto
    {
        [Required]
        public int ClienteId { get; set; }
        public virtual Cliente Cliente { get; set; }
        [Required]
        public int NumeroOs { get; set; }
        public ICollection<Equipamento> Equipamentos { get; set; }
    }
}
