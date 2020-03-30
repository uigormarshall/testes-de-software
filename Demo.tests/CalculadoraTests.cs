using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Demo.tests
{
    public class CalculadoraTests
    {
        [Fact]
        public void Somar_RetorvarValorSoma()
        {
            // Arrange
            var calculadora = new Calculadora();

            // Act
            var resultado = calculadora.Somar(2, 2);

            // Assert
            Assert.Equal(41, resultado);
        }
    }
}
