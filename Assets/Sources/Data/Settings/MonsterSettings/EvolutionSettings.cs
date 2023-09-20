using System;
using UnityEngine;

namespace Game.Sources.Data.Settings.MonsterSettings
{
    [Serializable]
    public class EvolutionSettings
    {
        [SerializeField] private SpellSettings spellSettings;
        [SerializeField] private MonsterSkin monsterSkin;
        [SerializeField] private GameObject prefab;

        public Sprite SpellIcon => spellSettings.Icon;
        public string SpellDescription => spellSettings.Description;
        
        public Sprite MonsterIcon => monsterSkin.Icon;
        public string MonsterName => monsterSkin.Name;

        public GameObject Prefab => prefab;
    }
}