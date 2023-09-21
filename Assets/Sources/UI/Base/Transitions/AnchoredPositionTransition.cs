using System;
using UnityEngine;

namespace Game.Sources.UI.Base.Transitions
{
    [Serializable]
    public class AnchoredPositionTransition : TweenTransition<RectTransform>
    {
        [SerializeField] private AnchoredPositionTransitionSettings settings;
        
        protected override TweenTransitionSettings<RectTransform> GetSettings()
        {
            return settings;
        }
    }
}