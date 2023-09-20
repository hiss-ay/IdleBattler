using UnityEngine;

namespace Game.Sources.Data.Settings.MonsterSettings
{
    [CreateAssetMenu(fileName = "AttackSettings", menuName = "Settings/AttackSettings")]
    public class AttackSettings : ScriptableObject
    {
        [SerializeField] private Sprite icon;
        [SerializeField] private float attackRange;

        public Sprite Icon => icon;
        public float AttackRange => attackRange;
    }
}