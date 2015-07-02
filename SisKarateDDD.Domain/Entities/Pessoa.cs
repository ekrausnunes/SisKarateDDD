
using System;
using System.Collections;
using System.ComponentModel.DataAnnotations;
using SisKarateDDD.Domain.Enumeradores;
using System.Collections.Generic;

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

        public string Celular { get; set; }

        public string Telefone { get; set; }

        [Required]
        public DateTime DataNascimento { get; set; }

        [Required]
        public DateTime DataInicio { get; set; }

        public bool Ativo { get; set; }

        public string Cidade { get; set; }

        public string Bairro { get; set; }

        public string Rua { get; set; }

        public eSexo Sexo { get; set; }

        public eTipoPessoa TipoPessoa { get; set; }

        public virtual IEnumerable<HistoricoFaixa> HistoricoFaixa { get; set; }

    }
}
