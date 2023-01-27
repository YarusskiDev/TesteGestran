using TesteGestranApi.Models;

namespace TesteGestranApi.Interfaces.Repositories
{
    public interface IRepositoryBase<Tentity> where Tentity : Entity
    {
        public Task Adicionar(Tentity entidade);

        public Task Atualizar(Tentity entidade);

        public Task<Tentity> ObterPorId(int id);

        public Task<List<Tentity>> ObterTodos();

        public Task Remover(int id);

        public Task<int> SaveChanges();
    }
}
