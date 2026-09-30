using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class PauseMenu : MonoBehaviour
{
    public void OpenPauseMenu()
    {
        if (!SceneManager.GetSceneByName("PauseMenuUI").isLoaded)
        {
            SceneManager.LoadScene("PauseMenuUI", LoadSceneMode.Additive);
            Time.timeScale = 0f;
        }
    }

    public void ClosePauseMenu()
    {
        if (SceneManager.GetSceneByName("PauseMenuUI").isLoaded)
        {
            SceneManager.UnloadSceneAsync("PauseMenuUI");
            Time.timeScale = 1f;
        }
    }

    private void Update()
    {
        if (Keyboard.current.pKey.wasPressedThisFrame)
        {
            OpenPauseMenu();
        }

        if (Keyboard.current.oKey.wasPressedThisFrame)
        {
            ClosePauseMenu();
        }
    }
}