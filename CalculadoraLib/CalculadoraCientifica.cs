using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculadoraLib
{
    public class CalculadoraCientifica : ICalculadoraCientifica
    {
        public int Dividir(int a, int b)
        {
            return a / b;
        }

        public int Multiplicar(int a, int b)
        {
            return a * b;
        }

        public int Potencia(int a, int b)
        {
            return (int)Math.Pow(a, b);
        }

        public int Raiz(int a)
        {
            return (int)Math.Sqrt(a);
        }

        public int Somar(int a, int b)
        {
            return a + b;
        }

        public int Subtrair(int a, int b)
        {
            return a - b;
        }
    }
}