using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
   public void Fretful()
    {
        SceneManager.LoadScene("煩躁");
    }

    public void Melancholy()
    {
        SceneManager.LoadScene("憂鬱");
    }

    public void StartGame()
    {
        SceneManager.LoadScene("初始");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
