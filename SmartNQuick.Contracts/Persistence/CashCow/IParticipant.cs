using CommonBase.Attributes;

namespace SmartNQuick.Contracts.Persistence.CashCow
{
    [ContractInfo(ContextType = ContextType.Table)]
    public partial interface IParticipant : IVersionable
    {
        [ContractPropertyInfo(Required = true)]
        public string Name { get; set; }
    }
}