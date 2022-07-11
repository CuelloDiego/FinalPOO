using FinalPOO.Core;
using FinalPOO.DataSource;

IDataSource data = new DataSource();
Lista lista = new Lista(data);

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Alumno: Diego Cuello");
Console.ForegroundColor = ConsoleColor.Cyan;

Console.WriteLine("Lista de articulos");


foreach (var item in lista.GetItems())
{
    Console.WriteLine("Nombre: "+item.Nombre);
    Console.WriteLine("Desc: " + item.Descripcion);
    Console.WriteLine("stock: " + item.Stock);
    Console.WriteLine("precio: $" + item.Precio +"\n");

}


Console.WriteLine("La suma del stock es: "+lista.SumStock()+"\n");

Articulo art = lista.GetItemByName("RTX 3070");

if (art is not null)
{
    Console.WriteLine("Nombre: " + art.Nombre);
    Console.WriteLine("Desc: " + art.Descripcion);
    Console.WriteLine("Stock: " + art.Stock);
    Console.WriteLine("Precio: $" + art.Precio);

}
Console.ReadLine(); 