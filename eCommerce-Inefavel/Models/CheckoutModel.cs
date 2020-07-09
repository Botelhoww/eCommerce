using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerce_Inefavel.Models
{
    [Table("Checkout")]
    public class CheckoutModel
    {
        [HiddenInput]
        public int Id { get; set; }

        public UsuarioModel UserId { get; set; }
        public string PrimeiroNome { get; set; }
        public string Sobrenome { get; set; }
        public string NumCelular { get; set; }
        public string Email { get; set; }
        public string PrimeiroEndereco { get; set; }
        public int CEP { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }

    }
}
