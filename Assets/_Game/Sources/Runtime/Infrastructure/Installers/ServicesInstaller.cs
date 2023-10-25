using Runtime._Game.Sources.Runtime.Infrastructure.Factories.AbstractFactory;
using Runtime._Game.Sources.Runtime.Services.AssetsAddressableService;
using Runtime._Game.Sources.Runtime.Services.MonstersCollectionService;
using Runtime._Game.Sources.Runtime.Services.PersistentProgressService;
using Runtime._Game.Sources.Runtime.Services.SaveLoadService;
using Runtime._Game.Sources.Runtime.Services.UIService;
using Zenject;

namespace Runtime._Game.Sources.Runtime.Infrastructure.Installers
{
    public class ServicesInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            BindAssetAddressableService();
            BindAbstractFactory();
            BindUIService();
            BindPersistentProgressService();
            BindSaveLoadService();
            BindMonstersCollectionService();
        }
        
        private void BindAssetAddressableService()
        {
            Container.BindInterfacesTo<AssetsAddressableService>().AsSingle();
        }
        
        private void BindAbstractFactory()
        {
            Container.BindInterfacesTo<AbstractFactory>().AsSingle();
        }
        
        private void BindUIService()
        {
            Container.BindInterfacesTo<UIService>().AsSingle();
        }

        private void BindPersistentProgressService()
        {
            Container.BindInterfacesTo<PersistentProgressService>().AsSingle();
        }

        private void BindSaveLoadService()
        {
            Container.BindInterfacesTo<SaveLoadService>().AsSingle();
        }

        private void BindMonstersCollectionService()
        {
            Container.BindInterfacesTo<MonstersCollectionService>().AsSingle();
        }
    }
}