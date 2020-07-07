using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerce_Inefavel.Models
{
    public class TamanhoDisponivel
    {
        [HiddenInput]
        public int Id { get; set; }
        public string Tamanhos { get; set; }
    }
}
