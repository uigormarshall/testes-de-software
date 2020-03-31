using Xunit;

namespace Demo.tests
{
    public class AssercaoNulloOuBooleanoTestes
    {
        [Fact]
        public void Funcionario_Nome_NaoDeveSerNulloOuVazio()
        {
            // Arrange & Act
            var funcionario = new Funcionario("", 1000);

            // Assert
            Assert.False(string.IsNullOrEmpty(funcionario.Nome));
        }

        [Fact]
        public void Funcionario_Apelido_NaoDeverPossuir()
        {
            // Arrange & Act
            var funcionario = new Funcionario("Uigor Marshall", 1000);

            // Assert
            Assert.Null(funcionario.Apelido);

            // Assert Bool
            Assert.True(string.IsNullOrEmpty(funcionario.Apelido));
            Assert.False(funcionario.Apelido?.Length > 0);
        }
    }
}
