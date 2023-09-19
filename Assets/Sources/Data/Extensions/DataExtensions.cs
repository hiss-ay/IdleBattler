using UnityEngine;

namespace Game.Sources.Data.Extensions
{
    public static class DataExtensions
    {
        public static string ToJson(this object obj)
        {
            return JsonUtility.ToJson(obj);
        }
        
        public static T FromJson<T>(this string json)
        {
            return JsonUtility.FromJson<T>(json);
        }
    }
}