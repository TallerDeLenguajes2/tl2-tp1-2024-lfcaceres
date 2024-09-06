
using System.Data.Common;
using System;
using System.Text.Json;
using System.Text.Json.Serialization;

public class Cadete
{
    [JsonInclude]
    private string? id;
    [JsonInclude]
    private string? nombre;
    [JsonInclude]
    private string? direccion;
    [JsonInclude]
    private string? telefono;
    //

    public Cadete()
    {
        id="000";
        nombre = "DEFAULT";
        direccion = "DEFAULT";
        telefono = "1234";
        //listaPedidos = new List<Pedido>();
    }
    public Cadete(string id,string nombre, string direccion, string telefono)
    {
        this.id=id;
        this.nombre = nombre;
        this.direccion = direccion;
        this.telefono = telefono;
        //listaPedidos = new List<Pedido>();
    }
    public string ID { get=> id;}
    public string Nombre { get=> nombre;}
    /*public void AgregarPedido(Pedido pedido)
    {
        this.listaPedidos.Add(pedido);
    }*/
}