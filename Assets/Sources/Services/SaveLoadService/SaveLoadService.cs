using Game.Sources.Data.Dynamic;
using Game.Sources.Services.PersistentProgressService;
using UnityEngine;

namespace Game.Sources.Services.SaveLoadService
{
    public class SaveLoadService : ISaveLoadService
    {
        public SaveLoadService(IPersistentProgressService persistentProgressService)
        {
            _persistentProgressService = persistentProgressService;
        }

        private readonly IPersistentProgressService _persistentProgressService;
        
        private const string SaveLoadKey = "SaveLoadKey";

        public void SaveProgress()
        {
            string json = JsonUtility.ToJson(_persistentProgressService.PlayerProgress);
            PlayerPrefs.SetString(SaveLoadKey, json);
        }

        public PlayerProgress LoadProgress()
        {
            if (!PlayerPrefs.HasKey(SaveLoadKey))
            {
                return null;
            }
            
            string json = PlayerPrefs.GetString(SaveLoadKey);
            PlayerProgress playerProgress = JsonUtility.FromJson<PlayerProgress>(json);
            
            return playerProgress; 
        }
    }
}