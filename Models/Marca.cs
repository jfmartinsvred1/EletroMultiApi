using System.ComponentModel.DataAnnotations;

namespace EletroMultiAPI.Models
{
    public class Marca
    {
        [Key]
        [Required]
        public int MarcaId { get; set; }
        [Required]
        public string Nome { get; set; }
        public ICollection<Equipamento> Equipamentos { get; set; }
    }
}
