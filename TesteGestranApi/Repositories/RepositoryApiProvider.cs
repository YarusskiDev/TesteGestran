using TesteGestranApi.ContextEntity;
using TesteGestranApi.Interfaces.Repositories;
using TesteGestranApi.Models;

namespace TesteGestranApi.Repositories
{
    public class RepositoryApiProvider : RepositorioBase<Provider>, IRepositoryApiProvider
    {
        public RepositoryApiProvider(ContextEntityFrame db) : base(db)
        {
        }
    }
}
