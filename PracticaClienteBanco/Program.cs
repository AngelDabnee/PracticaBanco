using System;

namespace PracticaClienteBanco // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Instanciaremos un cliente
            Cliente cliente = new Cliente("Angel Dabnee", "Gonzalez Rodriguez", new DateTime(1997,09,08), BancoEnum.BBVA, "BBVA");
            Console.WriteLine(cliente.ToString());
            Console.WriteLine(cliente.Edad);
            Console.WriteLine(cliente.RFC);
            Console.WriteLine(cliente.Cuenta);
            if (cliente.Edad >= 18 && (cliente.Cuenta) == BancoEnum.BBVA.ToString())
            {
                Console.WriteLine("Mayor de edad");
            }
            else if (cliente.Edad >= 65 && cliente.Cuenta == BancoEnum.SANTANDER.ToString())
            {
                Console.WriteLine("El cliente tiene los 65 o es mayor, y tiene su cuenta en Santander");
            }
            else 
            {
                Console.WriteLine("El cliente es menor de edad y no tiene cuenta bancaria");
            }
            Console.WriteLine("Presione cualquier tecla para finalizar");
            Console.ReadKey();
        }
    }
}