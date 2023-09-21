using System;
using Game.Sources.Data.AssetsAddressable;
using Game.Sources.UI.Base;

namespace Game.Sources.UI.Extensions
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
                UIElementType.MainMenuScreen => AssetsAddressableConstants.MAIN_MENU_SCREEN,
                UIElementType.CollectionScreen => AssetsAddressableConstants.CARD_COLLECTION_SCREEN,
                UIElementType.QuestsScreen => AssetsAddressableConstants.QUESTS_SCREEN,
                UIElementType.TeamBuilderScreen => AssetsAddressableConstants.TEAM_BUILDER_SCREEN,
                _ => throw new Exception(nameof(uiElementType))
            };
        }
    }
}