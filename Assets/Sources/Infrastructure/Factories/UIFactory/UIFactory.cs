using System.Threading.Tasks;
using Game.Sources.Data.AssetsAddressable;
using Game.Sources.Services.AssetsAddressableService;
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
        
        public GameObject MainMenuScreen { get; private set; }
        public GameObject CardCollectionScreen { get; private set; }
        public GameObject TeamBuilderScreen { get; private set; }
        public GameObject BattlerScreen { get; private set; }
        
        public async Task<GameObject> CreateMainMenuScreen()
        {
            MainMenuScreen = await CreateScreenAsync(AssetsAddressableConstants.MAIN_MENU_SCREEN);
            return MainMenuScreen;
        }

        public void DestroyMainMenuScreen()
        {
            Object.Destroy(MainMenuScreen);
        }

        public async Task<GameObject> CreateCardCollectionScreen()
        {
            CardCollectionScreen = await CreateScreenAsync(AssetsAddressableConstants.CARD_COLLECTION_SCREEN);
            return CardCollectionScreen;
        }

        public void DestroyCardCollectionScreen()
        {
            Object.Destroy(CardCollectionScreen);
        }

        public async Task<GameObject> CreateTeamBuilderScreen()
        {
            TeamBuilderScreen = await CreateScreenAsync(AssetsAddressableConstants.TEAM_BUILDER_SCREEN);
            return TeamBuilderScreen;
        }

        public void DestroyTeamBuilderScreen()
        {
            Object.Destroy(TeamBuilderScreen);
        }

        public async Task<GameObject> CreateBattlerScreen()
        {
            BattlerScreen = await CreateScreenAsync(AssetsAddressableConstants.BATTLER_SCREEN);
            return BattlerScreen;
        }

        public void DestroyBattlerScreen()
        {
            Object.Destroy(BattlerScreen);
        }

        private async Task<GameObject> CreateScreenAsync(string path)
        {
            var loadingScreenPrefab = await _assetsAddressableService.GetAssetAsync<GameObject>(path);
            var screen = _container.InstantiatePrefab(loadingScreenPrefab);
            return screen;
        }
    }
}