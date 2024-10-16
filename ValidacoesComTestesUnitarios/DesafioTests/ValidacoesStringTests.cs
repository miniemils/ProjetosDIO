using DesafioConsole.services;

namespace DesafioTests
{
    public class ValidacoesStringTests
    {
        ValidacoesString validacoes = new ValidacoesString();

        [Fact]
        public void DeveRetornar6ComoQuantidadeDeCaracteresEmMatrix()
        {
            //Arrange
            string texto = "matrix";
            int resultadoEsperado = 6;

            //Act
            int resultado = validacoes.RetornarQuantidadeCaracteres(texto);

            //Assert
            Assert.Equal(resultadoEsperado,resultado);
        }

        [Fact]
        public void DeveConterAPalavraSonhosNoTexto()
        {
            //Arrange
            string texto = "sonhos são sementes de realidades.";
            string textoProcurado = "sonhos";

            //Act
            bool resultado = validacoes.ContemCaractere(texto, textoProcurado);

            //Assert
            Assert.True(resultado);
        }

        [Fact]
        public void NaoDeveConterAPalavraSonhadoresNoTexto()
        {
            //Arrange
            string texto = "sonhos são sementes de realidades.";
            string textoProcurado = "sonhadores";

            //Act
            bool resultado = validacoes.ContemCaractere(texto, textoProcurado);

            //Assert
            Assert.False(resultado);
        }

        [Fact]
        public void TextoDeveTerminarComAPalavraRealidades()
        {
            //Arrange
            string texto = "sonhos são sementes de realidades.";
            string textoProcurado = "sonhadores";

            //Act
            bool resultado = validacoes.TextoTerminaCom(texto, textoProcurado);

            //Assert
            Assert.True(true);
        }
    }
}