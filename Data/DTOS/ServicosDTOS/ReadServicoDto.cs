using EletroMultiAPI.Data.DTOS.ClienteDTOS;
using EletroMultiAPI.Data.DTOS.EquipamentoDTO;
using EletroMultiAPI.Models;

namespace EletroMultiAPI.Data.DTOS.ServicosDTOS
{
    public class ReadServicoDto
    {
        public virtual ReadClienteDto Cliente { get; set; }
        public int ServicoId { get; set; }
        public ICollection<ReadEquipamentoDto> Equipamentos { get; set; }
        public int StatusId { get; set; }
        public virtual Status Status { get; set; }
        public DateTime DataEntrada { get; set; }
    }
}
