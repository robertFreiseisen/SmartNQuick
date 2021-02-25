//@BaseCode

namespace SmartNQuick.Logic.Entities
{
    abstract partial class VersionEntity : IdentityEntity, Contracts.IVersionable
    {
        public byte[] RowVerson { get; set; }
    }
}
