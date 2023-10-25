using UnityEngine;

namespace Runtime._Game.Sources.Runtime.Data.Settings.MonsterSettings
{
    [CreateAssetMenu(fileName = "MonsterSettings", menuName = "Settings/MonsterSettings")]
    public class MonsterSettings : ScriptableObject
    {
        [SerializeField] private int id;
        [SerializeField] private EvolutionSettings[] evolutionSettings;
        [SerializeField] private MonsterStats monsterStats;
        [SerializeField] private AttackTypeSettings attackTypeSettings;
        [SerializeField] private LevelUpgradeCost levelUpgradeCost;
        
        public int ID => id;
        public int Health(int level) => monsterStats.Health(level);
        public int Damage(int level) => monsterStats.Damage(level);
        public float Cooldown => monsterStats.Cooldown;
        public float MoveSpeed => monsterStats.MoveSpeed;
        public int GetEvolutionCardRequired(int index) => GetEvolutionData(index).CardRequired;
        public Sprite AttackIcon => attackTypeSettings.Icon;
        public float AttackRange => attackTypeSettings.AttackRange;
        public int GetCost(int level) => levelUpgradeCost.GetCost(level);

        public EvolutionSettings GetEvolutionData(int index)
        {
            return evolutionSettings[Mathf.Clamp(index, 0, evolutionSettings.Length-1)];
        }
    }
}
