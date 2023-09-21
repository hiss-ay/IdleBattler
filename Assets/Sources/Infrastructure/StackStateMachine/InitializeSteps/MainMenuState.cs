using Game.Sources.Infrastructure.Factories.UIFactory;
using Game.Sources.Infrastructure.StackStateMachine.Base;
using Game.Sources.Services.PersistentProgressService;
using Game.Sources.UI.Base;
using Game.Sources.UI.MainMenuScreen;

namespace Game.Sources.Infrastructure.StackStateMachine.InitializeSteps
{
    public class MainMenuState : InstantState
    {
        public MainMenuState(IUIFactory uiFactory, 
            IPersistentProgressService persistentProgressService)
        {
            _uiFactory = uiFactory;
            _persistentProgressService = persistentProgressService;
        }

        private readonly IUIFactory _uiFactory;
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
            if (_mainMenuScreen != null) 
                _mainMenuScreen.OnTabChanged += SwitchScreenByTab;
        }

        private void HideScreen()
        {
            if (_mainMenuScreen == null)
                return;
            
            _mainMenuScreen.OnTabChanged -= SwitchScreenByTab;
            _mainMenuScreen.Hide();
        }

        private void SwitchScreenByTab(UIElementType screenType)
        {
            _uiFactory.ShowScreen(screenType, _persistentProgressService);
        }
    }
}