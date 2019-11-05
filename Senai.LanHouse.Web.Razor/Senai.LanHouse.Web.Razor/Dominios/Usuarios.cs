using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Senai.LanHouse.Web.Razor.Dominios
{
    public partial class Usuarios
    {
        public int Id { get; set; }
        [EmailAddress(ErrorMessage ="Informe um e-mail válido")]
        [Required(ErrorMessage = "Informe o e-mail")]
        [DataType(DataType.EmailAddress)]
        //RegularExpressionAttribute tbm funciona....
        public string Email { get; set; }

        
        [Required(ErrorMessage = "Informe a senha")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }
    }
}
