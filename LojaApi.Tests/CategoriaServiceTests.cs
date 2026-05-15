using LojaApi.Models;
using LojaApi.Repositories;
using LojaApi.Services;
using Moq;

namespace LojaApi.Tests;

public class CategoriaServiceTests
{
    [Fact]
    public void Deve_Listar_Categorias()
    {
        var categorias = new List<Categoria>
        {
            new Categoria { Id = 1, Nome = "Eletrônicos" }
        };

        var repositoryMock = new Mock<ICategoriaRepository>();

        repositoryMock
            .Setup(r => r.ObterTodas())
            .Returns(categorias);

        var service = new CategoriaService(repositoryMock.Object);

        var resultado = service.Listar();

        Assert.Single(resultado);
        Assert.Equal("Eletrônicos", resultado[0].Nome);
    }
}