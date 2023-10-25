using UnityEditor;
using UnityEngine;

namespace Editor._Game.Sources.Editor
{
    public static class Tools
    {
        [MenuItem("Tools/ClearSaves")]
        public static void ClearSaves()
        {
            PlayerPrefs.DeleteAll();
            PlayerPrefs.Save();
        }
    }
}
