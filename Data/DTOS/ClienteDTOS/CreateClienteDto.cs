using System.ComponentModel.DataAnnotations;

namespace EletroMultiAPI.Data.DTOS.ClienteDTOS
{
    public class CreateClienteDto
    {

        [Required]
        public string Nome { get; set; }

        [Required]
        public string DocumentoId { get; set; }
        [Required]
        [MaxLength(18)]
        public string NumDocumento { get; set; }
        [Required]
        public string Numero { get; set; }
        [Required]
        public string Email { get; set; }
    }
}
