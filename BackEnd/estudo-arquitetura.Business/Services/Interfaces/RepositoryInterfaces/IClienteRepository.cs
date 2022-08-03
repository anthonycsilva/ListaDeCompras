using estudo_arquitetura.Business.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudo_arquitetura.Infra.Repositories.Interfaces
{
    public interface IClienteRepository
    {
        Task<Cliente> CadastrarNovoCliente(Cliente cliente);
        Task<Cliente> RecuperarClientePorId(int id);
        Task<Cliente> RecuperarClientes();
        Task<bool> DeletarCliente(Cliente cliente);
    }
}
