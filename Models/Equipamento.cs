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
        public string Nome { get; set; }
        [Required]
        public string Modelo { get; set; }
        [Required]
        public string Marca { get; set; }
        [Required]
        public string NumSerie { get; set; }
        [Required]
        public bool Garantia { get; set; }
    }
}
