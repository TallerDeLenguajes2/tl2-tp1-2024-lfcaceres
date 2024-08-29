
public class Cadete
{
    private int Id;
    private string? Nombre;
    private string? Direccion;
    private string? Telefono;
    private List<Pedido> listaPedidos;

    public Cadete()
    {
        Id=000;
        Nombre = "DEFAULT";
        Direccion = "DEFAULT";
        Telefono = "1234";
        ListaPedidos = new List<Pedido>();
    }
    public Cadete(int id,string nombre, string direccion, string telefono)
    {
        Id=id;
        Nombre = nombre;
        Direccion = direccion;
        Telefono = telefono;
        ListaPedidos = new List<Pedido>();
    }
    public void AgregarPedido(Pedido pedido)
    {
        this.listaPedidos.Add(pedido);
    }
}