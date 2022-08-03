using estudo_arquitetura.Business.Entities;
using estudo_arquitetura.Business.Services.Interfaces;
using estudo_arquitetura.Infra.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudo_arquitetura.Business.Services
{
    public class ClienteService : IClienteService
    {
        private IClienteRepository _clienteRepository;
        public ClienteService(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }
        public async Task<Cliente> CadastrarNovoCliente(Cliente cliente)
        {
            var result = await _clienteRepository.CadastrarNovoCliente(cliente);
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
