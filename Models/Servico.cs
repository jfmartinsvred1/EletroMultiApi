using System.ComponentModel.DataAnnotations;
using EletroMultiAPI.Enums;

namespace EletroMultiAPI.Models
{
    public class Servico
    {
        [Key]
        [Required]
        public int ServicoId { get; set; }
        [Required]
        public int ClienteId { get; set; }
        public Status Status { get; set; } = (Status)1;
        [Required]
        public virtual Cliente Cliente { get; set; }
        public ICollection<Equipamento> Equipamentos { get; set; }
    }
}
