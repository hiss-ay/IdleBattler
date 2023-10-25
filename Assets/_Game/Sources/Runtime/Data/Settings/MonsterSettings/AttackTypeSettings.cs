using UnityEngine;

namespace Runtime._Game.Sources.Runtime.Data.Settings.MonsterSettings
{
    [CreateAssetMenu(fileName = "AttackTypeSettings", menuName = "Settings/AttackTypeSettings")]
    public class AttackTypeSettings : ScriptableObject
    {
        [SerializeField] private Sprite icon;
        [SerializeField] private float attackRange;

        public Sprite Icon => icon;
        public float AttackRange => attackRange;
    }
}