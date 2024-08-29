public class Cadeteria
{
    private string? Nombre;
    private string? Telefono;
    private List<Cadete> ListaCadete;

    public Cadeteria(string Nombre, string Telefono)
    {
        Cadete ListaCadete = new List<Cadete>();
    }
    public AgregarCadete(int id,string nombre, string direccion, string telefono)
    {
        Cadete cadete1 = new Cadete(id,nombre,direccion,telefono);
        ListaCadete.add(cadete1);
    }
}