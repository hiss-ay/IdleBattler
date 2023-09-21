using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Game.Sources.Services.AssetsAddressableService;
using Game.Sources.UI.Base;
using Game.Sources.UI.Extensions;
using UnityEngine;
using Zenject;

namespace Game.Sources.Infrastructure.Factories.UIFactory
{
    public class UIFactory : IUIFactory
    {
        public UIFactory(DiContainer container, IAssetsAddressableService assetsAddressableService)
        {
            _container = container;
            _assetsAddressableService = assetsAddressableService;
        }

        private readonly IAssetsAddressableService _assetsAddressableService;
        private readonly DiContainer _container;

        private readonly List<UIElement> _activeElements = new();

        public async Task<UIElement> ShowScreen<T>(UIElementType type, T context)
        {
            var screen = _activeElements.FirstOrDefault(x => x.UIElementType == type);
            
            if (screen == null)
            {
                screen = await CreateScreenAsync(type.ToAddressableConstant());
                _activeElements.Add(screen);
            }
            
            screen.Show(context);

            return screen;
        }

        public void DestroyScreen(UIElementType type)
        {
            var screen = _activeElements.FirstOrDefault(x => x.UIElementType == type);
            if (screen != null)
            {
                _activeElements.Remove(screen);
                Object.Destroy(screen);
            }
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