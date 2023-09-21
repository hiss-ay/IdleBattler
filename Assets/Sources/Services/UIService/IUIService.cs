using System.Threading.Tasks;
using Game.Sources.UI.Base;

namespace Game.Sources.Services.UIService
{
    public interface IUIService
    {
        public UIElementType DefaultScreenType { get; }
        public Task<UIElement> ShowScreen(UIElementType type, object context);
    }
}