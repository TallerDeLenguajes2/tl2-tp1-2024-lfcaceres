using System.Dynamic;


public class Cadeteria
{
    private string nombre;
    private string telefono;
    private List<Cadete> ListaCadete;
    private List<Pedido> listaPedidos;

    public Cadeteria()
    {
        //Nombre = " POR DEFECTO ";
        //Telefono = " ";
        ListaCadete = new List<Cadete>();
        listaPedidos = new List<Pedido>();
    }

    public Cadeteria(string nombre, string telefono)
    {
        this.Nombre = nombre;
        this.telefono = telefono;
        ListaCadete = new List<Cadete>();
        listaPedidos = new List<Pedido>();
    }

    public string Telefono { get => telefono; set => telefono = value; }
    public string Nombre { get => nombre; set => nombre = value; }

    public void AgregarCadete(string id,string nombre, string direccion, string telefono)
    {
        Cadete cadete1 = new Cadete(id,nombre,direccion,telefono);
        ListaCadete.Add(cadete1);
    }

    public void AgregarListaCadetes(List<Cadete> listaCadetes){
        this.ListaCadete = listaCadetes;
    }

    public void AgregarPedido(Pedido ped)
    {
        if(ped != null)
        {
            listaPedidos.Add(ped);
        }
    }

    public int CantPedidosCadete(string idCadete){
        int cant = 0;
        foreach(var p in listaPedidos)
        {
            if((p.IdCadete() == idCadete) && (p.GetEstado == Estado.Entregado))
            {
                cant++;
            } 
        }

        return cant;
    }

    public Cadete ObtenerCadete(int i)
    {
     return this.ListaCadete[i];
    }

   /* public string[] TotalNombreCadete()
    {
        string[] total;
        int i=0;
        foreach(Cadete name in this.ListaCadete)
        {
            total[i]= name.Nombre;
            i++;
        }
        return total;
    }*/
    public double JornalACobrar(string idCadete){
        return ((double)500 * CantPedidosCadete(idCadete));
    }
}