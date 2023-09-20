using Game.Sources.Services.PersistentProgress;
using UnityEngine;
using UnityEngine.UI;

namespace Game.Sources.UI.MainMenuScreen
{
    public class LevelSlider : MonoBehaviour
    {
        [SerializeField] private Slider slider;

        private IPersistentProgressService _persistentProgressService;
        
        public void SetUp(IPersistentProgressService persistentProgressService)
        {
            _persistentProgressService = persistentProgressService;
        }
    }
}