using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSemana1
{
    public class ListaSimple
    {
        Nodo raiz, nuevo, aux, ptr; // ptr = pointer = puntero = direccion direccion = numero

        // Método Constructor
        public ListaSimple() { raiz = null; }

        // Método InsertarLIFO
        public void InsertarLIFO(int dato)
        {
            nuevo = new Nodo();
            nuevo.info = dato;
            if (raiz == null)
            {
                nuevo.sig = null; raiz = nuevo;
            }
            else
            {
                nuevo.sig = raiz; raiz = nuevo;
            }
        }
        // Método InsertarFIFO
        public void InsertarFIFO(int dato)
        {
            nuevo = new Nodo();
            nuevo.info = dato;
            if (raiz == null)
            {
                nuevo.sig = null; raiz = aux = nuevo;
            }
            else
            {
                aux.sig = nuevo; nuevo.sig = null; aux = nuevo;
            }
        }

        // Método Recorrido
        public void Recorrido()
        {
            ptr = raiz;
            while(ptr != null)
            {
                Console.Write("{0},", ptr.info);
                ptr = ptr.sig;
            }
        }

        // Método Buscar
        public int Buscar(int dato)
        {   int resultado = 0;
            ptr = raiz;
            while(ptr != null)
            {
                if(ptr.info == dato)
                {
                    resultado = 1; break;
                }
                ptr = ptr.sig;
            }
            return resultado;
        }

        // Método Eliminar
        public void Eliminar(int dato)
        {   bool resultado = false;
            if (raiz.info == dato)
            {
                resultado = true; raiz = raiz.sig;
            }
            else
            {
                ptr = aux = raiz;
                while (ptr != null)
                {
                    if (ptr.info == dato)
                    {
                        resultado = true; aux.sig = ptr.sig;
                        break;
                    }
                    aux = ptr; ptr = ptr.sig;
                }
            }
            Console.WriteLine("{0} ELIMINADO", resultado ? "SI" : "NO");
            Recorrido();
        }

        // Método Ordenar
        public void Ordenar()
        {   // > (Ascendente), < (Descendente)
            ptr = raiz;
            while (ptr != null)
            {
                aux = raiz;
                while(aux != null)
                {   if(ptr.info > aux.info){
                        int temp = ptr.info;
                        ptr.info = aux.info;
                        aux.info = temp;
                    }
                    aux = aux.sig;
                }
                ptr = ptr.sig;
            }
        }
    }
}
