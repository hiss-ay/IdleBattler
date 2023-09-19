using Game.Sources.Data.Dynamic;

namespace Game.Sources.Services.PersistentProgress
{
    public interface IPersistentProgressService
    {
        public PlayerProgress PlayerProgress { get; }
        public void SetProgress(PlayerProgress playerProgress);
    }
}