using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ControleEstoque.Web.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Informe o Usuário")]
        [Display(Name="Usuário:")]
        public String Usuario { get; set; }

        [Required(ErrorMessage = "Informe a senha")]
        [DataType(DataType.Password)]
        [Display(Name = "Senha:")]

        public String Senha { get; set; }
        [Display(Name = "Lembrar Me:")]
        public bool LembrarMe { get; set; }
    }
}