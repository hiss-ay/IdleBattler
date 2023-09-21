using Game.Sources.Services.PersistentProgressService;
using Game.Sources.UI.Base;
using UnityEngine;
using UnityEngine.UI;

namespace Game.Sources.UI.MainMenuScreen
{
    public class LevelSlider : UIElement<IPersistentProgressService>
    {
        [SerializeField] private Slider slider;

        private IPersistentProgressService _persistentProgressService;
 
        protected override void OnShow(IPersistentProgressService persistentProgressService)
        {
            _persistentProgressService = persistentProgressService;
        }
    }
}