using UnityEngine;

namespace Game.Sources.Data.Settings.MonsterSettings
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

        public Sprite AttackIcon => attackTypeSettings.Icon;
        public float AttackRange => attackTypeSettings.AttackRange;

        public int GetCost(int level) => levelUpgradeCost.GetCost(level);
        
        public EvolutionSettings GetEvolutionData(int level)
        {
            var evolutionIndex = level > 0 ? level / 10 + 1 : 0;
            return evolutionSettings[Mathf.Clamp(evolutionIndex, 0, evolutionSettings.Length)];
        }
    }
}
