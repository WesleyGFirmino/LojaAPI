using LojaApi.Models;
using LojaApi.Repositories;
using LojaApi.Services;
using Moq;

namespace LojaApi.Tests;

public class ProdutoServiceTests
{
    [Fact]
    public void Deve_Listar_Produtos()
    {
        var produtos = new List<Produto>
        {
            new Produto
            {
                Id = 1,
                Nome = "Notebook",
                Preco = 3500
            }
        };

        var repositoryMock = new Mock<IProdutoRepository>();

        repositoryMock
            .Setup(r => r.ObterTodos())
            .Returns(produtos);

        var service = new ProdutoService(repositoryMock.Object);

        var resultado = service.Listar();

        Assert.Single(resultado);
        Assert.Equal("Notebook", resultado[0].Nome);
    }
}