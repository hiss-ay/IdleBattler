using Game.Sources.Data.Settings;
using UnityEngine;
using Zenject;

namespace Game.Sources.Infrastructure.Installers
{
    public class SettingsInstaller : MonoInstaller
    {
        [SerializeField] private PlayerInitializationSettings playerInitializationSettings;
        
        public override void InstallBindings()
        {
            BindPlayerInitializationSettings();
        }

        private void BindPlayerInitializationSettings()
        {
            Container.Bind<PlayerInitializationSettings>().FromInstance(playerInitializationSettings).AsSingle();
        }
    }
}