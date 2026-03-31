using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semana1
{
    public class ListaSimple
    {
        Nodo raiz, nuevo, ptr, aux;

        public ListaSimple() { 
            raiz = null;
        }

        public void InsertarLIFO(int dato)
        {
            nuevo = new Nodo();
            nuevo.info = dato;
            if (raiz == null)
            {
                nuevo.sig = null;
                raiz = nuevo;
            }else
            {
                nuevo.sig = raiz;
                raiz = nuevo;
            }
        }

        public void InsertarFIFO(int dato)
        {
            nuevo = new Nodo();
            nuevo.info = dato; 
            if (raiz == null)
            {
                nuevo.sig = null;
                raiz = aux = nuevo;
            } else
            {
                aux.sig = nuevo;
                nuevo.sig = null;
                aux = nuevo;
            }
        }

        public void Recorrido()
        {
            ptr = raiz;
            while (ptr != null)
            {
                Console.Write(ptr.info + ",");
                ptr = ptr.sig;
            }
            Console.WriteLine();
        }
        public int Buscar(int dato)
        {
            int resultado = 0;
            ptr = raiz;
            while (ptr != null)
            {
                if (ptr.info == dato)
                {
                    resultado = 1;
                    return resultado;
                }
                ptr = ptr.sig;
            }

            return resultado;
        }

        public void Eliminar(int dato) {
            bool resultado = false;
            if (raiz.info == dato)
            {
                resultado = true; 
                raiz = raiz.sig;
            }
            else
            {
                ptr = aux = raiz;
                while (ptr != null)
                {
                    if (ptr.info == dato)
                    {
                        resultado = true;
                        aux.sig = ptr.sig;
                        break;
                    }
                    aux = ptr;
                    ptr = ptr.sig;
                }
            }
            Console.WriteLine("{0} ENCONTRO", resultado ? "SI" : "NO");
            Recorrido();

        }
        public void Ordenar(string ordenarPor)
        {
            ptr = raiz;
            while (ptr != null)
            {
                aux = raiz;
                while (aux != null)
                {
                    if (ordenarPor == "asc")
                    {
                        if (ptr.info > aux.info)
                        {
                            int temp = ptr.info;
                            ptr.info = aux.info;
                            aux.info = temp;
                        }
                    } else if (ordenarPor == "desc")
                    {
                        if (ptr.info < aux.info)
                        {
                            int temp = ptr.info;
                            ptr.info = aux.info;
                            aux.info = temp;
                        }
                    }
                    
                    aux = aux.sig;
                }
                ptr = ptr.sig;
            }
        }
    }
}
