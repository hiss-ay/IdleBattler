using Game.Sources.Services.PersistentProgressService;
using Game.Sources.UI.Base;
using UnityEngine;

namespace Game.Sources.UI.MainMenuScreen
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
