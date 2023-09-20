using Game.Sources.Services.PersistentProgress;
using UnityEngine;

namespace Game.Sources.UI.MainMenuScreen
{
    public class MainMenuScreen : MonoBehaviour
    {
        [SerializeField] private CoinsPanel coinsPanel;
        [SerializeField] private LevelSlider levelSlider;

        private IPersistentProgressService _persistentProgressService;

        public void SetUp(IPersistentProgressService persistentProgressService)
        {
            coinsPanel.SetUp(persistentProgressService);
            levelSlider.SetUp(persistentProgressService);
            // _persistentProgressService = persistentProgressService;

            // UpdateCoinView(_persistentProgressService.PlayerProgress.coinData.coin);
            // UpdateLevelView(_persistentProgressService.PlayerProgress.levelData.level);
            //
            // _persistentProgressService.PlayerProgress.coinData.OnAmountChanged += UpdateCoinView;
            // _persistentProgressService.PlayerProgress.levelData.OnLevelChanged += UpdateLevelView;
            
        }

        private void OnDisable()
        {
            // _persistentProgressService.PlayerProgress.coinData.OnAmountChanged -= UpdateCoinView;
            // _persistentProgressService.PlayerProgress.levelData.OnLevelChanged -= UpdateLevelView;
        }
    }
}
