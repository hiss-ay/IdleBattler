using System;
using System.Collections.Generic;

namespace Game.Sources.Data.Dynamic
{
    [Serializable]
    public class PlayerProgress
    {
        public PlayerProgress()
        {
            levelData = new LevelData();
            coinData = new CoinData();
            MonstersData = new List<MonsterData>();
        }
        
        public LevelData levelData;
        public CoinData coinData;
        public List<MonsterData> MonstersData;
    }
}