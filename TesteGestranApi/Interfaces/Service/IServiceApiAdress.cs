using TesteGestranApi.Models;

namespace TesteGestranApi.Interfaces.Service
{
    public interface IServiceApiAdress
    {
        Task Adicionar(Adress provider);
        Task Atualizar(Adress provider);
        Task Remover(int id);
    }
}
