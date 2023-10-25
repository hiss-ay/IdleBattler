using Runtime._Game.Sources.Runtime.UI.Base.Transitions;
using UnityEngine;

namespace Runtime._Game.Sources.Runtime.UI.Base.ShowHideHandlers
{
    public class AnchoredPositionShowHideHandler : MonoBehaviour, IShowHandler, IHideHandler
    {
        [SerializeField] private RectTransform rectTransform;
        [SerializeField] private AnchoredPositionTransition[] showTransitions;
        [SerializeField] private AnchoredPositionTransition[] hideTransitions;
        
        public void OnShow()
        {
            for (int i = 0; i < hideTransitions.Length; i++)
            {
                hideTransitions[i].Pause();
            }
            
            for (int i = 0; i < showTransitions.Length; i++)
            {
                showTransitions[i].Restart(rectTransform);
            }
        }

        public void OnHide()
        {
            for (int i = 0; i < showTransitions.Length; i++)
            {
                showTransitions[i].Pause();
            }
            
            for (int i = 0; i < hideTransitions.Length; i++)
            {
                hideTransitions[i].Restart(rectTransform);
            }
        }
    }
}
