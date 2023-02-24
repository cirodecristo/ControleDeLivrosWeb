using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

namespace CadastroDeLivrosWeb.Models
{
    public class Categoria
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        [DisplayName("Ordem de Exibição")]
        [Range(1,100,ErrorMessage ="O número de exibição deve ser de 1 à 100")]
        public int OrdemMostra { get; set; }
        public DateTime DataHoraCriacao { get; set; } = DateTime.Now;
        
    }
}

