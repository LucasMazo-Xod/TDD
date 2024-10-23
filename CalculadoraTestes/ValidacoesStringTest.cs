using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Calculadora.Services;

namespace CalculadoraTestes
{
    public class ValidacoesStringTest 
    {
        private ValidacoesString _validacoes_stirng;

        public ValidacoesStringTest()
        {
            _validacoes_stirng = new ValidacoesString();
        }    
        [Fact]
        public void DeveContar3CaracteresEmOlaERetornar3()
        {
            // Arrange
            string palavra = "ola";

            //Act
            int result = _validacoes_stirng.ContarCaracteres(palavra);
            
            //Assert
            Assert.Equal(3, result);

        
        }
    }
}