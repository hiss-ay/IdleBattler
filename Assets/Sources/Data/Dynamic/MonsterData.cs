using System;

namespace Game.Sources.Data.Dynamic
{
    public class MonsterData
    {
        public int ID { get; private set; } = -1;
        public int Level { get; private set; }
        
        public event Action OnMonsterUpgraded;
        
        public void Upgrade()
        {
            Level++;
            OnMonsterUpgraded?.Invoke();
        }
    }
}