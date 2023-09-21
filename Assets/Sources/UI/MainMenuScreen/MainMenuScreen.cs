using System;
using Game.Sources.Services.PersistentProgressService;
using Game.Sources.UI.Base;
using UnityEngine;

namespace Game.Sources.UI.MainMenuScreen
{
    public class MainMenuScreen : UIElement<IPersistentProgressService>
    {
        [SerializeField] private CoinsPanel coinsPanel;
        [SerializeField] private LevelSlider levelSlider;
        
        [SerializeField] private TabButton[] tabs;
        
        public Action<UIElementType> OnTabChanged;
        
        protected override void OnShow(IPersistentProgressService persistentProgressService)
        {
            coinsPanel.Show(persistentProgressService);
            levelSlider.Show(persistentProgressService);
            foreach (var tab in tabs)
            {
                tab.OnTabClicked += type => OnTabChanged?.Invoke(type);
            }
        }

        protected override void OnHide()
        {
            foreach (var tab in tabs)
            {
                tab.OnTabClicked -= type => OnTabChanged?.Invoke(type);
            }
            coinsPanel.Hide();
            levelSlider.Hide();
        }
    }
}
