using Game.Sources.Data.Settings;
using Game.Sources.Data.Settings.MonsterSettings;
using UnityEngine;
using Zenject;

namespace Game.Sources.Infrastructure.Installers
{
    public class SettingsInstaller : MonoInstaller
    {
        [SerializeField] private PlayerInitializationSettings playerInitializationSettings;
        [SerializeField] private MonstersCollection monstersCollection;
        
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
            Container.Bind<MonstersCollection>().FromInstance(monstersCollection).AsSingle();
        }
    }
}