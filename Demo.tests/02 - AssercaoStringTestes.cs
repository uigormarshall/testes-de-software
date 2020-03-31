using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Demo.tests
{
    public class AssercaoStringTestes
    {
        private string _nome = "Uigor";
        private string _sobrenome = "Marshall";

        [Fact]
        public void UnirStrings_RetornarStringUnida()
        {
            //Arrange
           
            //Act
            var stringUnida = StringTools.Unir(_nome, _sobrenome);
            
            //Assert
            Assert.Equal("Uigor Marshall", stringUnida);
        }

        [Fact]
        public void UnirStrings_RetornarStringUnidasIgnorandoCase()
        {
            //Arrange
           
            //Act
            var stringUnida = StringTools.Unir(_nome, _sobrenome);
            
            //Assert
            Assert.Equal("UIGOR MARSHAll", stringUnida, true);
        }

        [Fact]
        public void UnirStrings_DeveConterTrecho()
        {
            //Arrange

            //Act
            var stringUnida = StringTools.Unir(_nome, _sobrenome);

            //Assert
            Assert.Contains("shall", stringUnida);
        }

        [Fact]
        public void UnirStrings_DeveComecarCom()
        {
            //Arrange

            //Act
            var stringUnida = StringTools.Unir(_nome, _sobrenome);

            //Assert
            Assert.StartsWith("Uig", stringUnida);
        }


        [Fact]
        public void UnirStrings_DeveAcabarCom()
        {
            //Arrange

            //Act
            var stringUnida = StringTools.Unir(_nome, _sobrenome);

            //Assert
            Assert.EndsWith("all", stringUnida);
        }

        [Fact]
        public void UnirStrings_ValidarExpressoRegular()
        {
            //Arrange

            //Act
            var stringUnida = StringTools.Unir(_nome, _sobrenome);

            //Assert
            Assert.Matches("[A-Z]{1}[a-z]+ [A-Z]{1}[a-z]+", stringUnida);
        }
    }
}
