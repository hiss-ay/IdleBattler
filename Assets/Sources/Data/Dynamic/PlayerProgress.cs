using System;

namespace Game.Sources.Data.Dynamic
{
    [Serializable]
    public class PlayerProgress
    {
        public PlayerProgress()
        {
            levelData = new LevelData();
            coinData = new CoinData();
        }
        
        public LevelData levelData;
        public CoinData coinData;
    }
}