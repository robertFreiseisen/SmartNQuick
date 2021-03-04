//@BaseCode

namespace SmartNQuick.Logic.Entities
{
    internal abstract partial class VersionEntity : IdentityEntity, SmartNQuick.Contracts.IVersionable
    {
        public byte[] RowVersion { get; set; }
    }
}
