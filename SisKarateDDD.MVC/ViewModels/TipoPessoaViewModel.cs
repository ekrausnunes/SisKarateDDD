using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SisKarateDDD.MVC.ViewModels
{
    public class TipoPessoaViewModel
    {
        [Key]
        public int IdTipoPessoa { get; set; }

        [Required(ErrorMessage = "Preencha uma descrição")]
        [MaxLength(200, ErrorMessage = "Máximo de 200 caractéres")]
        [MinLength(2,ErrorMessage = "Mínimo de 2 caractéres")]
        public string Descricao { get; set; }


        public bool PodeAdicionar { get; set; }
        public bool PodeAlterar { get; set; }
        public bool PodeExcluir { get; set; }
        public bool PodeLer { get; set; }
        public bool EhMaster { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }

        public virtual IEnumerable<PessoaViewModel> Pessoas { get; set; }
    }
}