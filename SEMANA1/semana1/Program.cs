using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semana1
{
    public class Program
    {
        static void Main(string[] args)
        {
            ListaSimple lista = new ListaSimple();
            lista.InsertarFIFO(50);
            lista.InsertarFIFO(20);
            lista.InsertarFIFO(10);
            lista.InsertarFIFO(70);
            lista.InsertarFIFO(90);

            Console.WriteLine("LISTAR RECORRIDO");
            lista.Recorrido();

            int dato;
            do
            {
                Console.Write("DATO A BUSCAR (-1 FIN): ");
                dato = Int32.Parse(Console.ReadLine());
                Console.WriteLine("{0} {1} ENCONTRO", dato, lista.Buscar(dato) == 1 ? "SI" : "NO");
                
            } while (dato != -1);

            do
            {
                Console.Write("DATO A ELIMINAR (-1 FIN): ");
                dato = Int32.Parse(Console.ReadLine());
                lista.Eliminar(dato);
                lista.Recorrido();

            } while (dato != -1);
            Console.ReadLine();
            
        }
    }
}
