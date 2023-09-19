using Game.Sources.Data.AssetsAddressable;
using Game.Sources.Infrastructure.StackStateMachine.Base;
using Game.Sources.Services.AssetsAddressableService;

namespace Game.Sources.Infrastructure.StackStateMachine.InitializeSteps
{
    public class SceneLoadState : InstantState
    {
        public SceneLoadState(IAssetsAddressableService assetsAddressableService)
        {
            _assetsAddressableService = assetsAddressableService;
        }
        
        private readonly IAssetsAddressableService _assetsAddressableService;
        
        public override void Enter(IStackStateMachine stateMachine)
        {
            _assetsAddressableService.LoadSceneAsync(AssetsAddressableConstants.MAIN_MENU_LEVEL_NAME);
            stateMachine.StateCompleted(this);
        }

        
    }
}