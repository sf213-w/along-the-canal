using UnityEngine;

namespace Canal.UI
{
    // Attach to the Main Menu's Canvas. Wire buttons here as the menu grows
    // (Play, Options, Quit, etc.).
    public class MainMenuController : MonoBehaviour
    {
        [SerializeField] private string gameplaySceneName = "SampleScene";

        [SerializeField] private GameObject settingsPanel;

        public void Play()
        {
            SceneLoader.Load(gameplaySceneName);
        }

        public void OpenSettings()
        {
            if (settingsPanel != null)
            {
                settingsPanel.SetActive(true);
            }
        }

        public void CloseSettings()
        {
            if (settingsPanel != null)
            {
                settingsPanel.SetActive(false);
            }
        }

        public void Quit()
        {
            SceneLoader.Quit();
        }
    }
}
