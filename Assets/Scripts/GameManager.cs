using UnityEngine;
using UnityEngine.SceneManagement;

public enum GameState { START, LOST }

public class GameManager : MonoBehaviour
{
    public GameState state;
    public GameObject menu;
    public GameObject win;

    // Start is called before the first frame update
    void Start()
    {
        state = GameState.START;
    }
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void ShowMenu()
    {
        menu.SetActive(true);
    }
    public void RestartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void Win()
    {
        win.SetActive(true);
    }
}