using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Demo.tests
{
    public class CalculadoraTests
    {
        [Fact]
        public void Somar_RetornarValorSoma()
        {
            // Arrange
            var calculadora = new Calculadora();

            // Act
            var resultado = calculadora.Somar(2, 2);

            // Assert
            Assert.Equal(4, resultado);
        }

        [Theory]
        [InlineData(1, 1 ,2)]
        [InlineData(1, 2, 3)]
        [InlineData(1, 3, 4)]
        [InlineData(1, 5, 6)]
        [InlineData(500, 99, 599)]
        public void Somar_RetornarValoresSomados(double valor1, double valor2, double total)
        {
            // Arrange
            var calculadora = new Calculadora();

            // Act
            var resultado = calculadora.Somar(valor1, valor2);

            // Assert
            Assert.Equal(total, resultado);
        }
    }
}
