using Game.Sources.Data.MonsterCard;
using Game.Sources.UI.Base;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Game.Sources.UI.CollectionScreen
{
    public class MonsterCardPanel : UIElement<MonsterCard>
    {
        [SerializeField] private TMP_Text nameText;
        [SerializeField] private Image icon;
        [SerializeField] private Image attackTypeIcon;
        [SerializeField] private TMP_Text level;
        [SerializeField] private TMP_Text shardProgress;
        [SerializeField] private Slider slider;

        protected override void OnShow(MonsterCard card)
        {
            nameText.text = card.Name;
            icon.sprite = card.Icon;
            attackTypeIcon.sprite = card.AttackTypeIcon;
            level.text = card.Level.ToString();
            
            shardProgress.text = $"{card.Shards}/{card.EvolutionCardRequired}";
            slider.maxValue = card.EvolutionCardRequired;
            slider.value = card.Shards;
        }
    }
}
