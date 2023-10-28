using Runtime._Game.Sources.Runtime.Infrastructure.StackStateMachine.Base;
using Runtime._Game.Sources.Runtime.Services.PersistentProgressService;
using Runtime._Game.Sources.Runtime.Services.UIService;
using Runtime._Game.Sources.Runtime.UI.Base;
using Runtime._Game.Sources.Runtime.UI.MainMenuScreen;

namespace Runtime._Game.Sources.Runtime.Infrastructure.StackStateMachine.InitializeSteps
{
    public class ShowMainMenuState : InstantState
    {
        public ShowMainMenuState(IUIService uiFactory, 
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