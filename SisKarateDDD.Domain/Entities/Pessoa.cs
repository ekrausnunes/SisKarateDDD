
using System.ComponentModel.DataAnnotations;
namespace SisKarateDDD.Domain.Entities
{
    public class Pessoa
    {
        [Key]
        public int IdPessoa { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public string Sobrenome { get; set; }

        [Required]
        public string Email { get; set; }


        public bool Ativo { get; set; }

        
        public int TipoPessoaId { get; set; }

        [Required]
        public virtual TipoPessoa TipoPessoa { get; set; }

    }
}
