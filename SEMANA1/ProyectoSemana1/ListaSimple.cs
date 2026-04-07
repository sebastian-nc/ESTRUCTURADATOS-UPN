using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSemana1
{
    public class ListaSimple
    {
        Nodo raiz, nuevo, aux, ptr; // ptr = pointer = puntero = direccion direccion = numero

        public void InsertarFIFO(int dato)
        {
            nuevo = new Nodo();
            nuevo.info = dato;

            if (raiz == null) { nuevo.sig = null; raiz = aux = nuevo; }
            else { nuevo.sig = null; aux.sig = nuevo; aux = nuevo; }
        }

        public void InsertarLIFO(int dato)
        {
            nuevo = new Nodo();
            nuevo.info = dato;

            if (raiz == null) { nuevo.sig = null; raiz = nuevo; }
            else { nuevo.sig = raiz; raiz = nuevo; }
        }

        
        public void Recorrido()
        {
            ptr = raiz;

            while (ptr != null)
            {
                Console.Write(ptr.info + ",");
                ptr = ptr.sig;
            }
        }

        public void Eliminar(int dato)
        {
            if (raiz == null) { Console.WriteLine("LISTA VACIA"); }
            else if (raiz.info == dato) { raiz = raiz.sig; }
            else
            {
                aux = ptr = raiz;
                while (aux != null)
                {
                    if (aux.info == dato)
                    {
                        ptr.sig = aux.sig;
                        aux = null;
                    }
                    else
                    {
                        ptr = aux;
                        aux = aux.sig;
                    }
                }
            }
        
        }

        public bool Buscar(int dato)
        {
            bool resultado = false;
            ptr = raiz;

            while (ptr != null)
            {
                if (ptr.info == dato){ resultado = true; ptr = null; }
                else { ptr = ptr.sig; }
            }
            return resultado;
        }

        // Método Ordenar
        public void Ordenar()
        {   // > (Ascendente), < (Descendente)
            ptr = raiz;
            while (ptr != null)
            {
                aux = raiz;
                while (aux != null)
                {
                    if (ptr.info > aux.info)
                    {
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
