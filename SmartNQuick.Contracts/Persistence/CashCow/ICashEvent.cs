using CommonBase.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartNQuick.Contracts.Persistence.CashCow
{
    [ContractInfo(ContextType = ContextType.Table)]
    public partial interface ICashEvent : IVersionable
    {
        [ContractPropertyInfo(Required = true, MaxLength = 256, IsUnique = true)]
        public string Title { get; set; }
        [ContractPropertyInfo(Required = true, MaxLength = 1024, IsUnique = true)]
        public string Description { get; set; }
        public string Currency { get; set; }
        public List<IParticipant> Participants { get; set; }
        [ContractPropertyInfo(Required = true, MaxLength = 64, IsUnique = true)]
        public string Category { get; set; }
    }
}
