using TesteGestranApi.Interfaces.Repositories;
using TesteGestranApi.Interfaces.Service;
using TesteGestranApi.Models;

namespace TesteGestranApi.Services
{
    public class ServiceApiProvider : IServiceApiProvider
    {
        readonly IRepositoryApiProvider _repositoryProvider;
        public ServiceApiProvider(IRepositoryApiProvider repositoryProvider)
        {
            _repositoryProvider = repositoryProvider;
        }
        public Task Adicionar(Provider provider)
        {
           return _repositoryProvider.Adicionar(provider);
        }

        public Task Atualizar(Provider provider)
        {
            return _repositoryProvider.Atualizar(provider);
        }

        public Task Remover(int id)
        {
            return _repositoryProvider.Remover(id);
        }
    }
}
