using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace principios_solid
{
    public class RepositorioPedidosSql : IRepositorioPedidos
    {
        public void Guardar(Pedido pedido)
        {
            Console.WriteLine($"Pedido con ID {pedido.Id} guardado en la base de datos SQL.");
        }
    }
}
