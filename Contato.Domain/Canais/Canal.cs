using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Contato.Domain.Canais
{
    public enum Canal
    {
        [Display(Name = "Celular", Description = "Celular")]
        celular = 1,

        [Display(Name = "E-mail", Description = "E-mail")]
        email = 2,

        [Display(Name = "Fixo", Description = "Fixo")]
        fixo = 3
    }
}
