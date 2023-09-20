using UnityEngine;

namespace Game.Sources.Data.Settings.MonsterSettings
{
    [CreateAssetMenu(fileName = "MonstersCollection", menuName = "MonstersCollection")]
    public class MonstersCollection : ScriptableObject
    {
        [SerializeField] private MonsterSettings[] monsterSettings;
        public MonsterSettings[] MonsterSettings => monsterSettings;
    }
}
