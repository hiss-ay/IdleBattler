using System.Collections.Generic;
using Game.Sources.Data.MonsterCard;

namespace Game.Sources.Services.MonstersCollectionService
{
    public interface IMonstersCollectionService
    {
        public void Initialize();
        public List<MonsterCard> MonsterCards { get; }
    }
}