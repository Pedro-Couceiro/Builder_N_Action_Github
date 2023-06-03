using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    // Start is called before the first frame update
    public void StartGame()
    {
        SceneManager.LoadScene("BuildMode");
    }

    public void Settings()
    {
        SceneManager.LoadScene("Settings");
    }

    public void QuitMenu()
    {

    }
}
