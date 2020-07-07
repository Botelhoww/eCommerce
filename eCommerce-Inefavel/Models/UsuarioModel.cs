﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerce_Inefavel.Models
{
    [Table("Usuarios")]
    public class UsuarioModel
    {
        [HiddenInput]
        public int Id{ get; set; }

        public string Nome{ get; set; }

        public string Email{ get; set; }

        public string Senha{ get; set; }

        public string Role { get; set; }

    }
}
