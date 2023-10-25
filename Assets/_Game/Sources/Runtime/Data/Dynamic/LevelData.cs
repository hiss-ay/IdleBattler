using System;

namespace Runtime._Game.Sources.Runtime.Data.Dynamic
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