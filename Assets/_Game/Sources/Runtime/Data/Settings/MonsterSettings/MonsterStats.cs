using System;
using UnityEngine;

namespace Runtime._Game.Sources.Runtime.Data.Settings.MonsterSettings
{
    [Serializable]
    public class MonsterStats
    {
        [SerializeField] private ProgressiveStat health;
        [SerializeField] private ProgressiveStat damage;
        
        [SerializeField] private float cooldown;
        [SerializeField] private float moveSpeed;

        public int Health(int level) => health.GetValue(level);
        public int Damage(int level) => damage.GetValue(level);
        
        public float Cooldown => cooldown;
        public float MoveSpeed => moveSpeed;
    }
}