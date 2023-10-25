using System.Threading.Tasks;
using Runtime._Game.Sources.Runtime.UI.Base;

namespace Runtime._Game.Sources.Runtime.Services.UIService
{
    public interface IUIService
    {
        public UIElementType ScreenType { get; }
        public Task<UIElement> ShowScreen(UIElementType type, object context);
    }
}