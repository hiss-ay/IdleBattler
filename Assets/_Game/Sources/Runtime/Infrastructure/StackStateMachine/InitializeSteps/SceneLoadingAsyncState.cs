using Runtime._Game.Sources.Runtime.Infrastructure.StackStateMachine.Base;
using Runtime._Game.Sources.Runtime.Services.AssetsAddressableService;
using UnityEngine.SceneManagement;

namespace Runtime._Game.Sources.Runtime.Infrastructure.StackStateMachine.InitializeSteps
{
    public class SceneLoadingAsyncState : InstantState
    {
        public SceneLoadingAsyncState(string sceneName, IAssetsAddressableService assetsAddressableService, LoadSceneMode loadSceneMode = LoadSceneMode.Single)
        {
            _sceneName = sceneName;
            _loadSceneMode = loadSceneMode;
            _assetsAddressableService = assetsAddressableService;
        }

        private readonly string _sceneName;
        private readonly LoadSceneMode _loadSceneMode;
        
        private readonly IAssetsAddressableService _assetsAddressableService;
        
        public override async void Enter(IStackStateMachine stateMachine)
        {
            await _assetsAddressableService.LoadSceneAsync(_sceneName, _loadSceneMode);
            stateMachine.StateCompleted(this);
        }
    }
}