using System.Collections.Generic;
using Game.Sources.Data.Dynamic;
using Game.Sources.Data.Settings.MonsterSettings;
using Game.Sources.Services.PersistentProgressService;

namespace Game.Sources.Services.MonstersCollectionService
{
    public class MonstersCollectionService : IMonstersCollectionService
    {
        public MonstersCollectionService(MonstersCollection monstersCollection,
            IPersistentProgressService persistentProgressService)
        {
            _monstersCollection = monstersCollection;
            _persistentProgressService = persistentProgressService;
        }
        
        private readonly MonstersCollection _monstersCollection;
        private readonly IPersistentProgressService _persistentProgressService;
        
        public List<MonsterCard> MonsterCards { get; private set; }

        public void Initialize()
        {
            MonsterCards = new List<MonsterCard>();
            
            foreach (var monsterSettings in _monstersCollection.MonsterSettings)
            {
                var monsterData = _persistentProgressService.GetMonsterDataByID(monsterSettings.ID) ?? 
                                  new MonsterData(monsterSettings.ID, -1, 0);
                var card = new MonsterCard(monsterSettings, monsterData);
                MonsterCards.Add(card);
            }
        }
    }
}