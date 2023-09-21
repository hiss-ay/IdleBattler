using Game.Sources.Data.AssetsAddressable;
using Game.Sources.Data.Settings;
using Game.Sources.Infrastructure.StackStateMachine.Base;
using Game.Sources.Infrastructure.StackStateMachine.InitializeSteps;
using Game.Sources.Services.AssetsAddressableService;
using Game.Sources.Services.MonstersCollectionService;
using Game.Sources.Services.PersistentProgressService;
using Game.Sources.Services.SaveLoadService;
using Game.Sources.Services.UIService;
using UnityEngine.SceneManagement;

namespace Game.Sources.Infrastructure
{
    public class Bootstrap
    {
        public Bootstrap(IAssetsAddressableService assetsAddressableService,
            PlayerInitializationSettings playerInitializationSettings,
            IMonstersCollectionService monstersCollectionService,
            IUIService uiFactory,
            IPersistentProgressService persistentProgressService,
            ISaveLoadService saveLoadService)
        {
            StackStateMachine.Base.StackStateMachine.CreateAndRun(
                new ProgressLoadingState(persistentProgressService, saveLoadService, playerInitializationSettings),
                new ActionState(monstersCollectionService.Initialize),
                new ActionState(saveLoadService.SaveProgress),
                new SceneLoadingAsyncState(AssetsAddressableConstants.MAIN_MENU_LEVEL_NAME, assetsAddressableService),
                new SceneLoadingAsyncState(AssetsAddressableConstants.MONSTER_PREVIEW_LEVEL_NAME, assetsAddressableService, LoadSceneMode.Additive),
                new UILoadingState(uiFactory, persistentProgressService)
            );
        }
    }
}