using System.ComponentModel.DataAnnotations;

namespace EletroMultiAPI.Models
{
    public class Status
    {
        [Key]
        [Required]
        public int StatusId { get; set; }
        [Required]
        public string StatusTipo { get; set; }
        public ICollection<Servico> Servicos { get; set; }
    }
}
