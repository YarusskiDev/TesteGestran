using TesteGestranApi.ContextEntity;
using TesteGestranApi.Interfaces.Repositories;
using TesteGestranApi.Models;

namespace TesteGestranApi.Repositories
{
    public class RepositoryApiAdress : RepositorioBase<Adress>, IRepositoryApiAdress
    {
        public RepositoryApiAdress(ContextEntityFrame db) : base(db)
        {
        }
    }
}
