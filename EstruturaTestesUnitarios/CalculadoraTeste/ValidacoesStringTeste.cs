using Calculadora.Services;

namespace CalculadoraTeste
{
    public class ValidacoesStringTeste
    {
        private ValidacoesStrings _validacoes;

        public ValidacoesStringTeste()
        {
            _validacoes = new ValidacoesStrings();
        }

        [Fact]
        public void DeveContar3CaracteresEmOlaERetornar3()
        {
            //Arrange
            string texto = "Ola";

            //Act
            int resultado = _validacoes.ContarCaracteres(texto);

            //Assert
            Assert.Equal(3, resultado);

        }
    }
}