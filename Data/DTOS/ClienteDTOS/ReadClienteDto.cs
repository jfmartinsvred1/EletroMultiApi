using EletroMultiAPI.Models;
using System.ComponentModel.DataAnnotations;

namespace EletroMultiAPI.Data.DTOS.ClienteDTOS
{
    public class ReadClienteDto
    {
        public string Nome { get; set; }
        public string Contato { get; set; }

    }
}
