using System.Globalization;

public enum Estado
{
    Pendiente,
    Entregado
}

public class Pedido
{
    int NumPedido;
    string Obs;
    Cliente clientes;
    Estado estados;
    Cadete cadete;

    public Pedido(int num, string obs, Estado est, string nomb, string dir, string tel, string dat) //: Cliente(nomb,dir,tel,dat)
    {
        NumPedido = num;
        Obs = obs;
        clientes = new Cliente(nomb,dir,tel,dat);
        estados = est;
        cadete = new Cadete();
    }

    public Estado GetEstado {get => estados;}
     public void Entregado()
    {
        estados = Estado.Entregado;
    }
    public void AsignarCadete(Cadete cad)
    {
        cadete = cad;
    }
    public string IdCadete(){
        if (cadete.Id != null)
        {
            return cadete.Id;
        }else{
            return "";
        }
        
    }
}