using UnityEngine;

namespace Canal.UI
{
    // Attach to the Start Screen's Canvas (or any object in that scene).
    // Wire the Start button's OnClick() to GoToMainMenu().
    public class StartScreenController : MonoBehaviour
    {
        [SerializeField] private string mainMenuSceneName = "MainMenu";

        public void GoToMainMenu()
        {
            SceneLoader.Load(mainMenuSceneName);
        }
    }
}
