using EletroMultiAPI.Models;
using System.ComponentModel.DataAnnotations;

namespace EletroMultiAPI.Data.DTOS.MarcaDto
{
    public class CreateMarcaDto
    {
        [Required]
        public string Nome { get; set; }
    }
}
