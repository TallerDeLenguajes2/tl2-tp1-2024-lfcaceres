
public class Cadete
{
    private int id;
    private string? nombre;
    private string? direccion;
    private string? telefono;
    private List<Pedido> listaPedidos;

    public Cadete()
    {
        id=000;
        listaPedidos = new List<Pedido>();
    }
    public void AgregarPedido(Pedido pedido)
    {
        this.listaPedidos.Add(pedido);
    }
}