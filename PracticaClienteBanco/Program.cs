using System;

namespace PracticaClienteBanco // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Instanciaremos un cliente
            Cliente cliente = new Cliente("Angel Dabnee", "Gonzalez Rodriguez", new DateTime(1997,09,08), BancoEnum.BBVA);
            Console.WriteLine(cliente.ToString());
            Console.WriteLine(cliente.CalcularEdad);
            Console.WriteLine(cliente.RFC);
        }
    }
}