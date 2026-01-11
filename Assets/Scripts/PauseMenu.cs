
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    public GameObject PauseMenuCanvas;

    void Start()
    {
        PauseMenuCanvas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PauseMenuCanvas.SetActive(true);
            Time.timeScale = 0;
        }
    }

    public void ResumeGame()
    {
            PauseMenuCanvas.SetActive(false);
            Time.timeScale=1;
        
    }

    public void QuitGame()
    {
        
        PauseMenuCanvas.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale=1;
    }
}
