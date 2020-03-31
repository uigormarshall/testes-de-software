using Xunit;

namespace Demo.tests
{
    public class AssercaoColecoesTestes
    {
        [Fact]
        public void Funcionario_Habilidades_NaoDevePossuirHabilidadesVazias()
        {
            // Arrange & Act
            var funcionario = FuncionarioFactory.Criar("Emilly S. Fonseca", 1000);

            // Assert
            Assert.All(funcionario.Habilidades, habilidade => Assert.False(string.IsNullOrWhiteSpace(habilidade)));
        }

        [Fact]
        public void Funcionario_Habilidades_JuniorNaoDevePossuirHabilidadesAvancadas()
        {
            // Arrange & Act
            var funcionario = FuncionarioFactory.Criar("Emilly S. Fonseca", 1000);

            // Assert
            Assert.DoesNotContain("Microservices", funcionario.Habilidades);
        }

        [Fact]
        public void Funcionario_Habilidades_SeniorDevePossuirTodasHabilidades()
        {
            // Arrange & Act
            var funcionario = FuncionarioFactory.Criar("Efraim Santana", 9000);

            var habilidadesAvancadas = new[]
            {
                "Lógica de Programação",
                "POO",
                "Testes",
                "Microservices"
            };
            // Assert
            Assert.Equal(habilidadesAvancadas, funcionario.Habilidades);
        }
    }
}
