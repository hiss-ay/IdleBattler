using Game.Sources.Infrastructure.Factories.UIFactory;
using Game.Sources.Infrastructure.StackStateMachine.Base;
using Game.Sources.Services.PersistentProgress;
using Game.Sources.UI;

namespace Game.Sources.Infrastructure.StackStateMachine.InitializeSteps
{
    public class MainMenuState : InstantState
    {
        public MainMenuState(IUIFactory uiFactory, IPersistentProgressService persistentProgressService)
        {
            _uiFactory = uiFactory;
            _persistentProgressService = persistentProgressService;
        }

        private readonly IUIFactory _uiFactory;
        private readonly IPersistentProgressService _persistentProgressService;
        
        public override void Enter(IStackStateMachine stateMachine)
        {
            ShowUI();
        }

        private async void ShowUI()
        {
            var mainMenuScreenInstance = await _uiFactory.CreateMainMenuScreen();

            if (mainMenuScreenInstance.TryGetComponent(out MainMenuScreen mainMenuScreen))
            {
                mainMenuScreen.SetUp(_persistentProgressService);
            }
        }
    }
}