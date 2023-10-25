using Runtime._Game.Sources.Runtime.Services.PersistentProgressService;
using Runtime._Game.Sources.Runtime.UI.Base;
using UnityEngine;

namespace Runtime._Game.Sources.Runtime.UI.MainMenuScreen
{
    public class MainMenuScreen : UIElement<IPersistentProgressService>
    {
        public override UIElementType UIElementType => UIElementType.MainMenuScreen;
        
        [SerializeField] private CoinsPanel coinsPanel;
        [SerializeField] private LevelSlider levelSlider;
        
        protected override void OnShow(IPersistentProgressService persistentProgressService)
        {
            coinsPanel.Show(persistentProgressService);
            levelSlider.Show(persistentProgressService);
        }

        protected override void OnHide()
        {
            coinsPanel.Hide();
            levelSlider.Hide();
        }
    }
}
