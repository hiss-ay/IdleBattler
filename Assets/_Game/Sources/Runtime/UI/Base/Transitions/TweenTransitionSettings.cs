using DG.Tweening;
using UnityEngine;

namespace Runtime._Game.Sources.Runtime.UI.Base.Transitions
{
    public abstract class TweenTransitionSettings<T> : ScriptableObject
    {
        [SerializeField] private Ease ease = Ease.OutQuad;
        [SerializeField] protected float duration = 0.2f;
        [SerializeField] private float delay;
        
        public Tween CreateNewTween(T component)
        {
            Tween tween = BaseTween(component).SetEase(ease).Pause();

            if (delay > 0f)
            {
                tween.SetDelay(delay);
            }

            return tween;
        }

        protected abstract Tween BaseTween(T component);
        public abstract void OnPlay(T component);
    }
}