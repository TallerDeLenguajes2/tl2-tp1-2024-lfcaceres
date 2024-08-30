using System.Dynamic;

public class Cadeteria
{
    private string Nombre;
    private string Telefono;
    private List<Cadete> ListaCadete;

    public Cadeteria()
    {
        Nombre = " POR DEFECTO ";
        Telefono = " ";
        ListaCadete = new List<Cadete>();
    }

    public Cadeteria(string nombre, string telefono)
    {
        Nombre = nombre;
        Telefono = telefono;
        ListaCadete = new List<Cadete>();
    }
    public string GetNombre{get => Nombre;}
    public void AgregarCadete(string id,string nombre, string direccion, string telefono)
    {
        Cadete cadete1 = new Cadete(id,nombre,direccion,telefono);
        ListaCadete.Add(cadete1);
    }
}