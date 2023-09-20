using System;
using Game.Sources.Data.Dynamic;

namespace Game.Sources.Services.PersistentProgressService
{
    public interface IPersistentProgressService
    {
        public PlayerProgressData PlayerProgressData { get; }
        public int Coins { get; }
        public int Level { get; }
        public Action<int> OnLevelUp { get; set; }
        public Action<int> OnCoinsAdded { get; set; }
        public void SetProgress(PlayerProgressData playerProgressData);
        public void AddCoins(int amount);
        public void LevelUp();
        public MonsterData GetMonsterDataByID(int id);
    }
}