using UnityEngine;

namespace Game.Sources.Data.Settings.MonsterSettings
{
    [CreateAssetMenu(fileName = "MonstersCollectionSettings", menuName = "MonstersCollectionSettings")]
    public class MonstersCollectionSettings : ScriptableObject
    {
        [SerializeField] private MonsterSettings[] monsterSettings;
        public MonsterSettings[] MonsterSettings => monsterSettings;
    }
}
