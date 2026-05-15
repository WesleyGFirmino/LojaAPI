using LojaApi.Models;
using LojaApi.Repositories;

namespace LojaApi.Services;

public class ProdutoService
{
    private readonly IProdutoRepository _repository;

    public ProdutoService(IProdutoRepository repository)
    {
        _repository = repository;
    }

    public List<Produto> Listar()
    {
        return _repository.ObterTodos();
    }

    public void Criar(Produto produto)
    {
        _repository.Adicionar(produto);
    }
}