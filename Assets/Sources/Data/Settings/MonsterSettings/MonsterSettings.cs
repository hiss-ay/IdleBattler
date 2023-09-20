using UnityEngine;

namespace Game.Sources.Data.Settings.MonsterSettings
{
    [CreateAssetMenu(fileName = "MonsterSettings", menuName = "Settings/MonsterSettings")]
    public class MonsterSettings : ScriptableObject
    {
        [SerializeField] private int id;
        [SerializeField] private EvolutionSettings[] evolutionSettings;
        [SerializeField] private Stats stats;
        [SerializeField] private AttackSettings attackSettings;
        [SerializeField] private LevelUpgradeCost levelUpgradeCost;

        public int ID => id;

        public int Health(int level) => stats.Health(level);
        public int Damage(int level) => stats.Damage(level);
        public float Cooldown => stats.Cooldown;
        public float MoveSpeed => stats.MoveSpeed;

        public Sprite AttackIcon => attackSettings.Icon;
        public float AttackRange => attackSettings.AttackRange;

        public int GetCost(int level) => levelUpgradeCost.GetCost(level);
        
        public EvolutionSettings GetEvolutionData(int level)
        {
            var evolutionIndex = level % 10 + 1;
            return evolutionSettings[Mathf.Clamp(evolutionIndex, 0, evolutionSettings.Length - 1)];
        }
    }
}
