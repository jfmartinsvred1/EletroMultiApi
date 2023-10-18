using System.ComponentModel.DataAnnotations;

namespace EletroMultiAPI.Data.DTOS.StatusDto
{
    public class CreateStatusDto
    {
        [Required]
        public string StatusTipo { get; set; }

    }
}
