using System.Threading.Tasks;
using UnityEngine;

namespace Game.Sources.Infrastructure.Factories.UIFactory
{
    public interface IUIFactory
    {
        public GameObject MainMenuScreen { get; }
        public GameObject CardCollectionScreen { get; }
        public GameObject TeamBuilderScreen { get; }
        public GameObject BattlerScreen { get; }
        public Task<GameObject> CreateMainMenuScreen();
        public void DestroyMainMenuScreen();
        public Task<GameObject> CreateCardCollectionScreen();
        public void DestroyCardCollectionScreen();
        public Task<GameObject> CreateTeamBuilderScreen();
        public void DestroyTeamBuilderScreen();
        public Task<GameObject> CreateBattlerScreen();
        public void DestroyBattlerScreen();
    }
}