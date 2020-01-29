using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    bool isEnd = false;
    public float restartDelay = 2.0f;
    private GameManager()
    {

    }

    public void GameOver()
    {
        if (!isEnd)
        {
            isEnd = true;
            Debug.Log("GameOver");
            Invoke("Restart", 2.0f);
        }
    }
    void Restart()
    {
        isEnd = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
