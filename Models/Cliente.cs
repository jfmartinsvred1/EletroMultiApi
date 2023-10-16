using System.ComponentModel.DataAnnotations;

namespace EletroMultiAPI.Models
{
    public class Cliente
    {
        [Key]
        [Required]
        public int ClienteId { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Cpf { get; set; }
        [Required]
        public string Numero { get; set; }
        [Required]
        public string Email { get; set; }
        public ICollection<Servico> Servicos { get; set; }

    }
}
