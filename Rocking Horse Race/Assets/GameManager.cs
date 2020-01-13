using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public bool gameHasEnded = false;
    public GameObject endGameUI;
    public GameObject whiteHorse;
    public GameObject brownHorse;
    public GameObject finishCamera;
    public Text winningHorse;
    public GameObject askInstructions;
    private bool isActive = false;

    public void EndGame(string horse) {
        if (gameHasEnded == false) {
            gameHasEnded = true;
            Debug.Log("Game Over: " + horse + " won");
            winningHorse.text = horse;
            endGameUI.SetActive(true);

            whiteHorse.GetComponent<Movement2>().enabled = false;
            brownHorse.GetComponent<Movement>().enabled = false;
            finishCamera.SetActive(true);
          //  StartCoroutine(AskReset());
            StartCoroutine(forceReset());
        }

    }

    private void Update() {
        // reset the game with the "r" key and go to main menu with "m" key for debugging
        if (Input.GetKey("r")) {
            Restart();
        }
        if(Input.GetKey("m")) {
            SceneManager.LoadScene("MainMenu");
        }
        if (Input.GetKey("d") && Input.GetKey(KeyCode.RightArrow) && isActive) {
            SceneManager.LoadScene("MainMenu");
        }
    }

    void Restart() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    IEnumerator AskReset() {
        yield return new WaitForSeconds(3);
        askInstructions.SetActive(true);
        isActive = true;
    }

    IEnumerator forceReset() {
        yield return new WaitForSeconds(7);
        SceneManager.LoadScene("MainMenu");
    }
}
