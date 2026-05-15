using LojaApi.Models;

namespace LojaApi.Repositories;

public class CategoriaRepository : ICategoriaRepository
{
    private readonly List<Categoria> _categorias = new();

    public void Adicionar(Categoria categoria)
    {
        _categorias.Add(categoria);
    }

    public Categoria? ObterPorId(int id)
    {
        return _categorias.FirstOrDefault(c => c.Id == id);
    }

    public List<Categoria> ObterTodas()
    {
        return _categorias;
    }
}