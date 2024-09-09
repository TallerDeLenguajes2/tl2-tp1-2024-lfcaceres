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
        Estados = Estado.Pendiente;
    }

    public Pedido(int num, string obs, string nomb, string dir, string tel, string dat ) // FALTA COMO ASIGNAR EL PEDIDO CREADO A UN CADETE AUTOMATICAMENTE
    {
        this.NumPedido = num;
        this.Obs = obs;
        this.Estados = Estado.Pendiente;
        Clientes = new Cliente(nomb,dir,tel,dat);

    }
    public string Obs { get => obs; set => obs = value; }
    public Cliente Clientes { get => clientes; set => clientes = value; }
    public int NumPedido { get => numPedido; set => numPedido = value; }
    public Estado Estados { get => estados; set => estados = value; }

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