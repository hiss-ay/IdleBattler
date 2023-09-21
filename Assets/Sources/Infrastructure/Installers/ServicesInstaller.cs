using Game.Sources.Infrastructure.Factories.AbstractFactory;
using Game.Sources.Services.AssetsAddressableService;
using Game.Sources.Services.MonstersCollectionService;
using Game.Sources.Services.PersistentProgressService;
using Game.Sources.Services.SaveLoadService;
using Game.Sources.Services.UIService;
using Zenject;

namespace Game.Sources.Infrastructure.Installers
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