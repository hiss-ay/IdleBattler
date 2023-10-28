using Runtime._Game.Sources.Runtime.Data.AssetsAddressable;
using Runtime._Game.Sources.Runtime.Infrastructure.StackStateMachine.Base;
using Runtime._Game.Sources.Runtime.Services.AssetsAddressableService;
using Runtime._Game.Sources.Runtime.Services.PersistentProgressService;
using Runtime._Game.Sources.Runtime.Services.UIService;
using UnityEngine.SceneManagement;

namespace Runtime._Game.Sources.Runtime.Infrastructure.StackStateMachine.InitializeSteps
{
    public class MetaGameplayLoadingState : InstantState
    {
        public MetaGameplayLoadingState(IUIService uiFactory, 
            IPersistentProgressService persistentProgressService, IAssetsAddressableService assetsAddressableService)
        {
            _uiService = uiFactory;
            _persistentProgressService = persistentProgressService;
            _assetsAddressableService = assetsAddressableService;
        }
        
        private readonly IAssetsAddressableService _assetsAddressableService;
        private readonly IPersistentProgressService _persistentProgressService;
        private readonly IUIService _uiService;
        
        public override void Enter(IStackStateMachine stateMachine)
        {
            stateMachine.ReplaceStates(new SceneLoadingAsyncState(AssetsAddressableConstants.MainMenuLevelName, _assetsAddressableService),
                new SceneLoadingAsyncState(AssetsAddressableConstants.MonsterPreviewLevelName, _assetsAddressableService, LoadSceneMode.Additive),
                new ShowMainMenuState(_uiService, _persistentProgressService));
        }
    }
}