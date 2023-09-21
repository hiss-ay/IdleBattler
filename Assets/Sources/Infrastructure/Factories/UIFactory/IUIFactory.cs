using System.Threading.Tasks;
using Game.Sources.UI.Base;

namespace Game.Sources.Infrastructure.Factories.UIFactory
{
    public interface IUIFactory
    {
        public Task<UIElement> ShowScreen<T>(UIElementType type, T context);
        public void DestroyScreen(UIElementType type);
    }
}