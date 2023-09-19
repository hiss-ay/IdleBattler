using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace Game.Sources.Services.AssetsAddressableService
{
    public class AssetsAddressableService : IAssetsAddressableService
    {
        public async Task<T> GetAssetAsync<T>(string path) where T : Object
        {
            var asyncOperationHandle = Addressables.LoadAssetAsync<T>(path);
            
            await asyncOperationHandle.Task;
            
            return asyncOperationHandle.Result;
        }

        public async Task LoadSceneAsync(string sceneName)
        {
            var asyncOperationHandle = Addressables.LoadSceneAsync(sceneName);
            await asyncOperationHandle.Task;
        }
    }
}