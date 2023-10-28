using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.ResourceProviders;
using UnityEngine.SceneManagement;

namespace Runtime._Game.Sources.Runtime.Services.AssetsAddressableService
{
    public class AssetsAddressableService : IAssetsAddressableService
    {
        public async Task<T> GetAssetAsync<T>(string path) where T : Object
        {
            var asyncOperationHandle = Addressables.LoadAssetAsync<T>(path);
            
            await asyncOperationHandle.Task;
            
            return asyncOperationHandle.Result;
        }

        public async Task LoadSceneAsync(string sceneName, LoadSceneMode loadSceneMode = LoadSceneMode.Single)
        {
            var asyncOperationHandle = Addressables.LoadSceneAsync(sceneName, loadSceneMode);
            await asyncOperationHandle.Task;
        }
        
        public async Task UnloadSceneAsync(SceneInstance sceneInstance, UnloadSceneOptions unloadSceneOptions = UnloadSceneOptions.None)
        {
            var asyncOperationHandle = Addressables.UnloadSceneAsync(sceneInstance, unloadSceneOptions);
            await asyncOperationHandle.Task;
        }
    }
}