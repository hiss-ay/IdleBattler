using Game.Sources.Infrastructure.StackStateMachine.Base;
using Game.Sources.Services.AssetsAddressableService;
using UnityEngine.SceneManagement;

namespace Game.Sources.Infrastructure.StackStateMachine.InitializeSteps
{
    public class SceneLoadingState : InstantState
    {
        public SceneLoadingState(string sceneName, IAssetsAddressableService assetsAddressableService, LoadSceneMode loadSceneMode = LoadSceneMode.Single)
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