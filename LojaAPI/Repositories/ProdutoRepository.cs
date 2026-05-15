using LojaApi.Models;

namespace LojaApi.Repositories;

public class ProdutoRepository : IProdutoRepository
{
    private readonly List<Produto> _produtos = new();

    public void Adicionar(Produto produto)
    {
        _produtos.Add(produto);
    }

    public Produto? ObterPorId(int id)
    {
        return _produtos.FirstOrDefault(p => p.Id == id);
    }

    public List<Produto> ObterTodos()
    {
        return _produtos;
    }
}