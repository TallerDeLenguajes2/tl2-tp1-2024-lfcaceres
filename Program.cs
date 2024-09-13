// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");



string rutaArchivoDatosCadeteria = "datosCadeteria.csv";
string rutaArchivoDatosCadetes = "datosCadetes.csv";

Cadeteria oca = AccesoDatos.ObtenerCadeteria(rutaArchivoDatosCadeteria);
List<Cadete> listadoCadetes = AccesoDatos.ObtenerCadetes(rutaArchivoDatosCadetes);
oca.AgregarListaCadetes(listadoCadetes);

Console.WriteLine(oca.Nombre);
Console.WriteLine(oca.ExisteCadete("3"));

Pedido pedido = new Pedido(1,"PEdido 1", "Cliente 1","Avellaneda 111","3817654352", "DATOS");
oca.AgregarPedidoACadete("3",pedido); // dos opciones
oca.ReasignarPedido("3",1,"1");
oca.CambiarEstadoPedido("1",1);
oca.informe();