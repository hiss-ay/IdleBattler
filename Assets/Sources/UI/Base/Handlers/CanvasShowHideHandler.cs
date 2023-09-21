using UnityEngine;
using UnityEngine.UI;

namespace Game.Sources.UI.Base.Handlers
{
    public class CanvasShowHideHandler : MonoBehaviour, IShowHandler, IHideHandler
    {
        [SerializeField] private Canvas canvas;
        [SerializeField] private GraphicRaycaster raycaster;
        
        public void OnShow(UIElement element)
        {
            canvas.enabled = true;
            raycaster.enabled = true;
        }

        public void OnHide(UIElement element)
        {
            canvas.enabled = false;
            raycaster.enabled = false;
        }
    }
}