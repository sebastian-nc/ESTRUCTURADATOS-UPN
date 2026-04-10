using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSemana2
{
    public class Program
    {
        static void Main(string[] args)
        {
            ListaDobleCircular miLista = new ListaDobleCircular();

            Random rnd = new Random();

            for(int i = 1; i <= 5; i++)
            {
                int valor = rnd.Next(10, 100);
                Console.Write("{0}: {1}", i, valor);
                Console.Write(" ");
                miLista.InsertarLIFO(valor);
            }
            Console.WriteLine("");
            miLista.Recorrido();
            //miLista.Ordenar();
            //miLista.Recorrido();
            // Búsqueda
            int dato;
            do
            {
                Console.WriteLine("\nDATO A BUSCAR (-1 SALIR):");
                dato = Int32.Parse(Console.ReadLine());
                Console.WriteLine("DATO {0} {1} EXISTE", dato,
                    miLista.Buscar(dato) ? "SI" : "NO");
            } while (dato != -1);

            // Eliminación
            do
            {
                Console.WriteLine("\nDATO A ELIMINAR (-1 SALIR):");
                dato = Int32.Parse(Console.ReadLine());
                Console.WriteLine("DATO {0} {1} ELIMINADO", dato,
                    miLista.Eliminar(dato) ? "SI" : "NO");
                miLista.Recorrido();
            } while (dato != -1);

            Console.WriteLine("\n-----TERMINO-----");
        }
    }
}
