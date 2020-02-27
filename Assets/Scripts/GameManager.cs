using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public float restartDelay = 1.5f;
    public float endDelay = 3f;

    public GameObject completeLevelUI;
    public GameObject deadUI;

    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
        Invoke("EndScene", endDelay);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            deadUI.SetActive(true);
            Invoke("Restart", restartDelay);
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    void EndScene()
    {
        SceneManager.LoadScene("Credits");
    }
}