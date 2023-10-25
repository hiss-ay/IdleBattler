using System;
using Runtime._Game.Sources.Runtime.Data.AssetsAddressable;
using Runtime._Game.Sources.Runtime.UI.Base;

namespace Runtime._Game.Sources.Runtime.UI.Extensions
{
    public static class UIExtensions
    {
        public static string IntegerToString(this int number)
        {
            return $"{number:n0}";
        }

        public static string ToAddressableConstant(this UIElementType uiElementType)
        {
            return uiElementType switch
            {
                UIElementType.MainMenuScreen => AssetsAddressableConstants.MainMenuScreen,
                UIElementType.CollectionScreen => AssetsAddressableConstants.CardCollectionScreen,
                UIElementType.QuestsScreen => AssetsAddressableConstants.QuestsScreen,
                UIElementType.TeamBuilderScreen => AssetsAddressableConstants.TeamBuilderScreen,
                _ => throw new Exception(nameof(uiElementType))
            };
        }
    }
}