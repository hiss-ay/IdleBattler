using System;
using Game.Sources.Data.Dynamic;
using Game.Sources.Data.Settings.MonsterSettings;
using UnityEngine;

namespace Game.Sources.Data.MonsterCard
{
    public class MonsterCard
    {
        public MonsterCard(MonsterSettings settings, MonsterData monsterData)
        {
            _settings = settings;
            _data = monsterData;
        }

        private readonly MonsterSettings _settings;
        private readonly MonsterData _data;

        public int ID => _settings.ID;

        public Sprite Icon => _settings.GetEvolutionData(_data.level).MonsterIcon;
        public string Name => _settings.GetEvolutionData(_data.level).MonsterName;
        public Sprite AttackTypeIcon => _settings.AttackIcon;
        public GameObject Prefab => _settings.GetEvolutionData(_data.level).Prefab;
        public int EvolutionCardRequired => _settings.GetEvolutionCardRequired(EvolutionIndex);
        public int Level => _data.level;
        public int Shards => _data.shards;
        public bool IsUnlocked => _data.level > -1;
        public bool Evaluated => _data.level > 0;
        public bool CanLevelUp => _data.level < MaxLevel;
        public int MaxLevel => 30;
        public int EvolutionIndex => Evaluated ? Level / 10 + 2 : 1;
        public event Action OnShardsAdded;
        public event Action OnLevelUp;
        
        public void AddShards(int amount)
        {
            _data.shards += amount;
            OnShardsAdded?.Invoke();
        }
        
        public void LevelUp()
        {
            _data.level++;
            OnLevelUp?.Invoke();
        }
    }
}