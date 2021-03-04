using SmartNQuick.Contracts.Persistence.CashCow;

namespace SmartNQuick.Logic.Entities.CashCow
{
    internal partial class Participant : VersionEntity, IParticipant
    {
        public string Name { get; set; }
    }
}
