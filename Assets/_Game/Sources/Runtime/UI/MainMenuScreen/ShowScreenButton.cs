using Runtime._Game.Sources.Runtime.Services.UIService;
using Runtime._Game.Sources.Runtime.UI.Base;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Runtime._Game.Sources.Runtime.UI.MainMenuScreen
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