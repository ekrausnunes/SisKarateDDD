using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisKarateDDD.Domain.Enumeradores
{
    public enum eFaixa
    {
        [Description("Branca")]
        [Display(Name = "Branca")]
        Branca = 1,

        [Description("Azul")]
        [Display(Name = "Azul")]
        Azul = 2,

        [Description("Amarela")]
        [Display(Name = "Amarela")]
        Amarela = 3,

        [Description("Vermelha")]
        [Display(Name = "Vermelha")]
        Vermelha = 4,

        [Description("Laranja")]
        [Display(Name = "Laranja")]
        Laranja = 5,

        [Description("Verde")]
        [Display(Name = "Verde")]
        Verde = 6,

        [Description("Roxa")]
        [Display(Name = "Roxa")]
        Roxa = 7,

        [Description("Marrom")]
        [Display(Name = "Marrom")]
        Marrom = 8,

        [Description("Preta 1º Dan")]
        [Display(Name = "Preta 1º Dan")]
        Preta1Dan = 9,

        [Description("Preta 2º Dan")]
        [Display(Name = "Preta 2º Dan")]
        Preta2Dan = 10,

        [Description("Preta 3º Dan")]
        [Display(Name = "Preta 3º Dan")]
        Preta3Dan = 11,

        [Description("Preta 4º Dan")]
        [Display(Name = "Preta 4º Dan")]
        Preta4Dan = 12,

        [Description("Preta 5º Dan")]
        [Display(Name = "Preta 5º Dan")]
        Preta5Dan = 13,

        [Description("Preta 6º Dan")]
        [Display(Name = "Preta 6º Dan")]
        Preta6Dan = 14,

        [Description("Preta 7º Dan")]
        [Display(Name = "Preta 7º Dan")]
        Preta7Dan = 15,

        [Description("Preta 8º Dan")]
        [Display(Name = "Preta 8º Dan")]
        Preta8Dan = 16,

        [Description("Preta 9º Dan")]
        [Display(Name = "Preta 9º Dan")]
        Preta9Dan = 17,

        [Description("Preta 10º Dan")]
        [Display(Name = "Preta 10º Dan")]
        Preta10Dan = 18
    }
}
