using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eCommerce_Inefavel.Helpers;
using eCommerce_Inefavel.Models;
using eCommerce_Inefavel.Models.Contexto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Session;
using Newtonsoft.Json;

namespace eCommerce_Inefavel.Controllers
{
    public class LoginController : Controller
    {
        private readonly Contexto _contexto;
        private readonly ISession session;

        public LoginController(Contexto contexto, IHttpContextAccessor httpContextAccessor)
        {
            _contexto = contexto;
            this.session = httpContextAccessor.HttpContext.Session;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Authorize(UsuarioModel userModel)
        {
            var userDetails = _contexto.Usuarios.Where(x => x.Email == userModel.Email
            && x.Senha == userModel.Senha).FirstOrDefault();

            //se o usuario que entrar for admin ele irá direto para página de admin
            if (userDetails.Role == "Admin")
            {
                //Seta o Id do usuario como sessão
                this.session.SetString("isAdmin", JsonConvert.SerializeObject(userDetails.Role));
                //Seta o Nome do usuario na sessão
                this.session.SetString("NomeUsuario", JsonConvert.SerializeObject(userDetails.Nome));

                return RedirectToAction("Admin", "Admin");
            }

            if (userDetails == null)
            {
                return RedirectToAction("Index", userModel);
            }
            else
            {
                //Seta o Id do usuario como sessão
                this.session.SetString("isFiltered", JsonConvert.SerializeObject(userDetails.Id));
                //Seta o Nome do usuario na sessão
                this.session.SetString("NomeUsuario", JsonConvert.SerializeObject(userDetails.Nome));

                return RedirectToAction("Index", "Produtos");
            }
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();

            return RedirectToAction("Index", "Login");
        }
    }
}
