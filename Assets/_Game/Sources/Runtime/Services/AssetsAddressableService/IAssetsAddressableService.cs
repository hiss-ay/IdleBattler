using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Runtime._Game.Sources.Runtime.Services.AssetsAddressableService
{
    public interface IAssetsAddressableService
    {
        public Task<T> GetAssetAsync<T>(string assetName) where T : Object;
        public Task LoadSceneAsync(string sceneName, LoadSceneMode loadSceneMode = LoadSceneMode.Additive);
    }
}