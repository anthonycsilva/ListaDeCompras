using ListaDeCompras.Business.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeCompras.Infra.Data.Context
{
    public class DataContext: DbContext
    {
        private string connectionString = "Server=localhost;Port=5432;Database=ListaDeCompras;Uid=postgres;Pwd=123";

        public DataContext()
        {

        }
        public DataContext(DbContextOptions options) : base(options) { }

        public DbSet<Compra> Compras { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<UsuarioAccount> UsuarioAccounts { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseNpgsql(connectionString);
        }
    }
}
