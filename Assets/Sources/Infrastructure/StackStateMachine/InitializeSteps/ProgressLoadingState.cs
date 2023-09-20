using Game.Sources.Data.Settings;
using Game.Sources.Infrastructure.StackStateMachine.Base;
using Game.Sources.Services.PersistentProgressService;
using Game.Sources.Services.SaveLoadService;

namespace Game.Sources.Infrastructure.StackStateMachine.InitializeSteps
{
    public class ProgressLoadingState : InstantState
    {
        public ProgressLoadingState(IPersistentProgressService persistentProgressService,
            ISaveLoadService saveLoadService,
            PlayerInitializationSettings playerInitializationSettings)
        {
            _persistentProgressService = persistentProgressService;
            _saveLoadService = saveLoadService;
            _playerInitializationSettings = playerInitializationSettings;
        }
        
        private readonly IPersistentProgressService _persistentProgressService;
        private readonly ISaveLoadService _saveLoadService;
        private readonly PlayerInitializationSettings _playerInitializationSettings;
        
        public override void Enter(IStackStateMachine stateMachine)
        {
            LoadOrCreateProgress();
            stateMachine.StateCompleted(this);
        }

        private void LoadOrCreateProgress()
        {
            _persistentProgressService.SetProgress(_saveLoadService.LoadProgress() ?? _playerInitializationSettings.CreateNewPlayerProgress());
        }
    }
}