using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculadoraLib
{
    public interface ICalculadoraCientifica : ICalculadora
    {
        int Potencia(int a, int b);
        int Raiz(int a);
    }
}