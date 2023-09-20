using Game.Sources.Services.PersistentProgressService;
using Game.Sources.UI.Extensions;
using TMPro;
using UnityEngine;

namespace Game.Sources.UI.MainMenuScreen
{
    public class CoinsPanel : MonoBehaviour
    {
        [SerializeField] private TMP_Text coins;
        
        private IPersistentProgressService _persistentProgressService;

        public void SetUp(IPersistentProgressService persistentProgressService)
        {
            _persistentProgressService = persistentProgressService;
            UpdateCoins(_persistentProgressService.Coins);
            _persistentProgressService.OnCoinsAdded += UpdateCoins;
        }

        private void UpdateCoins(int amount)
        {
            coins.text = amount.IntegerToString();
        }

        private void OnDisable()
        {
            _persistentProgressService.OnCoinsAdded -= UpdateCoins;
        }
    }
}