using estudo_arquitetura.Business.Entities;
using estudo_arquitetura.Infra.Context;
using estudo_arquitetura.Infra.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudo_arquitetura.Infra.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        private DataContext dataContext;
        public async Task<Cliente> CadastrarNovoCliente(Cliente cliente)
        {
            var result = await dataContext.Clientes.FindAsync();
            return result;
        }

        public Task<bool> DeletarCliente(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public Task<Cliente> RecuperarClientePorId(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Cliente> RecuperarClientes()
        {
            throw new NotImplementedException();
        }
    }
}
