using SmartNQuick.Contracts.Persistence.CashCow;
using System.Collections.Generic;

namespace SmartNQuick.Logic.Entities.CashCow
{
    partial class CashEvent : VersionEntity, ICashEvent
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Currency { get; set; }
        public List<IParticipant> Participants { get; set; }
        public string Category { get; set; }
    }
}
