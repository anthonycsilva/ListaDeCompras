﻿using ListaDeCompras.Business.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeCompras.Business.Interfaces.RepositoriesInterfaces
{
    public interface ICompraRepository
    {
        Task<Compra> CadastrarCompra(Compra compra);
        Task<Compra> BuscarCompraPorId(int idCompra);
        Task<bool> ExcluirCompra(Compra compra);
        Task<List<Compra>> BuscarTodasAsCompras();
    }
}
