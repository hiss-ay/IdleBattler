using Zenject;

namespace Game.Sources.Infrastructure.Installers
{
    public class BootstrapInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            BindBootstrap();
        }

        private void BindBootstrap()
        {
            Container.Bind<Bootstrap>().AsSingle().NonLazy();
        }
    }
}