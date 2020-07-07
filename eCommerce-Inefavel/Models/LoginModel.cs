using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerce_Inefavel.Models
{
    public class LoginModel
    {
        [HiddenInput]
        public int Id { get; set; }

        public string Email { get; set; }

        [DataType(DataType.Password)]
        public string Senha { get; set; }

        public UsuarioModel usuarioModel { get; set; }

    }
}
