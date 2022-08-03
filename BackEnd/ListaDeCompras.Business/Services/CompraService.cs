using ListaDeCompras.Business.Entities;
using ListaDeCompras.Business.Interfaces.RepositoriesInterfaces;
using ListaDeCompras.Business.Interfaces.ServicesInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeCompras.Business.Services
{
    public class CompraService : ICompraService
    {
        private ICompraRepository _compraRepository;

        public CompraService(ICompraRepository compraRepository)
        {
            _compraRepository = compraRepository;
        }

        public async Task<Compra> BuscarCompraPorId(int idCompra)
        {
            var result = await _compraRepository.BuscarCompraPorId(idCompra);
            return result;
        }

        public Task<List<Compra>> BuscarTodasAsCompras()
        {
            throw new NotImplementedException();
        }

        public async Task<Compra> CadastrarCompra(Compra compra)
        {
            var result = await _compraRepository.CadastrarCompra(compra);
            return result;
        }

        public Task<bool> ExcluirCompra(Compra compra)
        {
            throw new NotImplementedException();
        }
    }
}
