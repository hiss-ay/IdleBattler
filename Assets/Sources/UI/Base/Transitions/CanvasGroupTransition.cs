using System;
using UnityEngine;

namespace Game.Sources.UI.Base.Transitions
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