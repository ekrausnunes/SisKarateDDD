using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisKarateDDD.Domain.Enumeradores
{
    public enum eTipoPessoa
    {
        [Display(Name = "Professor")]
        [Description("Professor")]
        Professor = 1,

        [Display(Name = "Professor e aluno")]
        [Description("Professor e aluno")]
        ProfessorEaluno = 2,

        [Display(Name = "Aluno")]
        [Description("Aluno")]
        Aluno = 3
    }
}
