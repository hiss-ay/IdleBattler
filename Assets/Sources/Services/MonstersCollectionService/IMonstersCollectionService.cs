using System.Collections.Generic;
using Game.Sources.Data.Dynamic;

namespace Game.Sources.Services.MonstersCollectionService
{
    public interface IMonstersCollectionService
    {
        public List<MonsterCard> MonsterCards { get; }
        public void Initialize();
    }
}