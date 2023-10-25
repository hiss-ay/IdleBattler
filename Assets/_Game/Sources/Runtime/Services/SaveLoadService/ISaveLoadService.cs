using Runtime._Game.Sources.Runtime.Data.Dynamic;

namespace Runtime._Game.Sources.Runtime.Services.SaveLoadService
{
    public interface ISaveLoadService
    {
        public void SaveProgress();
        public PlayerProgressData LoadProgress();
    }
}

