using System.Collections.Generic;
using Runtime._Game.Sources.Runtime.Data.MonsterCard;
using Runtime._Game.Sources.Runtime.Data.Settings.MonsterSettings;
using Runtime._Game.Sources.Runtime.Services.PersistentProgressService;

namespace Runtime._Game.Sources.Runtime.Services.MonstersCollectionService
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