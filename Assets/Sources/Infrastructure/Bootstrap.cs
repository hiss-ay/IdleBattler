﻿using Game.Sources.Data.Settings;
using Game.Sources.Infrastructure.Factories.AbstractFactory;
using Game.Sources.Infrastructure.Factories.UIFactory;
using Game.Sources.Infrastructure.StackStateMachine.Base;
using Game.Sources.Infrastructure.StackStateMachine.InitializeSteps;
using Game.Sources.Services.AssetsAddressableService;
using Game.Sources.Services.MonstersCollectionService;
using Game.Sources.Services.PersistentProgressService;
using Game.Sources.Services.SaveLoadService;

namespace Game.Sources.Infrastructure
{
    public class Bootstrap
    {
        public Bootstrap(IAssetsAddressableService assetsAddressableService,
            PlayerInitializationSettings playerInitializationSettings,
            IMonstersCollectionService monstersCollectionService,
            IUIFactory uiFactory,
            IAbstractFactory abstractFactory,
            IPersistentProgressService persistentProgressService,
            ISaveLoadService saveLoadService)
        {
            StackStateMachine.Base.StackStateMachine.CreateAndRun(
                new SceneLoadState(assetsAddressableService),
                new ProgressLoadingState(persistentProgressService, saveLoadService, playerInitializationSettings),
                new ActionState(monstersCollectionService.Initialize),
                new MainMenuState(uiFactory, persistentProgressService, monstersCollectionService)
            );
        }
    }
}