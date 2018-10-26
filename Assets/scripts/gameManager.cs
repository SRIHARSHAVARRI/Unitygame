using UnityEngine;
using UnityEngine.SceneManagement;
public class gameManager : MonoBehaviour {

    bool gameHasEnded = false;
    public float restartDelay = 1f;
    public GameObject completeLevelUi;
    public void CompleteLevel()
    {
        completeLevelUi.SetActive(true);
    }

   public void EndGame()
    {
        if (gameHasEnded == false)
        {

            gameHasEnded = true;
            Debug.Log("GAME OVER");
            //restart the game;
            Invoke("Restart",restartDelay);
        }
    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }

}
