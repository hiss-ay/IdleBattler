using Game.Sources.Data.AssetsAddressable;
using Game.Sources.Data.Settings;
using Game.Sources.Infrastructure.Factories.AbstractFactory;
using Game.Sources.Infrastructure.Factories.UIFactory;
using Game.Sources.Infrastructure.StackStateMachine.Base;
using Game.Sources.Infrastructure.StackStateMachine.InitializeSteps;
using Game.Sources.Services.AssetsAddressableService;
using Game.Sources.Services.MonstersCollectionService;
using Game.Sources.Services.PersistentProgressService;
using Game.Sources.Services.SaveLoadService;
using UnityEngine.SceneManagement;

namespace Game.Sources.Infrastructure
{
    public class Bootstrap
    {
        public Bootstrap(IAssetsAddressableService assetsAddressableService,
            PlayerInitializationSettings playerInitializationSettings,
            IMonstersCollectionService monstersCollectionService,
            IUIFactory uiFactory,
            IAbstractFactory abstractFactory,
            IPersistentProgressService persistentProgressService,
            ISaveLoadService saveLoadService)
        {
            StackStateMachine.Base.StackStateMachine.CreateAndRun(
                new ProgressLoadingState(persistentProgressService, saveLoadService, playerInitializationSettings),
                new ActionState(monstersCollectionService.Initialize),
                new SceneLoadingState(AssetsAddressableConstants.MAIN_MENU_LEVEL_NAME, assetsAddressableService),
                new SceneLoadingState(AssetsAddressableConstants.MONSTER_PREVIEW_LEVEL_NAME, assetsAddressableService, LoadSceneMode.Additive),
                new MainMenuState(uiFactory, persistentProgressService),
                new ActionState(saveLoadService.SaveProgress)
            );
        }
    }
}