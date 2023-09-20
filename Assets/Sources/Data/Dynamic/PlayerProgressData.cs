using System;
using System.Collections.Generic;

namespace Game.Sources.Data.Dynamic
{
    [Serializable]
    public class PlayerProgressData
    {
        public PlayerProgressData(int initialLevel, int initialCoins, List<MonsterData> initialMonsters)
        {
            level = initialLevel;
            coins = initialCoins;
            monstersData = initialMonsters;
        }
        
        public int level;
        public int coins;
        public List<MonsterData> monstersData;
    }
}