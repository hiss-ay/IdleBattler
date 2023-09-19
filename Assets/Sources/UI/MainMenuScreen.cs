using Game.Sources.Services.PersistentProgress;
using TMPro;
using UnityEngine;

namespace Game.Sources.UI
{
    public class MainMenuScreen : MonoBehaviour
    {
        [SerializeField] private TMP_Text levelText;
        [SerializeField] private TMP_Text coinText;

        private IPersistentProgressService _persistentProgressService;

        public void SetUp(IPersistentProgressService persistentProgressService)
        {
            _persistentProgressService = persistentProgressService;

            UpdateCoinView(_persistentProgressService.PlayerProgress.coinData.coin);
            UpdateLevelView(_persistentProgressService.PlayerProgress.levelData.level);
            
            _persistentProgressService.PlayerProgress.coinData.OnAmountChanged += UpdateCoinView;
            _persistentProgressService.PlayerProgress.levelData.OnLevelChanged += UpdateLevelView;
        }
        
        private void UpdateCoinView(int coin)
        {
            coinText.text = $"Coins: {coin}";
        }
        
        private void UpdateLevelView(int level)
        {
            levelText.text = $"Level: {level}";
        }

        private void OnDisable()
        {
            _persistentProgressService.PlayerProgress.coinData.OnAmountChanged -= UpdateCoinView;
            _persistentProgressService.PlayerProgress.levelData.OnLevelChanged -= UpdateLevelView;
        }
    }
}
