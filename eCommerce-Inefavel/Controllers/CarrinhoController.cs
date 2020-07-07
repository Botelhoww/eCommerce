using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eCommerce_Inefavel.Helpers;
using eCommerce_Inefavel.Models;
using eCommerce_Inefavel.Models.Contexto;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using Newtonsoft.Json;

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
            var cart = HttpContext.Session.GetObjectFromJson<List<CarrinhoModel>>("cart");

            ViewBag.cart = cart;
            ViewBag.total = cart.Sum(item => item.Produto.Valor);

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

        //n ta funcionando
        public IActionResult Remove(int Id)
        {
            List<CarrinhoModel> cart = SessionHelper.GetObjectFromJson<List<CarrinhoModel>>(HttpContext.Session, "cart");
            cart.RemoveAt(Id);
            SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            return RedirectToAction("Index");
        }
    }
}