using Game.Sources.Infrastructure.StackStateMachine.Base;
using Game.Sources.Services.PersistentProgressService;
using Game.Sources.Services.UIService;
using Game.Sources.UI.Base;
using Game.Sources.UI.MainMenuScreen;

namespace Game.Sources.Infrastructure.StackStateMachine.InitializeSteps
{
    public class MainMenuState : InstantState
    {
        public MainMenuState(IUIService uiFactory, 
            IPersistentProgressService persistentProgressService)
        {
            _uiFactory = uiFactory;
            _persistentProgressService = persistentProgressService;
        }

        private readonly IUIService _uiFactory;
        private readonly IPersistentProgressService _persistentProgressService;
        
        private MainMenuScreen _mainMenuScreen;
        
        public override void Enter(IStackStateMachine stateMachine)
        {
            ShowScreen();
        }

        public override void Exit()
        {
            HideScreen();
        }

        private async void ShowScreen()
        {
            _mainMenuScreen = await _uiFactory.ShowScreen(UIElementType.MainMenuScreen, _persistentProgressService) as MainMenuScreen;
        }

        private void HideScreen()
        {
            if (_mainMenuScreen == null)
                return;
            
            _mainMenuScreen.Hide();
        }

        
    }
}