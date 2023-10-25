using UnityEngine;
using UnityEngine.UI;

namespace Runtime._Game.Sources.Runtime.UI.Base
{
    public class BackButton : MonoBehaviour
    {
        [SerializeField] private UIElement screen;
        [SerializeField] private Button button;

        private void OnEnable()
        {
            button.onClick.AddListener(() => screen.Hide());
        }

        private void OnDisable()
        {
            button.onClick.RemoveListener(() => screen.Hide());
        }
    }
}
