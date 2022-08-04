using ListaDeCompras.Business.Entities;
using ListaDeCompras.Business.Interfaces.ServicesInterfaces;
using ListaDeCompras.Business.ViewModels.Request.Usuario;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using ListaDeCompras.Business.Interfaces.RepositoriesInterfaces;
using AutoMapper;
using ListaDeCompras.Business.ViewModels.Usuario.Response;

namespace ListaDeCompras.Business.Services
{
    public class UsuarioService : IUsuarioServices
    {
        private IUsuarioRepository _usuarioRepository;
        private IMapper _mapper;
        public UsuarioService(IUsuarioRepository usuarioRepository, IMapper mapper)
        {
            _usuarioRepository = usuarioRepository;
            _mapper = mapper;
        }

        public Task<UsuarioDadosResponse> BuscarUsuarioPorId(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<UsuarioDadosResponse> CadastrarUsuario(UsuarioDadosRequest viewModel)
        {
            Usuario novoUsuario = new Usuario();
            UsuarioDadosResponse response = new UsuarioDadosResponse();
            novoUsuario.Name = viewModel.Name;
            novoUsuario.Saldo = viewModel.Saldo;
            novoUsuario.Login = viewModel.Login;
            novoUsuario.Password = viewModel.Password;

            response.Name = viewModel.Name;
            response.Saldo = viewModel.Saldo;

            await _usuarioRepository.CadastrarUsuario(novoUsuario);
            return response;
        }

        public Task<bool> RealizarLogin(UsuarioDadosRequest viewModel)
        {
            throw new NotImplementedException();
        }

        public async Task<List<UsuarioDadosResponse>> RecuperarUsuarios()
        {
            var Entity = await _usuarioRepository.RecuperarUsuarios();
            var result =  _mapper.Map<List<UsuarioDadosResponse>>(Entity);
            return result;
        }
    }
}
