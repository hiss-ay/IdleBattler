using System;
using System.Linq;
using Game.Sources.Data.Dynamic;

namespace Game.Sources.Services.PersistentProgressService
{
    public class PersistentProgressService : IPersistentProgressService
    {
        public PlayerProgressData PlayerProgressData { get; private set; }
        public int Coins => PlayerProgressData.coins;
        public int Level => PlayerProgressData.level;
        
        public Action<int> OnLevelUp { get; set; }
        public Action<int> OnCoinsAdded { get; set; }
        
        public void SetProgress(PlayerProgressData playerProgressData)
        {
            PlayerProgressData = playerProgressData;
        }

        public void AddCoins(int amount)
        {
            PlayerProgressData.coins += amount;
            OnCoinsAdded?.Invoke(PlayerProgressData.coins);
        }

        public void LevelUp()
        {
            PlayerProgressData.level++;
            OnLevelUp?.Invoke(PlayerProgressData.level);
        }
        
        public MonsterData GetOrCreateMonsterDataByID(int id)
        {
            var monsterData = PlayerProgressData.monstersData.FirstOrDefault(x => x.id == id);
            
            if (monsterData != null)
                return monsterData;
            
            var newMonsterData = new MonsterData(id, -1, 0);
            PlayerProgressData.monstersData.Add(newMonsterData);
            
            return newMonsterData;
        }
    }
}