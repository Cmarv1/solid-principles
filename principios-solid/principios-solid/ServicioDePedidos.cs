using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace principios_solid
{
    public class ServicioDePedidos
    {
        private readonly IRepositorioPedidos _repositorioPedidos;

        public ServicioDePedidos(IRepositorioPedidos repositorioPedidos)
        {
            _repositorioPedidos = repositorioPedidos;
        }

        public void GuardarPedido(Pedido pedido)
        {
            _repositorioPedidos.Guardar(pedido);
        }
    }
}
