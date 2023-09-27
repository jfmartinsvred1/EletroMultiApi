using EletroMultiAPI.Data.DTOS.ClienteDTOS;
using EletroMultiAPI.Data.DTOS.EquipamentoDTO;
using EletroMultiAPI.Models;
using System.ComponentModel.DataAnnotations;

namespace EletroMultiAPI.Data.DTOS.ServicosDTOS
{
    public class ReadServicoDto
    {
        public virtual ReadClienteDto Cliente { get; set; }
        public int NumeroOs { get; set; }
        public ICollection<ReadEquipamentoDto> Equipamentos { get; set; }
    }
}
