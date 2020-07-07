using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerce_Inefavel.Models
{
    [Table("Produtos")]
    public class ProdutosModel
    {
        [HiddenInput]
        public int Id { get; set; }

        public string ImagePath { get; set; }

        public string Titulo { get; set; }

        public decimal Valor { get; set; }

        public bool Ativo { get; set; }
    }
}
