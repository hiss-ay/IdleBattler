using Runtime._Game.Sources.Runtime.UI.Base.Transitions;
using UnityEngine;

namespace Runtime._Game.Sources.Runtime.UI.Base.ShowHideHandlers
{
    public class CanvasGroupShowHideHandler : MonoBehaviour, IShowHandler, IHideHandler
    {
        [SerializeField] private CanvasGroup canvasGroup;
        [SerializeField] private CanvasGroupTransition[] showTransitions;
        [SerializeField] private CanvasGroupTransition[] hideTransitions;

        public void OnShow()
        {
            for (int i = 0; i < hideTransitions.Length; i++)
            {
                hideTransitions[i].Pause();
            }
            
            for (int i = 0; i < showTransitions.Length; i++)
            {
                showTransitions[i].Restart(canvasGroup);
            }
        }

        public void OnHide()
        {
            for (int i = 0; i < hideTransitions.Length; i++)
            {
                hideTransitions[i].Pause();
            }
            
            for (int i = 0; i < showTransitions.Length; i++)
            {
                showTransitions[i].Restart(canvasGroup);
            }
        }
    }
}