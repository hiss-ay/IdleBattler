using System;
using UnityEngine;

namespace Runtime._Game.Sources.Runtime.Data.Settings.MonsterSettings
{
    [Serializable]
    public class LevelUpgradeCost
    {
        [SerializeField] private float priceCoef;
        [SerializeField] private float priceMod;
        
        public int GetCost(int level) => (int)(level * Mathf.Pow(priceCoef, level) * priceMod);
    }
}