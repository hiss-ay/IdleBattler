using System;

namespace Game.Sources.Data.Dynamic
{
    [Serializable]
    public class CoinData
    {
        public int coin;

        public event Action<int> OnAmountChanged;
        
        public void Collect(int amount)
        {
            coin += amount;
            OnAmountChanged?.Invoke(coin);
        }
    }
}