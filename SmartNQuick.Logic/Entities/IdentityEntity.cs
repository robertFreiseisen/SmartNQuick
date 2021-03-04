//@BaseCode

namespace SmartNQuick.Logic.Entities
{
    abstract partial class IdentityEntity : SmartNQuick.Contracts.IIdentifiable
    {
        public int Id { get; set; }
    }
}
