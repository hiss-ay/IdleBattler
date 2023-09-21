using UnityEngine;
using UnityEngine.UI;

namespace Game.Sources.UI.Base
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
