using estudo_arquitetura.Business.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudo_arquitetura.Infra.Context
{
    public class DataContext : DbContext 
    {
        private IConfiguration Configuration { get; }
        private string _connectionString = "Server=localhost;Port=5432;Database=estudo-arquitetura;Uid=postgres;Pwd=123";

        protected override void OnConfiguring(DbContextOptionsBuilder opt)
        {
            opt.UseNpgsql(_connectionString);
        }

        public DbSet<Cliente> Clientes { get; set; }
    }
}
