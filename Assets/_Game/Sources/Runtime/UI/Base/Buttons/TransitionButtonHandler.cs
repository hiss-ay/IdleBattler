using UnityEngine;

namespace Runtime._Game.Sources.Runtime.UI.Base.Buttons
{
    public abstract class TransitionButtonHandler : MonoBehaviour
    {
        public abstract void OnNormal();
        public abstract void OnPressed();
        public abstract void OnDisabled();
    }
}