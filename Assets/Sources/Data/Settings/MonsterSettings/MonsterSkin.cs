using System;
using UnityEngine;

namespace Game.Sources.Data.Settings.MonsterSettings
{
    [Serializable]
    public class MonsterSkin
    {
        [SerializeField] private string name;
        [SerializeField] private Sprite icon;

        public string Name => name;
        public Sprite Icon => icon;
    }
}