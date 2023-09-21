using System;
using Game.Sources.UI.Base;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Game.Sources.UI.MainMenuScreen
{
    public class TabButton : MonoBehaviour
    {
        [SerializeField] private UIElementType type;
        [SerializeField] private Button button;

        public Action<UIElementType> OnTabClicked;
        
        private void Start()
        {
            button.onClick.AddListener(Select);
        }

        private void Select()
        {
            OnTabClicked?.Invoke(type);
        }
    }
}