using EletroMultiAPI.Data.DTOS.ClienteDTOS;
using EletroMultiAPI.Data.DTOS.EquipamentoDTO;
using EletroMultiAPI.Enums;

namespace EletroMultiAPI.Data.DTOS.ServicosDTOS
{
    public class ReadServicoDto
    {
        public virtual ReadClienteDto Cliente { get; set; }
        public int ServicoId { get; set; }
        public ICollection<ReadEquipamentoDto> Equipamentos { get; set; }
        public Status Status { get; set; } 
    }
}
