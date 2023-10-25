using System;
using UnityEngine;

namespace Runtime._Game.Sources.Runtime.Data.Settings.MonsterSettings
{
    [Serializable]
    public class MonsterEvolutionSkin
    {
        [SerializeField] private string name;
        [SerializeField] private Sprite icon;

        public string Name => name;
        public Sprite Icon => icon;
    }
}