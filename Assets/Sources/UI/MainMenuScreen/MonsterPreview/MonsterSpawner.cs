using System.Collections;
using System.Linq;
using Game.Sources.Infrastructure.Factories.AbstractFactory;
using Game.Sources.Services.MonstersCollectionService;
using UnityEngine;
using Zenject;

namespace Game.Sources.UI.MainMenuScreen.MonsterPreview
{
    public class MonsterSpawner : MonoBehaviour
    {
        [Inject]
        private void Construct(IAbstractFactory abstractFactory, IMonstersCollectionService monstersCollectionService)
        {
            _abstractFactory = abstractFactory;
            _monstersCollectionService = monstersCollectionService;
        }
        
        [SerializeField] private int timer;

        private IAbstractFactory _abstractFactory;
        private IMonstersCollectionService _monstersCollectionService;
        
        private void Start()
        {
            StartCoroutine(Spawn());
        }

        private IEnumerator Spawn()
        {
            while (true)
            {
                var monsterCards = _monstersCollectionService.MonsterCards.Where(x => x.Evaluated).ToArray();
                var randomIndex = Random.Range(0, monsterCards.Length);
                var randomMonsterCard = monsterCards[randomIndex];
                var monsterInstance = _abstractFactory.CreateInstance(randomMonsterCard.Prefab, Vector3.zero);
                
                yield return new WaitForSeconds(timer);
                
                _abstractFactory.DestroyInstance(monsterInstance);
            }
        }
    }
}
