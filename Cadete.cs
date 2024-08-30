
public class Cadete
{
    private string Id;
    private string? Nombre;
    private string? Direccion;
    private string? Telefono;
    private List<Pedido> listaPedidos;

    /*public Cadete()
    {
        Id="000";
        Nombre = "DEFAULT";
        Direccion = "DEFAULT";
        Telefono = "1234";
        listaPedidos = new List<Pedido>();
    }*/
    public Cadete(string id,string nombre, string direccion, string telefono)
    {
        Id=id;
        Nombre = nombre;
        Direccion = direccion;
        Telefono = telefono;
        listaPedidos = new List<Pedido>();
    }
    public void AgregarPedido(Pedido pedido)
    {
        this.listaPedidos.Add(pedido);
    }
}