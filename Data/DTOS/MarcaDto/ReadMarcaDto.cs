using EletroMultiAPI.Models;
using System.ComponentModel.DataAnnotations;

namespace EletroMultiAPI.Data.DTOS.MarcaDto
{
    public class ReadMarcaDto
    {
        public int MarcaId { get; set; }
        [Required]
        public string Nome { get; set; }
    }
}
