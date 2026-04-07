using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSemana2
{
    public class ListaDoble
    {
        Nodo raiz1, raiz2, ptr, nuevo;

        // Método Constructor
        public ListaDoble()
        {
            raiz1 = raiz2 = null;
        }

        // Método InsertarLIFO
        public void InsertarLIFO(int dato) {
            nuevo = new Nodo();
            nuevo.info = dato;
            if (raiz1 == null) {
                nuevo.sig = nuevo.ant = null;
                raiz1 = raiz2 = nuevo;
            }
            else
            {
                nuevo.sig = raiz1; raiz1.ant = nuevo;
                nuevo.ant = null; raiz1 = nuevo;
            }
        }
        // Método InsertarFIFO
        public void InsertarFIFO(int dato) {
            nuevo = new Nodo();
            nuevo.info = dato;
            if (raiz2 == null)
            {
                nuevo.ant = nuevo.sig = null;
                raiz1 = raiz2 = nuevo;
            }
            else
            {
                nuevo.ant = raiz2; raiz2.sig = nuevo;
                nuevo.sig = null; raiz2 = nuevo;
            }
        }
        // Método Recorrido
        public void Recorrido() {
            ptr = raiz1;
            Console.WriteLine("\n--- LISTADO DE ELEMENTOS ---");
            while(ptr != null)
            {
                Console.Write("{0},", ptr.info);
                ptr = ptr.sig;
            }
        }
        // Método Buscar
        public bool Buscar(int dato) { 
            bool encontrado = false;
            ptr = raiz1;
            while (ptr != null && !encontrado) { 
                if(ptr.info == dato)encontrado = true;
                else ptr = ptr.sig;
            }
            return encontrado; 
        }
        // Método Eliminar
        public bool Eliminar(int dato) { 
            bool encontrado = false;
            if (raiz1.info == dato)
            {   // Al inicio
                raiz1 = raiz1.sig;
                raiz1.ant = null;
                encontrado = true;
            }
            else if (raiz2.info == dato) { // Al final
                raiz2 = raiz2.ant; 
                raiz2.sig = null;
                encontrado = true;
            }
            else
            {   // En medio
                ptr = raiz1;
                while (ptr != null && !encontrado)
                {
                    if (ptr.info == dato) encontrado = true;
                    else ptr = ptr.sig;
                }
                if (encontrado)
                {
                    ptr.ant.sig = ptr.sig; ptr.sig.ant = ptr.ant;
                }
            }
            return encontrado; 
        }
        // Método Ordenar
        public void Ordenar() {
            Nodo ptr1, ptr2;
            ptr1 = raiz1;
            while (ptr1 != null) {
                ptr2 = raiz1;
                while (ptr2 != null) { 
                    if(ptr1.info > ptr2.info)
                    {
                        int aux = ptr1.info;
                        ptr1.info = ptr2.info;
                        ptr2.info = aux;
                    }
                    ptr2 = ptr2.sig;
                }
                ptr1 = ptr1.sig;
            }
        }
    }
}
