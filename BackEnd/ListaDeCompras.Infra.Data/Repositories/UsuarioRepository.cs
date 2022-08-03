using ListaDeCompras.Business.Entities;
using ListaDeCompras.Business.Interfaces.RepositoriesInterfaces;
using ListaDeCompras.Business.ViewModels.Request.Usuario;
using ListaDeCompras.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ListaDeCompras.Infra.Data.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private DataContext _dataContext;
        public UsuarioRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<Usuario> CadastrarUsuario(Usuario usuario)
        {
            try
            {
                var result = _dataContext.Usuarios.AddAsync(usuario);
                await _dataContext.SaveChangesAsync();
                return usuario;
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public Task<Usuario> RecuperarUsuarioPorId(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Usuario>> RecuperarUsuarios()
        {
            var result =  await _dataContext.Usuarios.ToListAsync();
            return result;
        }
    }
}
