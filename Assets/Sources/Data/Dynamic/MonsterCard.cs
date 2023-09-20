using Game.Sources.Data.Settings.MonsterSettings;

namespace Game.Sources.Data.Dynamic
{
    public class MonsterCard
    {
        public MonsterCard(MonsterSettings settings, MonsterData monsterData)
        {
            Settings = settings;
            Data = monsterData;
        }
        
        public MonsterSettings Settings { get; }
        public MonsterData Data { get; }

        public int ID => Settings.ID;
        public int Level => Data.level;
        public int Shards => Data.shards;
        public bool IsUnlocked => Data.level > 0;
        public bool CanLevelUp => Data.level < MaxLevel;
        private int MaxLevel = 30;
    }
}