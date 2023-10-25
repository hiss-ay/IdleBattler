using Runtime._Game.Sources.Runtime.Data.Settings;
using Runtime._Game.Sources.Runtime.Data.Settings.MonsterSettings;
using UnityEngine;
using Zenject;

namespace Runtime._Game.Sources.Runtime.Infrastructure.Installers
{
    public class SettingsInstaller : MonoInstaller
    {
        [SerializeField] private PlayerInitializationSettings playerInitializationSettings;
        [SerializeField] private MonstersCollectionSettings monstersCollectionSettings;
        
        public override void InstallBindings()
        {
            BindPlayerInitializationSettings();
            BindMonstersDataBase();
        }

        private void BindPlayerInitializationSettings()
        {
            Container.Bind<PlayerInitializationSettings>().FromInstance(playerInitializationSettings).AsSingle();
        }

        private void BindMonstersDataBase()
        {
            Container.Bind<MonstersCollectionSettings>().FromInstance(monstersCollectionSettings).AsSingle();
        }
    }
}