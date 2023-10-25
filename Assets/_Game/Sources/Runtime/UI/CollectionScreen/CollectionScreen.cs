using System.Linq;
using Runtime._Game.Sources.Runtime.Services.MonstersCollectionService;
using Runtime._Game.Sources.Runtime.UI.Base;
using UnityEngine;
using Zenject;

namespace Runtime._Game.Sources.Runtime.UI.CollectionScreen
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