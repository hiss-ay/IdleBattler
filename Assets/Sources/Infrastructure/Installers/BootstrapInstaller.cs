using Zenject;

namespace Game.Sources.Infrastructure.Installers
{
    public class BootstrapInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            BindGameInstance();
        }

        private void BindGameInstance()
        {
            Container.Bind<Bootstrap>().AsSingle().NonLazy();
        }
    }
}