using System.Threading.Tasks;
using UnityEngine;

namespace Game.Sources.Services.AssetsAddressableService
{
    public interface IAssetsAddressableService
    {
        public Task<T> GetAssetAsync<T>(string assetName) where T : Object;
        public Task LoadSceneAsync(string sceneName);
    }
}