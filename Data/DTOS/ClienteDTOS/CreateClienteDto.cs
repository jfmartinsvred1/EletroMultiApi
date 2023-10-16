using System.ComponentModel.DataAnnotations;

namespace EletroMultiAPI.Data.DTOS.ClienteDTOS
{
    public class CreateClienteDto
    {

        [Required]
        public string Nome { get; set; }

        [Required]
        public string Cpf { get; set; }
        [Required]
        public string Numero { get; set; }
        [Required]
        public string Email { get; set; }
    }
}
