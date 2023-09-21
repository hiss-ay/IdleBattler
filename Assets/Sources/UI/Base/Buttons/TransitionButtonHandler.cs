using UnityEngine;

namespace Game.Sources.UI.Base.Buttons
{
    public abstract class TransitionButtonHandler : MonoBehaviour
    {
        public abstract void OnNormal();
        public abstract void OnPressed();
        public abstract void OnDisabled();
    }
}