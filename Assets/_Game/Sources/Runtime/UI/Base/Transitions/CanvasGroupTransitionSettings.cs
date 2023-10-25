using DG.Tweening;
using UnityEngine;

namespace Runtime._Game.Sources.Runtime.UI.Base.Transitions
{
    [CreateAssetMenu(fileName = "CanvasGroupTransitionSettings", menuName = "Configs/UI/Transitions/CanvasGroupTransitionSettings")]
    public class CanvasGroupTransitionSettings : TweenTransitionSettings<CanvasGroup>
    {
        [SerializeField] private bool show;
        
        protected override Tween BaseTween(CanvasGroup component)
        {
            return component.DOFade(show ? 1f : 0f, duration);
        }

        public override void OnPlay(CanvasGroup component)
        {
            component.interactable = show;
            component.blocksRaycasts = show;
        }
    }
}