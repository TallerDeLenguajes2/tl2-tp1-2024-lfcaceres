using System.Dynamic;
using System.Net.NetworkInformation;

public class Cadeteria
{
    private string nombre;
    private string telefono;
    private List<Cadete> listaCadete;

    public string Nombre { get => nombre; set => nombre = value; }

    public Cadeteria()
    {
        nombre = " POR DEFECTO ";
        telefono = " ";
        listaCadete = new List<Cadete>();
    }

    public Cadeteria(string nombre, string telefono)
    {
        this.nombre = nombre;
        this.telefono = telefono;
        listaCadete = new List<Cadete>();
    }
    
    public void AgregarCadete(string id,string nombre, string direccion, string telefono)
    {
        Cadete cadete1 = new Cadete(id,nombre,direccion,telefono);
        listaCadete.Add(cadete1);
    }

    public void AgregarPedidoACadete(string idcadete, Pedido p)
    {
        foreach(var c in listaCadete) 
        {
            if(c.Id == idcadete)
            {
                c.AgregarPedido(p);
            }
        }
        
    }

    public void CambiarEstadoPedido(string idcadete, int idpedido)
    {
        foreach(var c in listaCadete) 
        {
            if(c.Id == idcadete)
            {
                c.CambiarEstadoPedido(idpedido);
            }
        }
    }

    public void AgregarListaCadetes(List<Cadete> listaCadetes){
        this.listaCadete = listaCadetes;
    }

    public bool ExisteCadete(string id)
    {
        foreach(var c in listaCadete) 
        {
            if(c.Id == id)
            {
                return true;
            }
        }
        return false;

    }
    public bool ReasignarPedido(string idCadeteActual, int nroPedido, string idCadeteAsginado)
    {
        Pedido aux = new Pedido();
        Cadete aux2 = new Cadete();
        foreach(var c in listaCadete) // BUSCO CADETE ACTUAL PARA BUSCAR EL PEDIDO
        {
            if(c.Id == idCadeteActual)
            {
                foreach(var p in c.ListaPedidos){ //BUSCO EL PEDIDO 
                    if(p.NumPedido == nroPedido && p.Estados != Estado.Entregado)
                    {
                        this.ExisteCadete(idCadeteAsginado); // PREGUNTO SI EXISTE EL CADETE A ASIGNAR
                        aux = p; // GUARDO EN UNA VAR AUX
                        c.ListaPedidos.Remove(p); //BORRRAR PEDIDO DEL CADETE ACTUAL
                        foreach(var d in listaCadete) //BUSCO EL CADETE A ASIGNAR
                        {
                            if(d.Id == idCadeteAsginado)
                            {
                                 d.AgregarPedido(aux);
                            } 
                        }
                        return true;
                    }
                    
                }
            }

        }

        return false;
    }

    public void informe()
    {
        double sumador = 0;
        foreach(var c in this.listaCadete)
        {
            double aux = c.JornalACobrar();
            sumador = sumador + aux;
            
            Console.WriteLine("Monto Ganado por el cadete: " + c.Id);
            Console.WriteLine(aux);
            Console.WriteLine("Cantidad de envios del cadete: " +c.Id);
            Console.WriteLine(c.CantidadPedidosEntregados());
        }
        Console.WriteLine("Monto Total Ganado");
        Console.WriteLine(sumador);
        
    }
}