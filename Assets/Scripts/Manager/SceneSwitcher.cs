using UnityEngine.SceneManagement;
using UnityEngine;

public class SceneSwitcher : MonoBehaviour
{
   public void OpenUpScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
