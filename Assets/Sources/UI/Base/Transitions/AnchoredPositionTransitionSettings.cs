using DG.Tweening;
using UnityEngine;

namespace Game.Sources.UI.Base.Transitions
{
    [CreateAssetMenu(fileName = "AnchoredPositionTransitionSettings", menuName = "Configs/UI/Transitions/AnchoredPositionTransitionSettings")]
    public class AnchoredPositionTransitionSettings : TweenTransitionSettings<RectTransform>
    {
        [SerializeField] private Vector2 from;
        [SerializeField] private Vector2 to;
        
        protected override Tween BaseTween(RectTransform component)
        {
            return component.DOAnchorPos(to, duration);
        }

        public override void OnBeforePlay(RectTransform component)
        {
            component.anchoredPosition = from;
        }
    }
}