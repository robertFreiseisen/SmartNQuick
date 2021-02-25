using System;
using CommonBase.Attributes;

namespace SmartNQuick.Contracts.Persistence.CashCow
{
    [ContractInfo(ContextType = ContextType.Table)]
    public partial interface IPayment : IVersionable 
    {
        public DateTime Date { get; set; }
        public IParticipant Participant { get; set; }
        public double Amount { get; set; }
        [ContractPropertyInfo(Required = true, MaxLength = 256, IsUnique = true)]
        public string Title { get; set; }
    }
}
