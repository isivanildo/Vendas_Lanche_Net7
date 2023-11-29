using LanchesMvc.Models;

namespace LanchesMvc.Repositories.Interfaces
{
    public interface ICategoriaRepository
    {
        IEnumerable<Categoria> Catgegorias { get; }
    }
}
