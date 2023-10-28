using Runtime._Game.Sources.Runtime.Data.Settings;
using Runtime._Game.Sources.Runtime.Infrastructure.StackStateMachine.Base;
using Runtime._Game.Sources.Runtime.Infrastructure.StackStateMachine.InitializeSteps;
using Runtime._Game.Sources.Runtime.Services.AssetsAddressableService;
using Runtime._Game.Sources.Runtime.Services.MonstersCollectionService;
using Runtime._Game.Sources.Runtime.Services.PersistentProgressService;
using Runtime._Game.Sources.Runtime.Services.SaveLoadService;
using Runtime._Game.Sources.Runtime.Services.UIService;

namespace Runtime._Game.Sources.Runtime.Infrastructure
{
    public class Bootstrap
    {
        public Bootstrap(IAssetsAddressableService assetsAddressableService,
            PlayerInitializationSettings playerInitializationSettings,
            IMonstersCollectionService monstersCollectionService,
            IUIService uiService,
            IPersistentProgressService persistentProgressService,
            ISaveLoadService saveLoadService)
        {
            StackStateMachine.Base.StackStateMachine.CreateAndRun(
                new ProgressLoadingState(persistentProgressService, saveLoadService, playerInitializationSettings),
                new ActionState(monstersCollectionService.Initialize),
                new MetaGameplayLoadingState(uiService, persistentProgressService, assetsAddressableService)
            );
        }
    }
}