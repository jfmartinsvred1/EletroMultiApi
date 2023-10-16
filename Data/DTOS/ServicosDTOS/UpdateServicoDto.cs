using System.ComponentModel.DataAnnotations;

namespace EletroMultiAPI.Data.DTOS.ServicosDTOS
{
    public class UpdateServicoDto
    {
        [Required]
        public int ClienteId { get; set; }
    }
}
