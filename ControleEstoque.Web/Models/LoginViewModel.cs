using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ControleEstoque.Web.Models
{
    public class LoginViewModel
    {
        public String Usuario { get; set; }
        public String Senha { get; set; }
        public bool LembrarMe { get; set; }
    }
}