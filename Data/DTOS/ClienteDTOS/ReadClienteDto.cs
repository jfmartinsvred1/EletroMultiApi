using EletroMultiAPI.Models;
using System.ComponentModel.DataAnnotations;

namespace EletroMultiAPI.Data.DTOS.ClienteDTOS
{
    public class ReadClienteDto
    {
        public int ClienteId { get; set; }
        public string Nome { get; set; }

        [Required]
        public string DocumentoId { get; set; }
        public string NumDocumento { get; set; }
        [Required]
        public string Numero { get; set; }
        [Required]
        public string Email { get; set; }

    }
}
