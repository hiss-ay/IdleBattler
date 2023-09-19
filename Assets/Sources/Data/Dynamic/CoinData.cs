using System;

namespace Game.Sources.Data.Dynamic
{
    [Serializable]
    public class CoinData
    {
        public int Coin { get; private set; }

        public event Action OnAmountChanged;
        
        public void Collect(int amount)
        {
            Coin += amount;
            OnAmountChanged?.Invoke();
        }
    }
}