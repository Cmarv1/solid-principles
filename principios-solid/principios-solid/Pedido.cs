using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace principios_solid
{
    public class Pedido
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }

        public void CrearPedido()
        {
            Console.WriteLine("Creacion de pedido");
        }

        public void CancelarPedido()
        {
            Console.WriteLine("Cancelar pedido");
        }
    }
}
