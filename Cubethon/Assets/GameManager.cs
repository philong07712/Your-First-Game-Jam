using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    bool isEnd = false;
    public float restartDelay = 2.0f;
    public GameObject completeLevelUI;
    public void winLevel()
    {
        Debug.Log("Win Level!");
        completeLevelUI.SetActive(true);
    }
    public void GameOver()
    {
        if (!isEnd)
        {
            isEnd = true;
            Invoke("Restart", 2.0f);
        }
    }
    void Restart()
    {
        isEnd = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    
}
