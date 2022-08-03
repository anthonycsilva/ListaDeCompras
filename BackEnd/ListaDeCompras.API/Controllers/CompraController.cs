using ListaDeCompras.Business.Entities;
using ListaDeCompras.Business.Interfaces.ServicesInterfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace ListaDeCompras.API.Controllers
{
        [ApiController]
        [Route("[controller]")]

    public class CompraController : ControllerBase
    {
        private readonly ILogger<CompraController> _logger;
        private ICompraService _CompraService;

        public CompraController(ILogger<CompraController> logger, ICompraService compraService)
        {
            _logger = logger;
            _CompraService = compraService;
        }

        [HttpPost("nova-compra")]
        public async Task<Compra> CadastrarNovaCompra([FromBody]Compra compra)
        {
            var result = await _CompraService.CadastrarCompra(compra);
            return result;
        }

        [HttpGet("{id}")]
        public async Task<Compra> RecuperarCompraPorId(int id)
        {
            var result = await _CompraService.BuscarCompraPorId(id);
            return result;
        }
    }
}
