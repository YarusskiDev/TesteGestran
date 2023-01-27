using TesteGestranApi.Models;

namespace TesteGestranApi.Interfaces.Service
{
    public interface IServiceApiProvider
    {
        Task Adicionar(Provider provider);
        Task Atualizar(Provider provider);
        Task Remover(int id);
    }
}
