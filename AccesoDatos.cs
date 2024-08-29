public static class AccesoDatos
{
    private static bool ExisteArchivo(string ruta)
    {
        fileinfo f = new fileinfo(ruta);
        if (f.exists && f.Length)
        {
            return true;
        }else
        {
            return false;
        }
    }
}