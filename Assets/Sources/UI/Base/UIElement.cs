using Game.Sources.UI.Base.ShowHideHandlers;
using UnityEngine;

namespace Game.Sources.UI.Base
{
    public abstract class UIElement : MonoBehaviour
    {
        public virtual UIElementType UIElementType => UIElementType.Unknown;
        
        private IShowHandler[] ShowHandlers => _showHandlers ??= GetComponents<IShowHandler>();
        private IShowHandler[] _showHandlers;

        private IHideHandler[] HideHandlers => _hideHandlers ??= GetComponents<IHideHandler>();
        private IHideHandler[] _hideHandlers;

        private bool _isShowing;
        
        public void Show(object obj)
        {
            OnShow(obj);

            if (!_isShowing)
            {
                for (int i = 0; i < ShowHandlers.Length; i++)
                {
                    ShowHandlers[i].OnShow();
                }
                
                _isShowing = true;
            }
        }

        public void Hide()
        {
            OnHide();

            if (_isShowing)
            {
                for (int i = 0; i < ShowHandlers.Length; i++)
                {
                    HideHandlers[i].OnHide();
                }
                
                _isShowing = false;
            }
        }

        protected abstract void OnShow(object obj);
        protected virtual void OnHide() { }
    }

    public abstract class UIElement<T> : UIElement
    {
        protected sealed override void OnShow(object obj)
        {
            if (obj is T casted)
            {
                OnShow(casted);
            }
            else
            {
                OnShow(default);
            }
        }

        protected abstract void OnShow(T obj);
    }
}