using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using TesteGestranApi.ContextEntity;
using TesteGestranApi.Interfaces.Repositories;
using TesteGestranApi.Models;

namespace TesteGestranApi.Repositories
{
    public class RepositorioBase<Tentity> : IRepositoryBase<Tentity> where Tentity : Entity, new()
    {
        protected readonly ContextEntityFrame _Db;
        protected readonly DbSet<Tentity> _DbSet;
        public RepositorioBase(ContextEntityFrame db)
        {
            _Db = db;
            _DbSet = db.Set<Tentity>();
        }
        public async Task Adicionar(Tentity entidade)
        {
            _DbSet.Add(entidade);
            await SaveChanges();
        }

        public async Task Atualizar(Tentity entidade)
        {
            _DbSet.Update(entidade);
            await SaveChanges();
        }

        public async Task<Tentity> ObterPorId(int id)
        {
            return await _DbSet.FindAsync(id);
        }

        public async Task<List<Tentity>> ObterTodos()
        {
            return await _DbSet.ToListAsync();
        }

        public async Task Remover(int id)
        {
            
                _DbSet.Remove(new Tentity { Id = id });
                await SaveChanges();          
        }

        public async Task<int> SaveChanges()
        {
            return await _Db.SaveChangesAsync();
        }
      
    }
}

