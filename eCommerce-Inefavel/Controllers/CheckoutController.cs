using eCommerce_Inefavel.Helpers;
using eCommerce_Inefavel.Models;
using eCommerce_Inefavel.Models.Contexto;
using eCommerce_Inefavel.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace eCommerce_Inefavel.Controllers
{
    public class CheckoutController : Controller
    {
        private readonly Contexto _contexto;
        private readonly IWebHostEnvironment webHostEnvironment;
        public CheckoutController(Contexto contexto, IWebHostEnvironment hostEnvironment)
        {
            _contexto = contexto;
            webHostEnvironment = hostEnvironment;
        }
        //Vai trazer todos os produtos do carrinho pro checkout
        public IActionResult Index(ProdutoViewModel model)
        {
            //Pega da sessão 'cart' os itens do carrinho
            var cart = HttpContext.Session.GetObjectFromJson<List<CarrinhoModel>>("cart");

            ViewBag.ProdutosCheckout = cart;

            return View();
        }

        [NoDirectAccess]
        [HttpGet]
        public IActionResult Checkout()
        {
            if (ModelState.IsValid)
            {
                CheckoutModel checkout = new CheckoutModel
                {
                    
                };
            }

            return View();
        }
    }
}