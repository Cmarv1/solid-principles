using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace principios_solid
{
    public interface IRepositorioPedidos
    {
        void Guardar(Pedido pedido);
    }
}
