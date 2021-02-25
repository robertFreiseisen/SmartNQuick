using System;
using SmartNQuick.Contracts.Persistence.CashCow;
namespace SmartNQuick.Logic.Entities.CashCow
{
    partial class Participant : VersionEntity, IParticipant
    {
        public string Name { get; set; }
    }
}
