using eCommerce_Inefavel.Helpers;
using eCommerce_Inefavel.Models;
using eCommerce_Inefavel.Models.Contexto;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;

namespace eCommerce_Inefavel.Controllers
{
    public class CarrinhoController : Controller
    {
        private readonly Contexto _contexto;

        public CarrinhoController(Contexto contexto)
        {
            _contexto = contexto;
        }
        public IActionResult Index()
        {
            //Pega da sessão 'cart' o item que foi adicioando recentemente
            var cart = HttpContext.Session.GetObjectFromJson<List<CarrinhoModel>>("cart");

            //Passa o Objeto com o produto adicionado ao carrinho para a ViewBag
            ViewBag.cart = cart;

            //Faz a soma de todos os produtos adicionados ao carrinho
            var valorTotal = cart.Sum(item => item.Produto.Valor);
            SessionHelper.SetObjectAsJson(HttpContext.Session, "valorTotal", valorTotal);
            ViewBag.total = valorTotal;

            //Seta na sessão 'qtdItens' quantos itens estão dentro do carrinho
            var contaItens = cart.Count();
            SessionHelper.SetObjectAsJson(HttpContext.Session, "qtdItens", contaItens);

            return View();
        }

        public IActionResult addCarrinho(int Id)
        {
            if (SessionHelper.GetObjectFromJson<List<CarrinhoModel>>(HttpContext.Session, "cart") == null)
            {
                List<CarrinhoModel> cart = new List<CarrinhoModel>();
                cart.Add(new CarrinhoModel { Produto = _contexto.Produtos.Find(Id) });
                //Passa para a sessão 'cart' o item adicionado
                HttpContext.Session.SetObjectAsJson("cart", cart);
            }
            else
            {
                List<CarrinhoModel> cart = SessionHelper.GetObjectFromJson<List<CarrinhoModel>>(HttpContext.Session, "cart");
                cart.Add(new CarrinhoModel { Produto = _contexto.Produtos.Find(Id) });
                SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            }
            return RedirectToAction("Index");
        }

        //Remove item do carrinho
        public IActionResult Remove(int Id)
        {
            List<CarrinhoModel> cart = SessionHelper.GetObjectFromJson<List<CarrinhoModel>>(HttpContext.Session, "cart");
            cart.RemoveAt(Id);
            SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            return RedirectToAction("Index");
        }
    }
}