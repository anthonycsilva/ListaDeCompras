using estudo_arquitetura.Business.Entities;
using estudo_arquitetura.Business.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace estudo_arquitetura.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClienteController : ControllerBase
    {
        private readonly ILogger<ClienteController> _logger;
        private IClienteService _clienteService;

        public ClienteController(ILogger<ClienteController> logger, IClienteService clienteService)
        {
            _logger = logger;   
            _clienteService = clienteService;
        }

        [HttpGet("clientes")]
        public async Task<Cliente> GetCliente()
        {
            var result = await _clienteService.RecuperarClientes();
            return result;
        } 
    }
}
