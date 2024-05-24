using principios_solid;

class Program
{
    static void Main(string[] args)
    {
        Pedido pedido = new Pedido { Id = 1, Descripcion = "Peido de prueba" };

        IRepositorioPedidos repositorioPedidos = new RepositorioPedidosSql();

        ServicioDePedidos servicioDePedidos = new ServicioDePedidos(repositorioPedidos);

        servicioDePedidos.GuardarPedido(pedido);

        Console.WriteLine("El pedido ha sido procesado.");
    }
}
