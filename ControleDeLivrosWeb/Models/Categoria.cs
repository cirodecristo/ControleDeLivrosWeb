using System.ComponentModel.DataAnnotations;

namespace CadastroDeLivrosWeb.Models
{
    public class Categoria
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        public int OrdemMostra { get; set; }
        public DateTime DataHoraCriacao { get; set; } = DateTime.Now;

        public int casa { get; set; }
        
    }
}

