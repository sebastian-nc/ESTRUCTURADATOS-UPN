using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SEMANA3
{
    internal class Program
    {


        static void Main(string[] args)
        {

            Stack<int> Salida = new Stack<int>();
            Stack<string> Oper = new Stack<string>();

            int Prioridad(string oper)
            {

                if (oper == "*" || oper == "/")
                {
                    return 2;
                }
                else if (oper == "+" || oper == "-") {
                    return 1;
                }

                return 0;
            }


            string expresion1 = "a + b * c";
            string expresion2 = "(a + b) * c";
            string expresion3 = "a + (b * c)";

            int val1 = 2;
            int val2 = 5;
            int val3 = 3;


            string ReemplazarValor(string expr, int valor1, int valor2, int valor3)
            {

                string expresion = "";

                for (int i = 0; i < expr.Length; i++)
                {
                    string elemento = expr[i].ToString();
                    if (elemento == "a") {
                        expresion += valor1;
                    }
                    else if (elemento == "b") {
                        expresion += valor2;
                    }
                    else if (elemento == "c") {
                        expresion += valor3;
                    }
                    else
                    {
                        expresion += elemento;
                    }
                }
                
                return expresion;
            }

            string InfijaASufija(string expresion)
            {
                string operacion = "";
                for (int i = 0; i < expresion.Length; i++)
                {
                    string elemento = expresion[i].ToString();
                    if (elemento == " ") continue;

                    if (int.TryParse(elemento, out int valor))
                    {
                        operacion += valor + " ";
                    }

                    if (elemento == "(")
                    {
                        Oper.Push(elemento);
                    }

                    if (elemento == ")")
                    {
                        string op = Oper.Pop();
                        while (op != "(")
                        {
                            operacion += op + " ";
                            op = Oper.Pop();
                        }
                    }

                    if (elemento == "+" || elemento == "-" || elemento == "*" || elemento == "/")
                    {
                        while (Oper.Count > 0 && Oper.Peek() != "(" && Prioridad(Oper.Peek()) >= Prioridad(elemento))
                        {
                            operacion += Oper.Pop() + " ";
                        }

                        Oper.Push(elemento);
                    }

                }

                while (Oper.Count > 0)
                {
                    operacion += Oper.Pop() + " ";
                }

                return operacion;
            }


            int OperarASufija(string operacion)
            {
                string[] elementos = operacion.Split(' ');

                // leer la operacion
                foreach (var elemento in elementos)
                {
                    if (elemento == "+" || elemento == "-" || elemento == "*" || elemento == "/")
                    {
                        int valor1 = Salida.Pop();
                        int valor2 = Salida.Pop();

                        if (elemento == "+")
                        {
                            Salida.Push(valor2 + valor1);
                        }
                        else if (elemento == "-")
                        {
                            Salida.Push(valor2 - valor1);
                        }
                        else if (elemento == "*")
                        {
                            Salida.Push(valor2 * valor1);
                        }
                        else if (elemento == "/")
                        {
                            Salida.Push(valor2 / valor1);
                        }
                    }
                    else
                    {
                        if (int.TryParse(elemento, out int valor))
                        {
                            Salida.Push(valor);
                        }
                    }
                }

                return Salida.First();
            }

            Console.WriteLine(InfijaASufija("2 + 5 * 3"));
            Console.WriteLine(InfijaASufija("(2 + 5) * 3"));
            Console.WriteLine(InfijaASufija("2 + (5 * 3)"));

            Console.WriteLine(OperarASufija(InfijaASufija(ReemplazarValor(expresion1, val1, val2, val3))));
            Console.WriteLine(OperarASufija(InfijaASufija(ReemplazarValor(expresion2, val1, val2, val3))));
            Console.WriteLine(OperarASufija(InfijaASufija(ReemplazarValor(expresion3, val1, val2, val3))));

        }
    }
}
