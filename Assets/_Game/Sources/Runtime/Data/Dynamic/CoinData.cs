using System;

namespace Runtime._Game.Sources.Runtime.Data.Dynamic
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