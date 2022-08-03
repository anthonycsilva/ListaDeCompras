using ListaDeCompras.Business.Interfaces.ServicesInterfaces;
using ListaDeCompras.Business.ViewModels.Request.Usuario;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ListaDeCompras.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
        private IUsuarioServices _usuarioService;
        //private AutoMapper _mapper;
        public UsuarioController(IUsuarioServices usuarioServices)
        {
            _usuarioService = usuarioServices;
        }

        [HttpGet("/")]

        public async Task<IActionResult> RecuperarUsuarios()
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = await _usuarioService.RecuperarUsuarios();
            return Ok(result);
        }

        [HttpPost("/")]
        public async Task<IActionResult> CadastrarUsuario([FromBody] UsuarioDadosRequest viewModel)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = await _usuarioService.CadastrarUsuario(viewModel);
            return Ok(result);
        }
    }
}
