using LojaApi.Models;

namespace LojaApi.Repositories;

public interface IProdutoRepository
{
    List<Produto> ObterTodos();
    Produto? ObterPorId(int id);
    void Adicionar(Produto produto);
}