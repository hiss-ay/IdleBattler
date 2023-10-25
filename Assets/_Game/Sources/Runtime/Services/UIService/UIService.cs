using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Runtime._Game.Sources.Runtime.Services.AssetsAddressableService;
using Runtime._Game.Sources.Runtime.UI.Base;
using Runtime._Game.Sources.Runtime.UI.Extensions;
using UnityEngine;
using Zenject;

namespace Runtime._Game.Sources.Runtime.Services.UIService
{
    public class UIService : IUIService
    {
        public UIService(DiContainer container, IAssetsAddressableService assetsAddressableService)
        {
            _container = container;
            _assetsAddressableService = assetsAddressableService;
        }

        private readonly IAssetsAddressableService _assetsAddressableService;
        private readonly DiContainer _container;

        private readonly List<UIElement> _activeElements = new();
        private UIElement _currentElement;
        
        public UIElementType ScreenType => UIElementType.MainMenuScreen;

        public async Task<UIElement> ShowScreen(UIElementType type, object context)
        {
            if (_currentElement != null && _currentElement.UIElementType != ScreenType)
                _currentElement.Hide();
            
            _currentElement = _activeElements.FirstOrDefault(x => x.UIElementType == type);
            
            if (_currentElement == null)
            {
                _currentElement = await CreateScreenAsync(type.ToAddressableConstant());
                _activeElements.Add(_currentElement);
            }
            
            _currentElement.Show(context);

            return _currentElement;
        }

        private async Task<UIElement> CreateScreenAsync(string path)
        {
            var loadingScreenPrefab = await _assetsAddressableService.GetAssetAsync<GameObject>(path);
            var screen = _container.InstantiatePrefab(loadingScreenPrefab);
            if (screen.TryGetComponent(out UIElement uiElement))
                return uiElement;
            return null;
        }
    }
}