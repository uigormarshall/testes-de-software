using System;
using Xunit;

namespace Demo.tests
{
    public class AssercaoExcecaoTestes
    {
        [Fact]
        public void Calculadora_Dividir_DeveRetornarErroDivisaoPorZero()
        {
            // Arrange
            var calculadora = new Calculadora();

            // Act & Assert
            Assert.Throws<DivideByZeroException>(() => calculadora.Dividir(10, 0));
        }

        [Fact]
        public void Funcionario_Salario_DeveRetornarErroSalarioInferiorAoPermitido()
        {
            // Arrange & Act & Assert
            var excecao = Assert.Throws<Exception>(() => FuncionarioFactory.Criar("João Vitor", 250));
            Assert.Equal("Salario inferior ao permitido", excecao.Message);
        }
    }
}
