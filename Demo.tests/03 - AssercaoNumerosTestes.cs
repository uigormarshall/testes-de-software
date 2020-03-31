using Xunit;

namespace Demo.tests
{
    public class AssercaoNumerosTestes
    {
        [Fact]
        public void Somar_DeveSerIgual()
        {
            // Arrange
            var calculadora = new Calculadora();

            // Act
            var resultadoDaSoma = calculadora.Somar(1, 2);

            // Assert
            Assert.Equal(3, resultadoDaSoma);
        }

        [Fact]
        public void Somar_DeveNaoSerIgual()
        {
            // Arrange
            var calculadora = new Calculadora();

            // Act
            var resultadoDaSoma = calculadora.Somar(1.10, 2.21);

            // Assert
            Assert.NotEqual(3.3, resultadoDaSoma);
        }
    }
}
