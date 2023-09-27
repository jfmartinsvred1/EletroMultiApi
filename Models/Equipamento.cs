using System.ComponentModel.DataAnnotations;

namespace EletroMultiAPI.Models
{
    public class Equipamento
    {
        [Key]
        [Required]
        public int EquipamentoId { get; set; }
        [Required]
        public int ServicoId { get; set; }
        public virtual Servico Servico { get; set; }
        [Required]
        public int MarcaId { get; set; }
        public virtual Marca Marca { get; set; }
        [Required]
        public string Modelo { get; set; }
        public int NumSerie { get; set; }
        public int NumPatrimonio { get; set; }
        public bool Garantia { get; set; }
    }
}
