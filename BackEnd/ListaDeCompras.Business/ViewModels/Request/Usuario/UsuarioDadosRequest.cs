using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeCompras.Business.ViewModels.Request.Usuario
{
    public class UsuarioDadosRequest
    {
        [Required(ErrorMessage = "Voce precisa ter um nome!")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Voce precisa ter um login!")]
        public string Login { get; set; }
        [Required(ErrorMessage = "Voce precisa ter uma senha!")]
        public string Password { get; set; }
        public float Saldo { get; set; }
    }
}
