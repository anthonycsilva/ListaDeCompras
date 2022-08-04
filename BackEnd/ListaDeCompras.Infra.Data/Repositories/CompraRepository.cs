using ListaDeCompras.Business.Entities;
using ListaDeCompras.Business.Interfaces.RepositoriesInterfaces;
using ListaDeCompras.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeCompras.Infra.Data.Repositories
{
    public class CompraRepository : ICompraRepository
    {
        private DataContext _dataContext;

        public CompraRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<Compra> BuscarCompraPorId(int idCompra)
        {
            var result = await _dataContext.Compras.FindAsync(idCompra);
            return result;
        }

        public async Task<List<Compra>> BuscarTodasAsCompras()
        {
            var result = await _dataContext.Compras.ToListAsync();
            return result;
        }

        public async Task<Compra> CadastrarCompra(Compra compra)
        {
            var result = await _dataContext.Compras.AddAsync(compra);
            await _dataContext.SaveChangesAsync();
            return compra;
        }

        public Task<bool> ExcluirCompra(Compra compra)
        {
            throw new NotImplementedException();
        }
    }
}
