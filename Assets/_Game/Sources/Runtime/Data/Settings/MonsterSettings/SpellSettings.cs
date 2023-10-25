using UnityEngine;

namespace Runtime._Game.Sources.Runtime.Data.Settings.MonsterSettings
{
    [CreateAssetMenu(fileName = "SpellSettings", menuName = "Settings/SpellSettings")]
    public class SpellSettings : ScriptableObject
    {
        [SerializeField] private Sprite icon;
        [SerializeField] private string description;

        public Sprite Icon => icon;
        public string Description => description;
    }
}