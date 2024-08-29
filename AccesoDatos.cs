public static class AccesoDatos
{
    private static bool ExisteArchivo(string ruta)
    {
        fileinfo f = new fileinfo(ruta); //no necesita invocar la libreria?
        if (f.exists && f.Length)
        {
            return true;
        }else
        {
            return false;
        }
    }
}