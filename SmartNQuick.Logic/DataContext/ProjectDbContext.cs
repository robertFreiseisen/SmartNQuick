//@BaseCode
using Microsoft.EntityFrameworkCore;
using SmartNQuick.Contracts;
using SmartNQuick.Logic.Entities;
using System.Threading.Tasks;
using System.Linq.Dynamic.Core;
using System.Linq;
using System.Collections.Generic;

namespace SmartNQuick.Logic.DataContext
{
    internal partial class ProjectDbContext : DbContext, Contracts.IContext
    {
        protected ProjectDbContext()
        {

        }

        public DbSet<E> Set<C, E>()
            where C : IIdentifiable
            where E : IdentityEntity, C, new()
        {
            throw new System.NotImplementedException();
        }

        public Task<int> CountAsync<C, E>()
            where C : IIdentifiable
            where E : IdentityEntity, C
        {
            return Set<E>().CountAsync();
        }
        public Task<int> SaveChangesAsync()
        {
            return SaveChangesAsync();
        }

        public Task<int> CountByAsync<C, E>(string predicate)
            where C : IIdentifiable
            where E : IdentityEntity, C
        {
            return Set<E>().Where(predicate).CountAsync();
        }

        public Task<E> GetByIdAsyn<C, E> (int id)
            where C : IIdentifiable
            where E: IdentityEntity, C
        {
            return Set<E>().FindAsync(id).AsTask();
        }

        public Task<IEnumerable<C>> GetAllAsync<C, E>()
            where C : IIdentifiable
            where E : IdentityEntity, C
        {
            return Set<E>().AllAsync<C>().AsTask();
        }

        public Task<C> GetByIdAsync<C, E>(int id)
            where C : IIdentifiable
            where E : IdentityEntity, C
        {
            throw new System.NotImplementedException();
        }
    }
}
