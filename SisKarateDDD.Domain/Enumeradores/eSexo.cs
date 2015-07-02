using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisKarateDDD.Domain.Enumeradores
{
    public enum eSexo
    {
        [Display(Name = "Masculino")] 
        [Description("Masculino")] Masculino = 1,

        [Display(Name = "Feminino")] 
        [Description("Feminino")] Feminino = 2
    }
}
