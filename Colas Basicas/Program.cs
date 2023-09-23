
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colas_Basicas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crear una instancia de Queue para representar una cola
            Queue<string> cola = new Queue<string>();

            // Encolar elementos en la cola
            cola.Enqueue("Primero");
            cola.Enqueue("Segundo");
            cola.Enqueue("Tercero");
            cola.Enqueue("Cuarto");
            cola.Enqueue("Quinto");

            // Mostrar el contenido de la cola
            Console.WriteLine("Elementos en la cola:");
            foreach (string elemento in cola)
            {
                Console.WriteLine(elemento); // Debe imprimir los elementos en el orden de encolado
            }

            // Desencolar un elemento de la cola
            string elementoDesencolado = cola.Dequeue();
            Console.WriteLine("\nElemento desencolado: " + elementoDesencolado); // Debe imprimir "Primero"

            // Mostrar el elemento frontal de la cola sin desencolarlo
            string elementoFrontal = cola.Peek();
            Console.WriteLine("Elemento frontal de la cola: " + elementoFrontal); // Debe imprimir "Segundo"
        }
    }
}
