using Runtime._Game.Sources.Runtime.Services.PersistentProgressService;
using Runtime._Game.Sources.Runtime.UI.Base;
using Runtime._Game.Sources.Runtime.UI.Extensions;
using TMPro;
using UnityEngine;

namespace Runtime._Game.Sources.Runtime.UI.MainMenuScreen
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