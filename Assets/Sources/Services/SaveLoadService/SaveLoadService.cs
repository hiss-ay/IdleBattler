using Game.Sources.Data.Dynamic;
using Game.Sources.Data.Extensions;
using Game.Sources.Services.PersistentProgress;
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
            PlayerPrefs.SetString(SaveLoadKey, _persistentProgressService.PlayerProgress.ToJson());
        }

        public PlayerProgress LoadProgress()
        {
            if (!PlayerPrefs.HasKey(SaveLoadKey))
            {
                return null;
            }
            
            var prefs = PlayerPrefs.GetString(SaveLoadKey)?.FromJson<PlayerProgress>();
            return prefs; 
        }
    }
}