//@BaseCode

namespace SmartNQuick.Contracts
{
    public partial interface IVersionable : IIdentifiable
    {
        public byte[] RowVerson { get; set; }
    }
}
