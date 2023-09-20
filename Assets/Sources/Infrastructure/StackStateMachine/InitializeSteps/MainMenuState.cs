using Game.Sources.Infrastructure.Factories.UIFactory;
using Game.Sources.Infrastructure.StackStateMachine.Base;
using Game.Sources.Services.MonstersCollectionService;
using Game.Sources.Services.PersistentProgressService;
using Game.Sources.UI.MainMenuScreen;
using UnityEngine;

namespace Game.Sources.Infrastructure.StackStateMachine.InitializeSteps
{
    public class MainMenuState : InstantState
    {
        public MainMenuState(IUIFactory uiFactory, 
            IPersistentProgressService persistentProgressService,
            IMonstersCollectionService monstersCollectionService)
        {
            _uiFactory = uiFactory;
            _persistentProgressService = persistentProgressService;
            _monstersCollectionService = monstersCollectionService;
        }

        private readonly IUIFactory _uiFactory;
        private readonly IPersistentProgressService _persistentProgressService;
        private readonly IMonstersCollectionService _monstersCollectionService;
        
        public override void Enter(IStackStateMachine stateMachine)
        {
            ShowUI();
            Debug.Log(_monstersCollectionService.MonsterCards);
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