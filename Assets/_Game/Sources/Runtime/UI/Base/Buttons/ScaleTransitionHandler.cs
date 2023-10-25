using DG.Tweening;
using UnityEngine;

namespace Runtime._Game.Sources.Runtime.UI.Base.Buttons
{
    public class ScaleTransitionHandler : TransitionButtonHandler
    {
        [SerializeField] private RectTransform target;
        [SerializeField] private Vector2 pressedScale = new Vector2(0.95f, 0.95f);
        [SerializeField] private float transitionDuration = 0.1f;
        
        [SerializeField] private Vector2 normalScale = new Vector2(1f, 1f);
        
        public override void OnNormal()
        {
            target.DOScale(normalScale, transitionDuration);
        }

        public override void OnPressed()
        {
            target.DOScale(new Vector3(pressedScale.x, pressedScale.y, 1f), transitionDuration);
        }

        public override void OnDisabled()
        {
            throw new System.NotImplementedException();
        }
    }
}