using System;
using Xunit;

namespace UnityTests
{
    public class CalculadoraTests
    {
        [Fact]
        public void Somar()
        {
            var calculadora = new CalculadoraLib.Calculadora();
            var resultado = calculadora.Somar(1, 2);
            Assert.Equal(3, resultado);
        }

        [Fact]
        public void Subtrair()
        {
            var calculadora = new CalculadoraLib.Calculadora();
            var resultado = calculadora.Subtrair(1, 2);
            Assert.Equal(-1, resultado);
        }

        [Fact]
        public void Multiplicar()
        {
            var calculadora = new CalculadoraLib.Calculadora();
            var resultado = calculadora.Multiplicar(1, 2);
            Assert.Equal(2, resultado);
        }

        [Fact]
        public void Dividir()
        {
            var calculadora = new CalculadoraLib.Calculadora();
            var resultado = calculadora.Dividir(1, 2);
            Assert.Equal(0, resultado);
        }
    }
}
