using eCommerce_Inefavel.Helpers;
using eCommerce_Inefavel.Models;
using eCommerce_Inefavel.Models.Contexto;
using eCommerce_Inefavel.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Linq;

namespace eCommerce_Inefavel.Controllers
{
    public class AdminController : Controller
    {
        private readonly Contexto _contexto;
        private readonly IWebHostEnvironment webHostEnvironment;

        public AdminController(Contexto contexto, IWebHostEnvironment hostEnvironment)
        {
            _contexto = contexto;
            webHostEnvironment = hostEnvironment;
        }

        [NoDirectAccess]
        [Route("/Admin")]
        //página principal do Admin
        [HttpGet]
        public IActionResult Admin()
        {
            return View();
        }

        //Tudo De PRODUTO Que O Admin Pode Fazer

        //Página de Lista dos Produtos
        //- FUNCIONANDO -
        [NoDirectAccess]
        [Route("/Lista-Produtos")]
        public IActionResult ListaDeProdutos()
        {
            var listaProdutos = _contexto.Produtos.ToList();

            return View(listaProdutos);
        }

        //Página de Cadastro de Produtos
        //- FUNCIONANDO -
        [NoDirectAccess]
        [HttpGet]
        public IActionResult CadastrarProduto()
        {
            return View();
        }

        [NoDirectAccess]
        [HttpPost]
        public IActionResult CadastrarProduto(ProdutoViewModel model)
        {
            if (ModelState.IsValid)
            {
                string uniqueFileName = UploadedFile(model);

                ProdutosModel Produtos = new ProdutosModel
                {
                    ImagePath = uniqueFileName,
                    Titulo = model.Titulo,
                    Valor = model.Valor,
                    Ativo = true,
                };
                _contexto.Add(Produtos);
                _contexto.SaveChanges();

                return View();
            }
            return RedirectToAction("Admin");
        }

        private string UploadedFile(ProdutoViewModel model)
        {
            string uniqueFileName = null;

            if (model.ImagePath != null)
            {
                string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "produtos_img");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + model.ImagePath.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    model.ImagePath.CopyTo(fileStream);
                }
            }
            return uniqueFileName;
        }

        //Página de Remoção de Produtos
        //- FUNCIONANDO -
        [NoDirectAccess]
        [HttpGet]
        public IActionResult RemoverProduto(int Id)
        {
            var removerProduto = _contexto.Produtos.Find(Id);
            return View(removerProduto);
        }

        [NoDirectAccess]
        [HttpPost]
        public IActionResult RemoverProduto(ProdutosModel produtos)
        {
            var removerProduto = _contexto.Produtos.Find(produtos.Id);
            if (removerProduto != null)
            {
                _contexto.Remove(removerProduto);
                _contexto.SaveChanges();

                return RedirectToAction("ListaDeProdutos");
            }
            return View(removerProduto);

        }

        //Página de Edição do Produto em questão
        //- FUNCIONANDO -
        [NoDirectAccess]
        [HttpGet]
        public IActionResult EditarProduto(int Id)
        {
            var produto = _contexto.Produtos.Find(Id);
            return View(produto);
        }

        [NoDirectAccess]
        [HttpPost]
        public IActionResult EditarProduto(ProdutosModel produto)
        {
            if (ModelState.IsValid)
            {
                _contexto.Produtos.Update(produto);
                _contexto.SaveChanges();

                return RedirectToAction("Index");
            }
            else
            {
                return View(produto);
            }
        }

        //Tudo De USUÁRIO Que O Admin Pode Fazer

        //Página de Lista dos Usuários
        //- FUNCIONANDO -
        [NoDirectAccess]
        [Route("/Lista-Usuarios")]
        public IActionResult ListaDeUsuarios()
        {
            var listaUsuario = _contexto.Usuarios.ToList();

            return View(listaUsuario);
        }

        //Página de Remoção de Usuários
        //- FUNCIONANDO -
        [NoDirectAccess]
        [HttpGet]
        public IActionResult RemoverUsuario(int Id)
        {
            var usuario = _contexto.Usuarios.Find(Id);
            return View(usuario);
        }

        [NoDirectAccess]
        [HttpPost]
        public IActionResult RemoverUsuario(UsuarioModel usuarios)
        {
            var usuario = _contexto.Usuarios.Find(usuarios.Id);
            if (usuario != null)
            {
                _contexto.Remove(usuario);
                _contexto.SaveChanges();

                return RedirectToAction("ListaDeUsuarios");
            }
            return View(usuario);

        }

        //Página de Edição do Usuário em questão
        //- FUNCIONANDO -
        [NoDirectAccess]
        [HttpGet]
        public IActionResult EditarUsuario(int Id)
        {
            var usuario = _contexto.Usuarios.Find(Id);
            return View(usuario);
        }

        [NoDirectAccess]
        [HttpPost]
        public IActionResult EditarUsuario(UsuarioModel usuario)
        {

            if (ModelState.IsValid)
            {
                _contexto.Update(usuario);
                _contexto.SaveChanges();

                return RedirectToAction("ListaDeUsuarios");
            }
            else
            {
                return View(usuario);
            }
        }
    }
}