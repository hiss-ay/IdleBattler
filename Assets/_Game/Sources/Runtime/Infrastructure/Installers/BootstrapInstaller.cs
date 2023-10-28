using Zenject;

namespace Runtime._Game.Sources.Runtime.Infrastructure.Installers
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