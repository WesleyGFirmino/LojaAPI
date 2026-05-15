using LojaApi.Models;

namespace LojaApi.Repositories;

public interface ICategoriaRepository
{
    List<Categoria> ObterTodas();
    Categoria? ObterPorId(int id);
    void Adicionar(Categoria categoria);
}