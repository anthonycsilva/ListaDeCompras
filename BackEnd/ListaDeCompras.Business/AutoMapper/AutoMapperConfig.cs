using AutoMapper;
using ListaDeCompras.Business.Entities;
using ListaDeCompras.Business.ViewModels.Request.Usuario;
using ListaDeCompras.Business.ViewModels.Response.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeCompras.Business.AutoMapper
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<Usuario, UsuarioDadosRequest>();
            CreateMap<Usuario, UsuarioDadosResponse>();
        }
    }
}
