using Game.Sources.Infrastructure.Factories.AbstractFactory;
using Game.Sources.Infrastructure.Factories.UIFactory;
using Game.Sources.Services.AssetsAddressableService;
using Game.Sources.Services.PersistentProgress;
using Game.Sources.Services.SaveLoadService;
using Zenject;

namespace Game.Sources.Infrastructure.Installers
{
    public class ServicesInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            BindAssetAddressableService();
            BindAbstractFactory();
            BindUIFactory();
            BindPersistentProgressService();
            BindSaveLoadService();
        }
        
        private void BindAssetAddressableService()
        {
            Container.BindInterfacesTo<AssetsAddressableService>().AsSingle();
        }
        
        private void BindAbstractFactory()
        {
            Container.BindInterfacesTo<AbstractFactory>().AsSingle();
        }
        
        private void BindUIFactory()
        {
            Container.BindInterfacesTo<UIFactory>().AsSingle();
        }

        private void BindPersistentProgressService()
        {
            Container.BindInterfacesTo<PersistentProgressService>().AsSingle();
        }

        private void BindSaveLoadService()
        {
            Container.BindInterfacesTo<SaveLoadService>().AsSingle();
        }
    }
}