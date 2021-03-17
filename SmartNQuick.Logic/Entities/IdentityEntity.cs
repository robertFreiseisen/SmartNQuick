//@BaseCode

using SmartNQuick.Contracts;
using System;

namespace SmartNQuick.Logic.Entities
{
    abstract partial class IdentityEntity : SmartNQuick.Contracts.IIdentifiable
    {
        public int Id { get; set; }

        internal void CopyProperties<C>(C entity) where C : IIdentifiable
        {
            throw new NotImplementedException();
        }
    }
}
