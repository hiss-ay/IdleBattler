using System;

namespace Game.Sources.Data.Dynamic
{
    [Serializable]
    public class LevelData
    {
        public int level;
        public event Action<int> OnLevelChanged;
        
        public void NextLevel()
        {
            level++;
            OnLevelChanged?.Invoke(level);
        }
    }
}