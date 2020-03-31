using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Demo.tests
{
    public class AssercaoTiposObjetosTestes
    {
        [Fact]
        public void FuncionarioFactory_Criar_DeveRetornoUmObjetoDoTipoFuncionario()
        {
            // Assert & Act
            var funcionario = FuncionarioFactory.Criar("Rafaela Leal", 2000);

            // Assert
            Assert.IsType<Funcionario>(funcionario);
        }

        [Fact]
        public void FuncionarioFactory_Criar_DeveRetornoUmObjetoDerivadoDePessoa()
        {
            // Assert & Act
            var funcionario = FuncionarioFactory.Criar("Rafaela Leal", 2000);

            // Assert
            Assert.IsAssignableFrom<Pessoa>(funcionario);
        }
    }
}
