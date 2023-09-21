using UnityEngine;
using UnityEngine.UI;

namespace Game.Sources.UI.Base.Buttons
{
    public class TransitionButton : Button
    {
        private TransitionButtonHandler[] TransitionHandlers => _transitionHandlers ??= GetComponents<TransitionButtonHandler>();
        private TransitionButtonHandler[] _transitionHandlers;
        
        protected override void DoStateTransition(SelectionState state, bool instant)
        {
            base.DoStateTransition(state, instant);
            switch (state)
            {
                case SelectionState.Normal:
                    for (int i = 0; i < TransitionHandlers.Length; i++)
                    {
                        TransitionHandlers[i].OnNormal();
                    }
                    break;
                case SelectionState.Pressed:
                    for (int i = 0; i < TransitionHandlers.Length; i++)
                    {
                        TransitionHandlers[i].OnPressed();
                    }
                    break;
                case SelectionState.Selected:
                    for (int i = 0; i < TransitionHandlers.Length; i++)
                    {
                        TransitionHandlers[i].OnNormal();
                    }
                    break;
                case SelectionState.Disabled:
                    for (int i = 0; i < TransitionHandlers.Length; i++)
                    {
                        TransitionHandlers[i].OnDisabled();
                    }
                    break;
            }
        }
    }
}