using Game.Sources.Infrastructure.Factories.UIFactory;
using Game.Sources.Infrastructure.StackStateMachine.Base;

namespace Game.Sources.Infrastructure.StackStateMachine.InitializeSteps
{
    public class MainMenuState : InstantState
    {
        public MainMenuState(IUIFactory uiFactory)
        {
            _uiFactory = uiFactory;
        }

        private readonly IUIFactory _uiFactory;
        
        public override void Enter(IStackStateMachine stateMachine)
        {
            ShowUI();
        }

        private async void ShowUI()
        {
            await _uiFactory.CreateMainMenuScreen();
        }
    }
}