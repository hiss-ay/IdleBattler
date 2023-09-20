using Game.Sources.Services.PersistentProgressService;
using UnityEngine;

namespace Game.Sources.UI.MainMenuScreen
{
    public class MainMenuScreen : MonoBehaviour
    {
        [SerializeField] private CoinsPanel coinsPanel;
        [SerializeField] private LevelSlider levelSlider;

        public void SetUp(IPersistentProgressService persistentProgressService)
        {
            coinsPanel.SetUp(persistentProgressService);
            levelSlider.SetUp(persistentProgressService);
        }
    }
}
