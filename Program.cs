// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Cadeteria Nueva = new Cadeteria();
//Console.WriteLine(Nueva.GetNombre);


string rutaArchivoDatosCadeteria = "datosCadeteria.csv";
string rutaArchivoDatosCadetes = "datosCadetes.csv";

string rutaArchivoDatosCadeteriaJ = "cadeteriaInfo.json";
string rutaArchivoDatosCadetesJ = "cadetesInfo.json";

AccesoDatos CVS = new AccesoCSV();
Cadeteria oca = CVS.ObtenerCadeteria(rutaArchivoDatosCadeteria);
oca.AgregarListaCadetes(CVS.ObtenerCadetes(rutaArchivoDatosCadetes));
//Console.WriteLine(oca.ObtenerCadete(0).Nombre);

AccesoDatos JSON = new AccesoJSON();
Cadeteria oca2 = JSON.ObtenerCadeteria(rutaArchivoDatosCadeteriaJ);
oca2.AgregarListaCadetes(JSON.ObtenerCadetes(rutaArchivoDatosCadetesJ));
Console.WriteLine(oca2.Nombre);
Console.WriteLine(oca2.ObtenerCadete(0).Nombre);


