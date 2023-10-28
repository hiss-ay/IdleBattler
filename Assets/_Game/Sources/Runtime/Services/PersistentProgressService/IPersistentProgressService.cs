using System;
using Runtime._Game.Sources.Runtime.Data.Dynamic;

namespace Runtime._Game.Sources.Runtime.Services.PersistentProgressService
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
        public MonsterData GetMonsterData(int id);
    }
}