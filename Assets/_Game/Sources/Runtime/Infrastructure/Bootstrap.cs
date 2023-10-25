using Runtime._Game.Sources.Runtime.Data.AssetsAddressable;
using Runtime._Game.Sources.Runtime.Data.Settings;
using Runtime._Game.Sources.Runtime.Infrastructure.StackStateMachine.Base;
using Runtime._Game.Sources.Runtime.Infrastructure.StackStateMachine.InitializeSteps;
using Runtime._Game.Sources.Runtime.Services.AssetsAddressableService;
using Runtime._Game.Sources.Runtime.Services.MonstersCollectionService;
using Runtime._Game.Sources.Runtime.Services.PersistentProgressService;
using Runtime._Game.Sources.Runtime.Services.SaveLoadService;
using Runtime._Game.Sources.Runtime.Services.UIService;
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
            Runtime._Game.Sources.Runtime.Infrastructure.StackStateMachine.Base.StackStateMachine.CreateAndRun(
                new ProgressLoadingState(persistentProgressService, saveLoadService, playerInitializationSettings),
                new ActionState(monstersCollectionService.Initialize),
                new ActionState(saveLoadService.SaveProgress),
                new SceneLoadingAsyncState(AssetsAddressableConstants.MainMenuLevelName, assetsAddressableService),
                new SceneLoadingAsyncState(AssetsAddressableConstants.MonsterPreviewLevelName, assetsAddressableService, LoadSceneMode.Additive),
                new UILoadingState(uiFactory, persistentProgressService)
            );
        }
    }
}