//@BaseCode
using Microsoft.EntityFrameworkCore;
using SmartNQuick.Contracts;
using SmartNQuick.Logic.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SmartNQuick.Logic.Contracts
{
    internal partial interface IContext : IDisposable
    {
        DbSet<E> Set<C, E>()
            where C : SmartNQuick.Contracts.IIdentifiable
            where E : Entities.IdentityEntity, C, new();

        public Task<int> CountAsync<C, E>()
            where C : IIdentifiable
            where E : IdentityEntity, C;

        Task<int> CountByAsync<C, E>(string predicate)
            where C : IIdentifiable
            where E : IdentityEntity, C;

        Task<E> GetByIdAsync<C, E>(int id)
            where C : IIdentifiable
            where E : IdentityEntity, C;

        Task<IEnumerable<E>> GetAllAsync<C, E>()
            where C : IIdentifiable
            where E : IdentityEntity, C;

        Task<int> SaveChangesAsync();
    }
}
