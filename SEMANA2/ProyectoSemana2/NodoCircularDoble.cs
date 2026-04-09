using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSemana2
{
    internal class NodoCircularDoble
    {
        public NodoCircularDoble sig {  get; set; }
        public int info { get; set; }
        public NodoCircularDoble ant { get; set; }
    }
}
