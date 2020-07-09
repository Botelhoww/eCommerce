using eCommerce_Inefavel.Models.Contexto;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace eCommerce_Inefavel.Controllers
{
    public class ProdutosController : Controller
    {
        private readonly Contexto _contexto;

        public ProdutosController(Contexto contexto)
        {
            _contexto = contexto;
        }

        public IActionResult Index()
        {
            //lista com os 6 últimos produtos adicionados
            var lista = _contexto.Produtos.ToList()
                .Where(x => x.Ativo == true).OrderByDescending(x => x.Id).Take(6);

            //lista de produtos adicionados do mais antigo ao mais novo
            var lista2 = _contexto.Produtos.ToList()
                .Where(x => x.Ativo == true).OrderBy(x => x.Id).Distinct();

            ViewBag.produtos = lista;
            ViewBag.produtos2 = lista2;

            return View(lista);
        }

        [Route("/Produto/{id}")]
        [HttpGet]
        public IActionResult Detalhe(int Id, string Titulo)
        {
            var produto = _contexto.Produtos.Find(Id);

            var precoParcelado = produto.Valor / 12;
            var precoDesconto = produto.Valor * 5 / 100;

            var precoAvista = produto.Valor - precoDesconto;

            ViewBag.precoP = precoParcelado.ToString("N2");
            ViewBag.precoD = precoDesconto.ToString("N2");
            ViewBag.precoA = precoAvista.ToString("N2");

            return View(produto);
        }
    }
}