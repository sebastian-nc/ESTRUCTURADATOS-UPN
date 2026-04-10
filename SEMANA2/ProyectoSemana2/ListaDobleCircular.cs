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
        
        public void InsertarLIFO(int dato)
        {
            nuevo = new NodoCircularDoble();
            nuevo.info = dato;
            ptr = aux = raiz;

            if (raiz == null)
            {
                raiz = nuevo;
                raiz.sig = raiz.ant = nuevo;
            }
            else
            {
                do
                {
                    aux = ptr;
                    ptr = ptr.sig;
                }
                while (ptr != raiz);

                raiz.ant = nuevo;
                nuevo.sig = raiz;
                nuevo.ant = aux;
                aux.sig = nuevo;
                raiz = nuevo;
            }
        }

        public void Recorrido()
        {
            if (raiz == null)
            {
                Console.WriteLine("LISTA VACIA");
                return;
            }
            ptr = raiz;

            do
            {
                Console.Write("{0},", ptr.info);
                ptr = ptr.sig;
            }
            while (ptr != raiz);
        }
        
        public bool Buscar(int dato)
        {
            bool encontrado = false;
            ptr = raiz;

            do
            {
                if (ptr.info == dato)
                {
                    encontrado = true;
                }

                ptr = ptr.sig;
            }
            while (ptr != raiz);

            return encontrado;
        }

        public bool Eliminar(int dato) {
            bool encontrado = false;
            ptr = aux = raiz;

            if (raiz == null) return encontrado;

            // Inicio
            if (raiz.info == dato)
            {
                if (raiz.sig == raiz)
                {
                    raiz = null;
                }else
                {
                    raiz.sig.ant = raiz.ant;
                    raiz = raiz.sig;
                    raiz.ant.sig = raiz;
                }
                encontrado = true;
            }
            // Ultimo
            else if (raiz.ant.info == dato)
            {
                raiz.ant.ant.sig = raiz;
                raiz.ant = raiz.ant.ant;
                encontrado = true;
            } else
            {
                do
                {
                    if (ptr.info == dato)
                    {
                        encontrado = true;
                    } else
                    {
                        ptr = ptr.sig;
                    }
                }
                while (ptr != raiz && !encontrado);

                if (encontrado)
                {
                    ptr.ant.sig = ptr.sig;
                    ptr.sig.ant = ptr.ant;
                }
            }
           
            return encontrado;
        }
    }
}
