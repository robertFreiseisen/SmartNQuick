using CommonBase.Extensions;
using SmartNQuick.Contracts.Persistence.MusicStore;

namespace SmartNQuick.Logic.Entities.MusicStore
{
    class Genre : VersionEntity, Contracts.Persistence.MusicStore.IGenre
    {
        public string Name { get; set; }

        public void CopyProperties(IGenre other)
        {
            other.CheckArgument(nameof(other));

            Id = other.Id;
            RowVerson = other.RowVerson;
            Name = other.Name;
        }
    }
}
