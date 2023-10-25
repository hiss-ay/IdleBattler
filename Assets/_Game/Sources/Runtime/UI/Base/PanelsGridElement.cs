using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Runtime._Game.Sources.Runtime.UI.Base
{
    public class PanelsGridElement<T> : UIElement<IList> where T : UIElement
    {
        [Header("Base settings")]
        [SerializeField] private T prefab;
        [SerializeField] private RectTransform root;
        [SerializeField] private List<T> pool;
        
        [Header("Element settings")]
        [SerializeField] private int topOffset;
        [SerializeField] private int bottomOffset;
        [SerializeField] private int leftOffset;
        [SerializeField] private int elementWidth;
        [SerializeField] private int elementHeight;
        [SerializeField] private int elementHorizontalMargin;
        [SerializeField] private int elementVerticalMargin;
        [SerializeField] private int elementsInRow;

        private int _activePanelsCount;
        
        protected override void OnShow(IList context)
        {
            int panelsCount = pool.Count;
            _activePanelsCount = context.Count;
            
            int min = Mathf.Min(panelsCount, _activePanelsCount);

            for (int i = 0; i < min; i++)
            {
                pool[i].gameObject.SetActive(true);
                pool[i].Show(context[i]);
            }

            for (int i = min; i < panelsCount; i++)
            {
                pool[i].Hide();
                pool[i].gameObject.SetActive(false);
            }

            for (int i = min; i < _activePanelsCount; i++)
            {
                T panel = GetPanelAtIndex(i);
                panel.transform.SetSiblingIndex(i);
                panel.Show(context[i]);
                pool.Add(panel);
            }
            
            AdjustContentHeight();
        }

        private T GetPanelAtIndex(int index)
        {
            int horizontal = leftOffset + (index % elementsInRow) * (elementWidth + elementHorizontalMargin);
            int vertical = topOffset + (index / elementsInRow) * (elementHeight + elementVerticalMargin);

            T element = Instantiate(prefab, root);
            RectTransform rectTransform = element.GetComponent<RectTransform>();
            Rect rect = rectTransform.rect;
            rectTransform.SetInsetAndSizeFromParentEdge(RectTransform.Edge.Left, horizontal, rect.width);
            rectTransform.SetInsetAndSizeFromParentEdge(RectTransform.Edge.Top, vertical, rect.height);
            return element;
        }

        private int GetTotalHeight()
        {
            int rows = (_activePanelsCount + (elementsInRow - 1)) / elementsInRow;
            int height = 0;
            if (rows > 0)
            {
                height = topOffset + bottomOffset + rows * elementHeight + (rows - 1) * elementVerticalMargin;
            }

            return height;
        }

        private void AdjustContentHeight()
        {
            int totalHeight = GetTotalHeight();
            root.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, totalHeight);
        }

        protected override void OnHide()
        {
            for (int i = pool.Count - 1; i >= 0; i--)
            {
                pool[i].Hide();
            }
        }
    }
}
