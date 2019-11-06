using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace JeffThings.Domains
{
    public partial class Usuarios
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Informe o email")]
        //[DataType(DataType.EmailAddress, ErrorMessage = "Informe um e-mail válido")]
        [EmailAddress(ErrorMessage = "Informe um e-mail válido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Informe a senha")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }
        public string Nome { get; set; }
    }
}
