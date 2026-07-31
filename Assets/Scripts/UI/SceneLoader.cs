using UnityEngine;
using UnityEngine.SceneManagement;

namespace Canal.UI
{
    // Static helper so any button/script can trigger a scene change by name.
    public static class SceneLoader
    {
        public static void Load(string sceneName)
        {
            SceneManager.LoadScene(sceneName);
        }

        public static void Quit()
        {
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#else
            Application.Quit();
#endif
        }
    }
}
