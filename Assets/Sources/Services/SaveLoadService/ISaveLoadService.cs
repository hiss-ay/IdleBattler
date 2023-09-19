using Game.Sources.Data.Dynamic;

namespace Game.Sources.Services.SaveLoadService
{
    public interface ISaveLoadService
    {
        public void SaveProgress();
        public PlayerProgress LoadProgress();
    }
}

