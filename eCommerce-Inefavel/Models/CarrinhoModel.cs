using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerce_Inefavel.Models
{
    public class CarrinhoModel
    {
        [HiddenInput]
        public int Id { get; set; }

        public string ImagePath { get; set; }

        public string Titulo { get; set; }

        public decimal Valor { get; set; }

        public bool Ativo { get; set; }
        public ProdutosModel Produto { get; set; }

        public int Quantidade { get; set; }
    }
}
