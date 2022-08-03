using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeCompras.Business.Entities
{
    public class Compra
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public float Valor { get; set; }
        public bool Comprada { get; set; }
        public DateTime DataInseridaCompra {get; set; }
        public DateTime DataQuandoFoiComprada {get; set; }
    }
}
