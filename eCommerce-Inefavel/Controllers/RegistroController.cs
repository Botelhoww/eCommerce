using eCommerce_Inefavel.Models;
using eCommerce_Inefavel.Models.Contexto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eCommerce_Inefavel.Controllers
{
    public class RegistroController : Controller
    {

        private readonly Contexto _contexto;
        private readonly ISession session;

        public RegistroController(Contexto contexto, IHttpContextAccessor httpContextAccessor)
        {
            _contexto = contexto;
            this.session = httpContextAccessor.HttpContext.Session;
        }
        
        public IActionResult Index()
        {
            return View();
        }

        //METODO PARA CRIAR CONTA
        [Route("/Registro")]
        [HttpGet]
        public IActionResult Registrar()
        {
            var Usuario = new UsuarioModel();

            return View(Usuario);
        }

        [HttpPost]
        public IActionResult Registrar(UsuarioModel Usuarios)
        {
            var Usuario = new UsuarioModel();

            Usuario.Role = "Usuário";

            _contexto.Add(Usuarios);
            _contexto.SaveChanges();

            return RedirectToAction("Index", "Produtos");

        }
        //FIM DO METODO PARA CRIAR CONTA

    }
}