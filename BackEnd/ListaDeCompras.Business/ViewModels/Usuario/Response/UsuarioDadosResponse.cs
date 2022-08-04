using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeCompras.Business.ViewModels.Usuario.Response
{
    public class UsuarioDadosResponse
    {
        [Required(ErrorMessage = "Voce precisa ter um nome!")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Voce precisa ter um login!")]
        public float Saldo { get; set; }
    }
}
