using System;
using System.Collections.Generic;

//Lara Nosti 5º10º
namespace Tarea_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Int16> lista = new List<Int16>();

            lista.Add(12);
            lista.Add(25);
            lista.Add(34);
            lista.Add(10);
            lista.Add(52);
            lista.Add(10);
            lista.Add(17);

            Console.WriteLine("Los elementos:");
            foreach (Int16 num in lista)
            {
                Console.WriteLine(num);
            }

            //1. Buscar los elementos que contengan el numero 10 e insertar antes el numero 0.
            for (int x = lista.Count - 1; x >= 0; x--)
            {
                if (lista[x] == 10)
                {
                    lista.Insert(x, 0);
                }
            }

            //2. Buscar los elementos que contengan el numero 10 e insertar después el numero 0.
            /*for (int x = lista.Count - 1; x >= 0; x--)
            {
                if (lista[x] == 10)
                {
                    lista.Insert(x + 1, 0);
                }
            }*/

            //3. Buscar el elemento que contenga el numero 10 e insertar antes y después un 0.
            /*for (int x = lista.Count - 1; x >= 0; x--)
            {
                if (lista[x] == 10)
                {
                    lista.Insert(x, 0);
                    lista.Insert(x + 2, 0);
                }
            }*/

            //4. Eliminar el primer y el ultimo elemento.
            /*lista.RemoveAt(0);
            lista.RemoveAt(lista.Count - 1);*/

            //5. Eliminar el segundo y el ante ultimo elemento.
            /*lista.RemoveAt(1);
            lista.RemoveAt(lista.Count - 2);*/

            Console.WriteLine("Ahora los elementos son:");
            foreach (Int16 num in lista)
            {
                Console.WriteLine(num);
            }

            Console.ReadKey();
        }
    }
}
