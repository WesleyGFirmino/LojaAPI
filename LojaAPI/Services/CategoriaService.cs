using LojaApi.Models;
using LojaApi.Repositories;

namespace LojaApi.Services;

public class CategoriaService
{
    private readonly ICategoriaRepository _repository;

    public CategoriaService(ICategoriaRepository repository)
    {
        _repository = repository;
    }

    public List<Categoria> Listar()
    {
        return _repository.ObterTodas();
    }

    public void Criar(Categoria categoria)
    {
        _repository.Adicionar(categoria);
    }
}