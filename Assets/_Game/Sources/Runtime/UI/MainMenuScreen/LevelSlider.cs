using Runtime._Game.Sources.Runtime.Services.PersistentProgressService;
using Runtime._Game.Sources.Runtime.UI.Base;
using UnityEngine;
using UnityEngine.UI;

namespace Runtime._Game.Sources.Runtime.UI.MainMenuScreen
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