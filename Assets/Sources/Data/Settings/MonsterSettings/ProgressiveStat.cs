using System;
using UnityEngine;

namespace Game.Sources.Data.Settings.MonsterSettings
{
    [Serializable]
    public class ProgressiveStat
    {
        [SerializeField] private int @base;
        [SerializeField] private float baseModifier;
        [SerializeField] private float firstEvolutionModifier;
        [SerializeField] private float secondEvolutionModifier;

        public int GetValue(int level)
        {
            int evolutionIndex = level % 10 + 1;
            float evolutionModifier = evolutionIndex switch
            {
                1 => firstEvolutionModifier,
                2 => firstEvolutionModifier + secondEvolutionModifier,
                _ => 0
            };
            
            return (int)(@base + level * baseModifier + evolutionModifier);
        }
    }
}