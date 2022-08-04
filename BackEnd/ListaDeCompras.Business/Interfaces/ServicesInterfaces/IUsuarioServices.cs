﻿using ListaDeCompras.Business.Entities;
using ListaDeCompras.Business.ViewModels.Request.Usuario;
using ListaDeCompras.Business.ViewModels.Usuario.Response;
using ListaDeCompras.Business.ViewModels.UsuarioAccount.Request;
using ListaDeCompras.Business.ViewModels.UsuarioAccount.Response;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeCompras.Business.Interfaces.ServicesInterfaces
{
    public interface IUsuarioServices
    {
        Task<List<UsuarioDadosResponse>> RecuperarUsuarios();
        Task<UsuarioDadosResponse> CadastrarUsuario(UsuarioDadosRequest viewModel);
        Task<UsuarioAccountResponse> RealizarLogin(UsuarioAccountRequest viewModel);
        Task<UsuarioDadosResponse> BuscarUsuarioPorId(int id);


    }
}
