using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Admin.Models
{
    public class Cliente
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [StringLength(30)]
        [Required(ErrorMessage = "O nome do cliente é obrigatório")]
        public String Nome { get; set; }

        [StringLength(12)]
        [Required(ErrorMessage = "O cpf do cliente é obrigatório")]
        public String Cpf { get; set; }
        
        [StringLength(30)]
        public String Email { get; set; }

        [StringLength(12)]
        [Required(ErrorMessage = "O Telefone do aluno é obrigatório")]
        public String Telefone { get; set; }
    }
}