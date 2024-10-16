using DesafioConsole.services;

namespace desafiotests;

public class ValidacoesListaTests
{
    ValidacoesLista validacoes = new ValidacoesLista();

    [Fact]
    public void DeveRemoverNumerosNegativos()
    {
        //Arrange
        List<int> lista = new List<int>{5, -1, -8, 9};
        List<int> resultadoEsperado = new List<int>{5, 9};

        //Act
        List<int> resultado = validacoes.RemoverNumerosNegativos(lista);

        //Assert
        Assert.Equal(resultadoEsperado, resultado);
    }

    [Fact]
    public void DeveConterONumero9NaLista()
    {
        //Arrange
        List<int> lista = new List<int>{5, -1, -8, 9};
        int numProcurado = 9;

        //Act
        bool resultado = validacoes.ListaContemDeterminadoNumero(lista, numProcurado);

        //Assert
        Assert.True(resultado);
    }

    [Fact]
    public void NaoDeveConterONumero10NaLista()
    {
        //Arrange
        List<int> lista = new List<int>{5, -1, -8, 9};
        int numProcurado = 10;

        //Act
        bool resultado = validacoes.ListaContemDeterminadoNumero(lista, numProcurado);

        //Assert
        Assert.False(resultado);
    }

    [Fact]
    public void DeveMultiplicarOsNumerosDaListaPor2()
    {
        //Arrange
        List<int> lista = new List<int>{5, -1, -8, 9};
        int multiplicador = 2;
        List<int> resultadoEsperado = new List<int>{10, -2, -16, 18};

        //Act
        List<int> resultado = validacoes.MultiplicarNumerosDaLista(lista, multiplicador);

        //Assert
        Assert.Equal(resultadoEsperado, resultado);
    }

    [Fact]
    public void DeveEncontrarOMaiorNumeroDaLista()
    {
        //Arrange
        List<int> lista = new List<int>{5, -1, -8, 9};
        int resultadoEsperado = 9;

        //Act
        int resultado = validacoes.MaiorNumeroDaLista(lista);

        //Assert
        Assert.Equal(resultadoEsperado, resultado);
    }

    [Fact]
    public void DeveEncontrarOMenorNumeroDaLista()
    {
        //Arrange
        List<int> lista = new List<int>{5, -1, -8, 9};
        int resultadoEsperado = -8;

        //Act
        int resultado = validacoes.MenorNumeroDaLista(lista);
        
        //Assert
        Assert.Equal(resultadoEsperado, resultado);
    }
}