using System.Linq;
using Game.Sources.Services.MonstersCollectionService;
using Game.Sources.UI.Base;
using UnityEngine;
using Zenject;

namespace Game.Sources.UI.CollectionScreen
{
    public class CollectionScreen : UIElement
    {
        [Inject]
        private void Construct(IMonstersCollectionService monstersCollectionService)
        {
            _monstersCollectionService = monstersCollectionService;
        }
        
        public override UIElementType UIElementType => UIElementType.CollectionScreen;

        [SerializeField] private MonsterCardsContent monsterCardsContent;

        private IMonstersCollectionService _monstersCollectionService;
        
        protected override void OnShow(object obj)
        {
            var unlockedMonster = _monstersCollectionService.MonsterCards.Where(monster => monster.IsUnlocked).ToList();
            monsterCardsContent.Show(unlockedMonster);
        }

        protected override void OnHide()
        {
            monsterCardsContent.Hide();
        }
    }
}