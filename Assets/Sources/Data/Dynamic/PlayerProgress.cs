using System;

namespace Game.Sources.Data.Dynamic
{
    [Serializable]
    public class PlayerProgress
    {
        public PlayerProgress(LevelData levelData, CoinData coinData)
        {
            LevelData = levelData;
            CoinData = coinData;
        }

        public LevelData LevelData { get; }
        public CoinData CoinData { get; }
    }
}