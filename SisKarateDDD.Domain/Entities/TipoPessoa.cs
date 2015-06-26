using System;
using System.ComponentModel.DataAnnotations;

namespace SisKarateDDD.Domain.Entities
{
    public class TipoPessoa
    {
        [Key]
        public int IdTipoPessoa { get; set; }
        public string Descricao { get; set; }
        public bool PodeAdicionar { get; set; }
        public bool PodeAlterar { get; set; }
        public bool PodeExcluir { get; set; }
        public bool PodeLer { get; set; }
        public bool EhMaster { get; set; }
        public DateTime DataCadastro { get; set; }


    }
}
