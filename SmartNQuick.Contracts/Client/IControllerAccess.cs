//@BaseCode
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SmartNQuick.Contracts.Client
{
    public partial interface IControllerAccess<T> : IDisposable
        where T : IIdentifiable
    {
        #region Async-Methods
        public Task<int> CountAsync();
        public Task<int> CountByAsync(string predicate);
        public Task<T> GetByIdAsync(int id);
        public Task<IEnumerable<T>> GetAllAsync();
        public Task<IEnumerable<T>> QueryAllAsync(string predicate);
        public Task<T> CreateAsync(T entity);
        public Task<T> InsertAsync(T entity);
        public Task DeleteAsync(int id);
        public Task<int> SaveChagesAsync();
        #endregion
    }
}
