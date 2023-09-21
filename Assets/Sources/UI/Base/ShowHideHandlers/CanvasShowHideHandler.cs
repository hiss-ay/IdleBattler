﻿using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Game.Sources.UI.Base.ShowHideHandlers
{
    public class CanvasShowHideHandler : MonoBehaviour, IShowHandler, IHideHandler
    {
        [SerializeField] private Canvas canvas;
        [SerializeField] private GraphicRaycaster raycaster;
        [SerializeField] private float hideDelay = 2;
        
        public void OnShow()
        {
            canvas.enabled = true;
            raycaster.enabled = true;
            StopAllCoroutines();
        }

        public void OnHide()
        {
            raycaster.enabled = false;
            StartCoroutine(HideDelay());
        }

        private IEnumerator HideDelay()
        {
            yield return new WaitForSeconds(hideDelay);
            canvas.enabled = false;
        }
    }
}