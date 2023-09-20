namespace Game.Sources.UI.Extensions
{
    public static class UIExtensions
    {
        public static string IntegerToString(this int number)
        {
            return $"{number:n0}";
        }
    }
}