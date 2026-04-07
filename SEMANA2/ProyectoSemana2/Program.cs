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
            Random rnd = new Random();
            ListaDoble miLista = new ListaDoble();
            for(int i = 0; i < 10; i++)
                miLista.InsertarLIFO(rnd.Next(10,100));
            miLista.Recorrido();
            miLista.Ordenar();
            miLista.Recorrido();
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

            Console.ReadLine();
        }
    }
}
