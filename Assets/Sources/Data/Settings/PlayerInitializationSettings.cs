using Game.Sources.Data.Dynamic;
using UnityEngine;

namespace Game.Sources.Data.Settings
{
    
    [CreateAssetMenu(fileName = "PlayerInitializationSettings", menuName = "Settings/PlayerInitializationSettings", order = 0)]
    public class PlayerInitializationSettings : ScriptableObject
    {
        [SerializeField] private int level;
        [SerializeField] private int coins;

        public PlayerProgress CreateNewPlayerProgress()
        {
            var playerProgress = new PlayerProgress
            {
                levelData =
                {
                    level = level
                },
                
                coinData =
                {
                    coin = coins
                }
            };

            return playerProgress;
        }
    }
}