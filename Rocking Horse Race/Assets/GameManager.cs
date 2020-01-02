using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public bool gameHasEnded = false;
    public GameObject endGameUI;
    public GameObject whiteHorse;
    public GameObject brownHorse;
    public GameObject finishCamera;
    public Text winningHorse;

    public void EndGame(string horse) {
        if (gameHasEnded == false) {
            gameHasEnded = true;
            Debug.Log("Game Over: " + horse + " won");
            winningHorse.text = horse;
            endGameUI.SetActive(true);
            
            whiteHorse.GetComponent<Movement2>().enabled = false;
            brownHorse.GetComponent<Movement>().enabled = false;
            finishCamera.SetActive(true);
        }

    }

    private void Update() {
        // reset the game with the "r" key
        if (Input.GetKey("r")) {
            Restart();
        }
    }
    void Restart() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
