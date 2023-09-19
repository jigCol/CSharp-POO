using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Agregale los siguientes atributos:
            //Modelo string.
            //Marca string.
            //NumeroTelefonico string.
            //CodigoOperador int (1, 2 o 3).

            string modelo;
            string marca;

            Console.Write("Ingrese el modelo de telefono: ");
            modelo = Console.ReadLine();
            Console.Write("Ingrese la marca: ");
            marca = Console.ReadLine();

            Telefono tel = new Telefono(modelo, marca);

            Console.Write("Ingrese el numero de telefono: ");
            tel.NumeroTelefonico = Console.ReadLine();
            Console.Write("Ingrese el codigo operador (1,2 o 3): ");
            tel.CodigoOperador = int.Parse(Console.ReadLine());


            Console.WriteLine("\nEl modelo es " + tel.Modelo);
            Console.WriteLine("La marca es " + tel.Marca);
            Console.WriteLine("El numero de telefono es " + tel.NumeroTelefonico);
            Console.WriteLine("El codigo operador es " + tel.CodigoOperador);

            Console.ReadKey();

            Console.Write("\n¿Desea llamar a un contacto?\n1-Si, por favor.\n2-No, gracias.\n");
            tel.NConfirmacion = int.Parse(Console.ReadLine());

            tel.ConfirmacionLlamada();

            string contacto = Console.ReadLine();
            Console.WriteLine(tel.Llamar(contacto));

            Console.ReadKey();
            Console.WriteLine("...");
            Console.ReadKey();
            Console.WriteLine("...");
            Console.ReadKey();
            Console.WriteLine("La llamada ha fallado, intentelo nuevamente.");
            Console.ReadKey();


        }
    }
}
