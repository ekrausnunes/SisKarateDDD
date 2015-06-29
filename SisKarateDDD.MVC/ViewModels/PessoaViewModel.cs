using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SisKarateDDD.MVC.ViewModels
{
    public class PessoaViewModel
    {
        [Key]
        public int IdPessoa { get; set; }

        [Required(ErrorMessage = "Preencha um nome")]
        [MaxLength(150, ErrorMessage = "Máximo de 150 caractéres")]
        [MinLength(2, ErrorMessage = "Mínimo de 2 caractéres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Preencha um sobrenome")]
        [MaxLength(150, ErrorMessage = "Máximo de 150 caractéres")]
        [MinLength(2, ErrorMessage = "Mínimo de 2 caractéres")]
        public string Sobrenome { get; set; }

        [Required(ErrorMessage = "Preencha um e-mail")]
        [MaxLength(150, ErrorMessage = "Máximo de 150 caractéres")]
        [MinLength(2, ErrorMessage = "Mínimo de 2 caractéres")]
        [EmailAddress(ErrorMessage = "Preencha uma e-mail válido")]
        [DisplayName("E-mail")]
        public string Email { get; set; }


        public bool Ativo { get; set; }


        public int TipoPessoaId { get; set; }

        [Required]
        public virtual TipoPessoaViewModel TipoPessoa { get; set; }
    }
}