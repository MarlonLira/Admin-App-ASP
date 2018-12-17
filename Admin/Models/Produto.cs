using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Admin.Models
{
    public class Produto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [StringLength(30)]
        [Required(ErrorMessage = "O nome do produto é obrigatório")]
        public String Nome { get; set; }

        [Required(ErrorMessage ="A quantidade do produto é obrigatório")]
        public int Quantidade { get; set; }

        [Required(ErrorMessage ="O valor do produto é obrigatório")]
        public decimal Valor { get; set; }
    }
}