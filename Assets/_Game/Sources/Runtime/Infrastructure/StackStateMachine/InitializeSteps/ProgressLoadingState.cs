using Runtime._Game.Sources.Runtime.Data.Settings;
using Runtime._Game.Sources.Runtime.Infrastructure.StackStateMachine.Base;
using Runtime._Game.Sources.Runtime.Services.PersistentProgressService;
using Runtime._Game.Sources.Runtime.Services.SaveLoadService;

namespace Runtime._Game.Sources.Runtime.Infrastructure.StackStateMachine.InitializeSteps
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