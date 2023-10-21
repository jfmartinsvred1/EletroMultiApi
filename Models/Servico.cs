using System.ComponentModel.DataAnnotations;

namespace EletroMultiAPI.Models
{
    public class Servico
    {
        [Key]
        [Required]
        public int ServicoId { get; set; }
        [Required]
        public int ClienteId { get; set; }
        [Required]
        public int StatusId { get; set; }

        [Required]
        public virtual Status Status { get; set; }
        [Required]
        public virtual Cliente Cliente { get; set; }
        public ICollection<Equipamento> Equipamentos { get; set; }
        public DateTime DataEntrada { get; set; }
    }
}
