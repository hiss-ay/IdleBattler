using System;

namespace Game.Sources.Data.Dynamic
{
    [Serializable]
    public class LevelData
    {
        public int Level { get; private set; }
        
        public event Action OnLevelChanged;
        
        public void NextLevel()
        {
            Level++;
            OnLevelChanged?.Invoke();
        }
    }
}