using System.Linq;
using Game.Sources.Data.Dynamic;

namespace Game.Sources.Services.PersistentProgressService
{
    public class PersistentProgressService : IPersistentProgressService
    {
        public PlayerProgress PlayerProgress { get; private set; }
        
        public void SetProgress(PlayerProgress playerProgress)
        {
            PlayerProgress = playerProgress;
        }

        public MonsterData GetMonsterDataByID(int id)
        {
            return PlayerProgress.MonstersData.FirstOrDefault(x => x.id == id);
        }
    }
}