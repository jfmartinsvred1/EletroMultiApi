
using EletroMultiAPI.Models;
using System.ComponentModel.DataAnnotations;

namespace EletroMultiAPI.Data.DTOS.ServicosDTOS
{
    public class CreateServicoDto
    {
        [Required]
        public int ClienteId { get; set; }
        public int StatusId { get; set; }
    }
}
