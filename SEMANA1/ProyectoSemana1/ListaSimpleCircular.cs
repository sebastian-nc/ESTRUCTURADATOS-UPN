using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSemana1
{
    internal class ListaSimpleCircular
    {
        NodoCircular raiz, nuevo, ptr, aux;
        public ListaSimpleCircular() {
            raiz = null;
        }
        
        public void InsertarFIFO(int dato)
        {
            nuevo = new NodoCircular();
            nuevo.info = dato;
            ptr = aux = raiz;

            if (raiz == null) { nuevo.sig = nuevo; raiz = nuevo; }
            else
            {
                do
                {
                    aux = ptr;
                    ptr = ptr.sig;
                }
                while (ptr != raiz);
                
                nuevo.sig = raiz;
                aux.sig = nuevo;
            }
        }

        public void InsertarLIFO(int dato)
        {
            nuevo = new NodoCircular();
            nuevo.info = dato;
            ptr = aux = raiz;

            if (raiz == null) { nuevo.sig = nuevo; raiz = nuevo; }
            else {
                do
                {
                    aux = ptr;
                    ptr = ptr.sig;
                }
                while (ptr != raiz);

                aux.sig = nuevo;
                nuevo.sig = raiz;
                raiz = nuevo;
            }
            
        }

        public void Eliminar(int dato)
        {
            if (raiz == null) { return;}
            
            ptr = aux = raiz;
            
            // Solo si hay un elemento
            if (raiz.info == dato && raiz.sig == raiz){ raiz = null; }
            // Eliminar el primer valor
            else if (raiz.info == dato)
            {
                do
                {
                    aux = ptr;
                    ptr = ptr.sig;
                }
                while (ptr != raiz);
                raiz = raiz.sig;
                aux.sig = raiz;
            }
            else
            {
                do
                {
                    aux = ptr;
                    ptr = ptr.sig;
                }
                while (ptr != raiz && ptr.info != dato);

                if (ptr.info == dato) {aux.sig = ptr.sig;}

            }
        }

        public bool Buscar(int dato)
        {
            if (raiz == null) { return false; }
            bool encontrado = false;

            ptr = raiz;

            do
            {
                if (ptr.info == dato) { encontrado = true; }
                ptr = ptr.sig;
            }
            while (ptr != raiz);

            return encontrado;
        }
        
        public void Recorrido()
        {
            if (raiz == null) { Console.WriteLine("LISTA VACIA"); return; }
            
            ptr = raiz;
            do
            {
                Console.Write(ptr.info + ",");
                ptr = ptr.sig;
            }
            while (ptr != raiz);
            

        }
    }
}
