using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Practica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue miFila=new Queue();
            Console.Write("Ingrese la cantidad de Filas: ");
            int n = int.Parse(Console.ReadLine());
            int tamañoFila = n;
            for(int i = 0; i < n; i++)
            {
                Console.Write("Nombre de la Persona: ");
                miFila.Enqueue(Console.ReadLine());

            }
            Console.WriteLine("La cajera atendio a ");
            while (tamañoFila > 0)
            {
                Console.WriteLine(miFila.Dequeue());
                tamañoFila--;
            }
            Console.ReadKey();
        }
    }
}
