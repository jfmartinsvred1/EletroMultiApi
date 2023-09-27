using EletroMultiAPI.Models;
using System.ComponentModel.DataAnnotations;

namespace EletroMultiAPI.Data.DTOS.ServicosDTOS
{
    public class ReadServicoDto
    {
        public virtual Cliente Cliente { get; set; }
        public int NumeroOs { get; set; }
        public ICollection<Equipamento> Equipamentos { get; set; }
    }
}
