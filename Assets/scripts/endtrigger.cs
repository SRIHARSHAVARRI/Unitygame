using UnityEngine;

public class endtrigger : MonoBehaviour {

    public gameManager gameManager;
    void OnTriggerEnter()
    {
        gameManager.CompleteLevel();
    }

}
