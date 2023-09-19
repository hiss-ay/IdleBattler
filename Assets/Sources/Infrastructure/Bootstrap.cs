using Game.Sources.Infrastructure.Factories.AbstractFactory;
using Game.Sources.Infrastructure.Factories.UIFactory;
using Game.Sources.Infrastructure.StackStateMachine.InitializeSteps;
using Game.Sources.Services.AssetsAddressableService;
using Game.Sources.Services.PersistentProgress;
using Game.Sources.Services.SaveLoadService;

namespace Game.Sources.Infrastructure
{
    public class Bootstrap
    {
        public Bootstrap(IAssetsAddressableService assetsAddressableService,
            IUIFactory uiFactory,
            IAbstractFactory abstractFactory,
            IPersistentProgressService persistentProgressService,
            ISaveLoadService saveLoadService)
        {
            StackStateMachine.Base.StackStateMachine.CreateAndRun(
                new SceneLoadState(assetsAddressableService),
                new MainMenuState(uiFactory)
            );
        }
    }
}