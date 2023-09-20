using System.Collections.Generic;
using Game.Sources.Data.MonsterCard;
using Game.Sources.Data.Settings.MonsterSettings;
using Game.Sources.Services.PersistentProgressService;

namespace Game.Sources.Services.MonstersCollectionService
{
    public class MonstersCollectionService : IMonstersCollectionService
    {
        public MonstersCollectionService(MonstersCollectionSettings monstersCollectionSettings,
            IPersistentProgressService persistentProgressService)
        {
            _monstersCollectionSettings = monstersCollectionSettings;
            _persistentProgressService = persistentProgressService;
        }
        
        private readonly MonstersCollectionSettings _monstersCollectionSettings;
        private readonly IPersistentProgressService _persistentProgressService;
        
        public List<MonsterCard> MonsterCards { get; private set; }

        public void Initialize()
        {
            MonsterCards = new List<MonsterCard>();
            
            foreach (var monsterSettings in _monstersCollectionSettings.MonsterSettings)
            {
                var monsterData = _persistentProgressService.GetOrCreateMonsterDataByID(monsterSettings.ID);
                var card = new MonsterCard(monsterSettings, monsterData);
                MonsterCards.Add(card);
            }
        }
    }
}