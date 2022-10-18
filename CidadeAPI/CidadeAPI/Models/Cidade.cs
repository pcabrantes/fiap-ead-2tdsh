using System.ComponentModel.DataAnnotations;

namespace CidadeAPI.Models
{
    public class Cidade
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome da cidade é obrigatório")]
        [MaxLength(30)]
        public string Nome { get; set; }
        
        [Required(ErrorMessage = "UF obrigatório")]
        [MaxLength(2, ErrorMessage = "A UF precisa ter 2 caracteres")]
        [MinLength(2, ErrorMessage = "A UF precisa ter 2 caracteres")]
        public string Uf { get; set; }
    }
}
