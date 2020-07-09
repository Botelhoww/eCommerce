using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerce_Inefavel.Models.Contexto
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<UsuarioModel> Usuarios { get; set; }
        public DbSet<ProdutosModel> Produtos { get; set; }
        public DbSet<LoginModel> Login { get; set; }
        public DbSet<CheckoutModel> Checkout { get; set; }
    }
}
