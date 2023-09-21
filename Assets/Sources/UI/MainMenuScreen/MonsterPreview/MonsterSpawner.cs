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
        
        [SerializeField] private int layerNumber;
        [SerializeField] private int timer;
        [SerializeField] private Transform parent;

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
                var monsterCard = _monstersCollectionService.MonsterCards.FirstOrDefault(x => x.IsUnlocked);
                if (monsterCard == null)
                    break;
                
                var monsterInstance = _abstractFactory.CreateInstance(monsterCard.Prefab, Vector3.zero);
                monsterInstance.transform.SetParent(parent);
                SetLayer(monsterInstance.transform);
                
                yield return new WaitForSeconds(timer);
                
                _abstractFactory.DestroyInstance(monsterInstance);
            }
        }
        
        private void SetLayer(Transform monsterTransform)
        {
            monsterTransform.gameObject.layer = layerNumber;
            foreach (Transform child in monsterTransform)
                child.gameObject.layer = layerNumber;
        }
    }
}
