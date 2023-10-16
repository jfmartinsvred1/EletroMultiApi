using EletroMultiAPI.Enums;
using EletroMultiAPI.Models;
using System.ComponentModel.DataAnnotations;

namespace EletroMultiAPI.Data.DTOS.ServicosDTOS
{
    public class CreateServicoDto
    {
        [Required]
        public int ClienteId { get; set; }
    }
}
