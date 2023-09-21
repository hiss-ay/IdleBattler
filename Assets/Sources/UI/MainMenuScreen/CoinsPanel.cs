using Game.Sources.Services.PersistentProgressService;
using Game.Sources.UI.Base;
using Game.Sources.UI.Extensions;
using TMPro;
using UnityEngine;

namespace Game.Sources.UI.MainMenuScreen
{
    public class CoinsPanel : UIElement<IPersistentProgressService>
    {
        [SerializeField] private TMP_Text coins;
        
        private IPersistentProgressService _persistentProgressService;

        protected override void OnShow(IPersistentProgressService persistentProgressService)
        {
            _persistentProgressService = persistentProgressService;
            UpdateCoins(_persistentProgressService.Coins);
            _persistentProgressService.OnCoinsAdded += UpdateCoins;
        }

        private void UpdateCoins(int amount)
        {
            coins.text = amount.IntegerToString();
        }

        protected override void OnHide()
        {
            _persistentProgressService.OnCoinsAdded -= UpdateCoins;
        }
    }
}