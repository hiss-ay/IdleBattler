using System;

namespace Runtime._Game.Sources.Runtime.Data.Dynamic
{
    [Serializable]
    public class MonsterData
    {
        public MonsterData(int id, int level, int shards)
        {
            this.id = id;
            this.level = level;
            this.shards = shards;
        }

        public int id;
        public int level;
        public int shards;
    }
}