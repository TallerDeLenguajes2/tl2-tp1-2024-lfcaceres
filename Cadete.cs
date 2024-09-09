
public class Cadete
{
    private string id;
    private string? nombre;
    private string? direccion;
    private string? telefono;
    private List<Pedido> listaPedidos;

    public Cadete()
    {
        ListaPedidos = new List<Pedido>();
    }
    public Cadete(string id,string nombre, string direccion, string telefono)
    {
        this.Id=id;
        this.nombre = nombre;
        this.direccion = direccion;
        this.telefono = telefono;
        ListaPedidos = new List<Pedido>();
    }

    public string Id { get => id; set => id = value; }
    public List<Pedido> ListaPedidos { get => listaPedidos; set => listaPedidos = value; }

    public void AgregarPedido(Pedido pedido)
    {
        this.ListaPedidos.Add(pedido);
    }
    public bool CambiarEstadoPedido(int nroPedido){
        foreach(var p in ListaPedidos)
        {
            if(p.NumPedido == nroPedido)
            {
                p.Estados = Estado.Entregado;
                return true;
            }
        }

        return false;
    }
    public int CantidadPedidosEntregados()
    {
        int cantPedidosEntregados = 0;
        foreach(var p in ListaPedidos)
        {
            if(p.Estados == Estado.Entregado) cantPedidosEntregados++;
        }
         return cantPedidosEntregados;
    }

    public double JornalACobrar(){
        return((double)500 * CantidadPedidosEntregados());
    }

    
}