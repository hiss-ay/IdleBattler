using System;
using UnityEngine;

namespace Runtime._Game.Sources.Runtime.UI.Base.Transitions
{
    [Serializable]
    public class CanvasGroupTransition : TweenTransition<CanvasGroup>
    {
        [SerializeField] private CanvasGroupTransitionSettings settings;
        
        protected override TweenTransitionSettings<CanvasGroup> GetSettings()
        {
            return settings;
        }
    }
}