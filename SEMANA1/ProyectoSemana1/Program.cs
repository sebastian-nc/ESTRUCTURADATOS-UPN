using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSemana1
{
    public class Program
    {
        static void Main(string[] args)
        {
            //ListaSimple lista = new ListaSimple();
            ListaSimpleCircular lista = new ListaSimpleCircular();
            // Insertar 10 elementos aleatorios
            Random rnd = new Random();

            for (int i = 1; i <= 5; i++)
            {
                int valor = rnd.Next(10, 150);
                lista.InsertarLIFO(valor);
                Console.Write("{0}: {1}", i, valor);
                Console.Write(" ");
            }
             
            // Listar los elementos
            Console.WriteLine("\n--- LISTADO DE ELEMENTOS ---");
            lista.Recorrido();
            //// Ordenar los elementos
            //lista.Ordenar();
            // Listar los elementos
            //Console.WriteLine("\n--- LISTADO DE ELEMENTOS ---");
            //lista.Recorrido();
            //Buscar elemento
            int dato;
            do
            {
                Console.Write("\nDATO A BUSCAR (-1 FIN):");
                dato = Int32.Parse(Console.ReadLine());
                Console.WriteLine("{0} {1} ENCONTRADO", dato,
                    lista.Buscar(dato) ? "SI" : "NO");
            } while (dato != -1);
            // Eliminar elemento
            do
            {
                Console.Write("\nDATO A ELIMINAR (-1 FIN):");
                dato = Int32.Parse(Console.ReadLine());
                lista.Eliminar(dato);
                lista.Recorrido();
            } while (dato != -1);

            Console.ReadLine();
        }
    }
}
