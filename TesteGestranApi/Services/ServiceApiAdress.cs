using TesteGestranApi.Interfaces.Repositories;
using TesteGestranApi.Interfaces.Service;
using TesteGestranApi.Models;

namespace TesteGestranApi.Services
{
    public class ServiceApiAdress : IServiceApiAdress
    {
        readonly IRepositoryApiAdress _repositoryAdress;

        public ServiceApiAdress(IRepositoryApiAdress repositoryAdress)
        {
            _repositoryAdress = repositoryAdress;
        }
        public Task Adicionar(Adress provider)
        {
            return _repositoryAdress.Adicionar(provider);
        }

        public Task Atualizar(Adress provider)
        {
            return _repositoryAdress.Atualizar(provider);
        }

        public Task Remover(int id)
        {
            return _repositoryAdress.Remover(id);
        }
    }
}
