using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace senai.darede.WebAPI.ViewModel
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Esse campo é obrigatório.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Esse campo é obrigatório.")]
        public string Senha { get; set; }
    }
}
