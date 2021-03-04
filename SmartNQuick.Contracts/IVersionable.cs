//@BaseCode

namespace SmartNQuick.Contracts
{
    public partial interface IVersionable : IIdentifiable
    {
        public byte[] RowVersion { get; set; }
    }
}
