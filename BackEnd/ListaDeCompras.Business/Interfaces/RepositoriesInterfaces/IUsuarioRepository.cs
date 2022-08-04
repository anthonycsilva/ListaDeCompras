using ListaDeCompras.Business.Entities;
using ListaDeCompras.Business.ViewModels.Request.Usuario;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeCompras.Business.Interfaces.RepositoriesInterfaces
{
    public interface IUsuarioRepository
    {
        Task<Usuario> CadastrarUsuario(Usuario usuario);
        Task<List<Usuario>> RecuperarUsuarios();
        Task<Usuario> RecuperarUsuarioPorId(int id);
        Task<Usuario> RealizarLogin(Usuario usuario);
    }
}
