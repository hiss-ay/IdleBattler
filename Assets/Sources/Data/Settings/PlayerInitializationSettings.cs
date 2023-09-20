using System.Collections.Generic;
using Game.Sources.Data.Dynamic;
using UnityEngine;

namespace Game.Sources.Data.Settings
{
    
    [CreateAssetMenu(fileName = "PlayerInitializationSettings", menuName = "Settings/PlayerInitializationSettings", order = 0)]
    public class PlayerInitializationSettings : ScriptableObject
    {
        [SerializeField] private int level;
        [SerializeField] private int coins;
        [SerializeField] private List<MonsterData> monstersData;

        public PlayerProgressData CreateNewPlayerProgress()
        {
            return new PlayerProgressData(level, coins, monstersData);
        }
    }
}