using Runtime._Game.Sources.Runtime.Data.Dynamic;
using Runtime._Game.Sources.Runtime.Services.PersistentProgressService;
using UnityEngine;

namespace Runtime._Game.Sources.Runtime.Services.SaveLoadService
{
    public class SaveLoadService : ISaveLoadService
    {
        public SaveLoadService(IPersistentProgressService persistentProgressService)
        {
            _persistentProgressService = persistentProgressService;
        }

        private readonly IPersistentProgressService _persistentProgressService;
        
        private const string PlayerKey = "PlayerKey";

        public void SaveProgress()
        {
            string json = JsonUtility.ToJson(_persistentProgressService.PlayerProgressData);
            PlayerPrefs.SetString(PlayerKey, json);
        }

        public PlayerProgressData LoadProgress()
        {
            if (!PlayerPrefs.HasKey(PlayerKey))
            {
                return null;
            }
            
            string json = PlayerPrefs.GetString(PlayerKey);
            PlayerProgressData playerProgressData = JsonUtility.FromJson<PlayerProgressData>(json);
            
            return playerProgressData; 
        }
    }
}