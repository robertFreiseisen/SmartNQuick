﻿using CommonBase.Attributes;

namespace SmartNQuick.Contracts.Persistence.MusicStore
{
    [ContractInfo(ContextType = ContextType.Table)]
    public interface IGenre : IVersionable, ICopyable<IGenre>
    {
        [ContractPropertyInfo(Required = true, MaxLength = 128, IsUnique = true)]
        public string Name { get; set; }
    }
}
