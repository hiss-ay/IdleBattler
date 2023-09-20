using System;
using UnityEngine;

namespace Game.Sources.Data.Settings.MonsterSettings
{
    [Serializable]
    public class EvolutionSettings
    {
        [SerializeField] private SpellSettings spellSettings;
        [SerializeField] private MonsterEvolutionSkin monsterEvolutionSkin;
        [SerializeField] private GameObject prefab;

        public Sprite SpellIcon => spellSettings.Icon;
        public string SpellDescription => spellSettings.Description;
        
        public Sprite MonsterIcon => monsterEvolutionSkin.Icon;
        public string MonsterName => monsterEvolutionSkin.Name;

        public GameObject Prefab => prefab;
    }
}