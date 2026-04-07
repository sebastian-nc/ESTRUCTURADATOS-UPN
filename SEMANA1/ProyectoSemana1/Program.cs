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
            ListaSimple lista = new ListaSimple();
            // Añadir 5 elementos
            lista.InsertarLIFO(50);
            lista.InsertarLIFO(20);
            lista.InsertarLIFO(80);
            lista.InsertarLIFO(10);
            lista.InsertarLIFO(90);
            // Listar los elementos
            Console.WriteLine("--- LISTADO DE ELEMENTOS ---");
            lista.Recorrido();
            // Ordenar los elementos
            lista.Ordenar();
            // Listar los elementos
            Console.WriteLine("--- LISTADO DE ELEMENTOS ---");
            lista.Recorrido();
            // Buscar elemento
            int dato;
            do
            {
                Console.Write("\nDATO A BUSCAR (-1 FIN):");
                dato = Int32.Parse(Console.ReadLine());
                Console.WriteLine("{0} {1} ENCONTRADO", dato,
                    lista.Buscar(dato) == 1 ? "SI" : "NO");
            } while (dato != -1);
            // Eliminar elemento
            do
            {
                Console.Write("\nDATO A ELIMINAR (-1 FIN):");
                dato = Int32.Parse(Console.ReadLine());
                lista.Eliminar(dato);
            } while (dato != -1);

            Console.ReadLine();
        }
    }
}
