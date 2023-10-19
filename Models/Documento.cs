using System.ComponentModel.DataAnnotations;

namespace EletroMultiAPI.Models
{
    public class Documento
    {
        [Key]
        [Required]
        [MaxLength(4)]
        public string DocumentoId{ get; set; }
        public string Nome { get; set; }
    }
}
