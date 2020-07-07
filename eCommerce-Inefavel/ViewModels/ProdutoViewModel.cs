using eCommerce_Inefavel.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerce_Inefavel.ViewModels
{
    public class ProdutoViewModel
    {
        [HiddenInput]
        public int Id { get; set; }
        [Display(Name = "Foto do Produto")]
        public IFormFile ImagePath { get; set; }

        public string Titulo { get; set; }

        public decimal Valor { get; set; }

        public bool Ativo { get; set; }
    }
}
