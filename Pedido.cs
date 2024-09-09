using System.Globalization;

public enum Estado
{
    Pendiente,
    Entregado
}

public class Pedido
{
    int numPedido;
    string obs;
    Cliente clientes;
    Estado estados;

    public Pedido()
    {
        Clientes = new Cliente();
        estados = Estado.Pendiente;
    }

    public Pedido(int num, string obs, string nomb, string dir, string tel, string dat ) // FALTA COMO ASIGNAR EL PEDIDO CREADO A UN CADETE AUTOMATICAMENTE
    {
        this.NumPedido = num;
        this.Obs = obs;
        this.estados = Estado.Pendiente;
        Clientes = new Cliente(nomb,dir,tel,dat);

    }

   
    public Estado Estados { get => Estados; set => Estados = value; }
    public string Obs { get => obs; set => obs = value; }
    public Cliente Clientes { get => clientes; set => clientes = value; }
    public int NumPedido { get => numPedido; set => numPedido = value; }

    public bool CambiarEstadoPedido(int nroPedido)
    {
            if(this.NumPedido == nroPedido)
            {
                this.Estados = Estado.Entregado;
                return true;
            }

        return false;
    }
  
}