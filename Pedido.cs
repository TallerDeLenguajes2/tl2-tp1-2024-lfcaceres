using System.Globalization;

Public enum Estado
{
    Pendiente,
    Enpreparacion,
    Terminado,
    Entregado
}

Public class Pedido
{
    int NumPedido;
    string? Obs;
    Cliente clientes;
    Estado estados;


    public Pedido(int num, string obs, Estado est, string nomb, string dir, string tel, string dat) //: Cliente(nomb,dir,tel,dat)
    {
        NumPedido = num;
        Obs = obs;
        clientes = new Cliente(nomb,dir,tel,dat);
        estados = est;
    }
}