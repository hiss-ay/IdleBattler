using System.Collections.Generic;
using Runtime._Game.Sources.Runtime.Data.MonsterCard;

namespace Runtime._Game.Sources.Runtime.Services.MonstersCollectionService
{
    public interface IMonstersCollectionService
    {
        public void Initialize();
        public List<MonsterCard> MonsterCards { get; }
    }
}