// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Cadeteria Nueva = new Cadeteria();
Console.WriteLine(Nueva.GetNombre);


string rutaArchivoDatosCadeteria = "datosCadeteria.csv";
string rutaArchivoDatosCadetes = "datosCadetes.csv";

Cadeteria oca = AccesoDatos.ObtenerCadeteria(rutaArchivoDatosCadeteria); //Verificado
List<Cadete> listadoCadetes = AccesoDatos.ObtenerCadetes(rutaArchivoDatosCadetes);
oca.AgregarListaCadetes(listadoCadetes);