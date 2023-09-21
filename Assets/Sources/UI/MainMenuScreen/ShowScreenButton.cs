using Game.Sources.Services.UIService;
using Game.Sources.UI.Base;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Game.Sources.UI.MainMenuScreen
{
    public class ShowScreenButton : MonoBehaviour
    {
        [Inject]
        private void Construct(IUIService uiService)
        {
            _uiService = uiService;
        }
        
        [SerializeField] private UIElementType type;
        [SerializeField] private Button button;

        private IUIService _uiService;
        
        private void OnEnable()
        {
            button.onClick.AddListener(ShowScreen);
        }

        private void OnDisable()
        {
            button.onClick.RemoveListener(ShowScreen);
        }

        private async void ShowScreen()
        {
            await _uiService.ShowScreen(type, null);
        }
    }
}