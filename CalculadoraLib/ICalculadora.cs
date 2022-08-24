using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculadoraLib
{
    public interface ICalculadora
    {
        int Somar(int a, int b);
        int Subtrair(int a, int b);
        int Multiplicar(int a, int b);
        int Dividir(int a, int b);
    }
}