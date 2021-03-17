//@BaseCode
using SmartNQuick.Logic.Contracts;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Collections.Generic;

namespace SmartNQuick.Logic.Controllers.Persistence
{
    internal abstract partial class GenericPersistenceController<C, E> : GenericController<C, E>
        where C : SmartNQuick.Contracts.IIdentifiable
        where E : Entities.IdentityEntity, C, new()
    {
        protected GenericPersistenceController(IContext context) : base(context)
        {
        }

        protected GenericPersistenceController(ControllerObject other) : base(other)
        {
        }

        public override Task<int> CountAsync()
        {
            return Context.Set<C, E>().CountAsync();
        }

        public override Task<int> CountByAsync(string predicate)
        {
            return Context.CountByAsync<C, E>(predicate);
        }

        protected virtual E BeforeReturn(E entity)
        {
            return entity;
        }

        public override async Task<C> GetByIdAsync(int id)
        {
            var result = await Context.GetByIdAsync<C, E>(id);
            
            BeforeReturn(result);
            return result;

        }
        public override async Task<IEnumerable<C>> GetAllAsync()
        {
            return (await Context.GetAllAsync<C, E>()
                                        .ConfigureAwait(false))
                                        .Select(e => BeforeReturn(e));

        }
    }
}
