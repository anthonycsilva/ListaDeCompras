using ListaDeCompras.Business.Entities;
using ListaDeCompras.Business.Interfaces.ServicesInterfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ListaDeCompras.API.Controllers
{
        [ApiController]
        [Route("compras")]


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
        [Authorize]
        public async Task<Compra> CadastrarNovaCompra([FromBody]Compra compra)
        {
            var result = await _CompraService.CadastrarCompra(compra);
            return result;
        }

        [HttpGet("{id}")]
        [Authorize]
        public async Task<Compra> RecuperarCompraPorId(int id)
        {
            var result = await _CompraService.BuscarCompraPorId(id);
            return result;
        }

        [HttpGet("obter-compras")]
        [Authorize]
        public async Task<List<Compra>> RecuperarCompras()
        {
            var result = await _CompraService.BuscarTodasAsCompras();
            return result;
        }
    }
}
