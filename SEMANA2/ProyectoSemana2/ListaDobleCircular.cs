using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSemana2
{
    internal class ListaDobleCircular
    {
        NodoCircularDoble raiz, nuevo, ptr, aux;

        public void InsertarFIFO(int dato)
        {
            nuevo = new NodoCircularDoble();
            nuevo.info = dato;
            ptr = aux = raiz;
            // lista vacia
            if (raiz == null)
            {
                raiz = nuevo;
                raiz.sig = raiz.ant = nuevo;
            } else
            {
                do
                {
                    aux = ptr;
                    ptr = ptr.sig;
                }
                while (ptr != raiz);

                nuevo.sig = raiz;
                nuevo.ant = aux;
                aux.sig = nuevo;
                raiz.ant = nuevo;
            }

        }

        public void Recorrido()
        {
            ptr = raiz;

            do
            {
                Console.Write("{0},", ptr.info);
                ptr = ptr.sig;
            }
            while (ptr != raiz);
        }
    }
}
