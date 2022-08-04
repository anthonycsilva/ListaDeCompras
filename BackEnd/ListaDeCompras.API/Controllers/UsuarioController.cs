using ListaDeCompras.Business.Interfaces.ServicesInterfaces;
using ListaDeCompras.Business.ViewModels.Request.Usuario;
using ListaDeCompras.Business.ViewModels.UsuarioAccount.Request;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ListaDeCompras.API.Controllers
{
    [ApiController]
    [Route("usuarios")]
    public class UsuarioController : ControllerBase
    {
        private IUsuarioServices _usuarioService;
        //private AutoMapper _mapper;
        public UsuarioController(IUsuarioServices usuarioServices)
        {
            _usuarioService = usuarioServices;
        }

        [HttpGet]
        [Route("obter-usuarios")]
        public async Task<IActionResult> RecuperarUsuarios()
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = await _usuarioService.RecuperarUsuarios();
            return Ok(result);
        }

        [HttpPost("cadastrar-usuario")]
        public async Task<IActionResult> CadastrarUsuario([FromBody] UsuarioDadosRequest viewModel)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = await _usuarioService.CadastrarUsuario(viewModel);
            return Ok(result);
        }

        [HttpPost("login")]
        public async Task<IActionResult> RealizarLogin([FromBody] UsuarioAccountRequest viewModel)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = await _usuarioService.RealizarLogin(viewModel);
            return Ok(result);
        }


    }
}
